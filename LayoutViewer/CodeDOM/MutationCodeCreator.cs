using Microsoft.CSharp;
using Mutation.Halo.TagGroups.Attributes;
using Mutation.Halo.TagGroups.FieldTypes;
using Mutation.HEK.Common;
using Mutation.HEK.Common.TagFieldDefinitions;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.CodeDOM
{
    public class MutationCodeCreator
    {
        #region Fields

        // Internal instance of the value type dictionary.
        private static Dictionary<field_type, Type> valueTypeDictionary = null;
        /// <summary>
        /// Dictionary containing all Guerilla field_type's and their corresponding .Net object type.
        /// </summary>
        public static Dictionary<field_type, Type> ValueTypeDictionary
        {
            get
            {
                // Check if the value type dictionary has been initialized.
                if (valueTypeDictionary == null)
                {
                    // Initialize and build the dictionary.
                    BuildValueTypeDictionary();
                }

                // Return it.
                return valueTypeDictionary;
            }
            private set
            {
                // Set the value.
                valueTypeDictionary = value;
            }
        }

        // CodeDOM objects used to create source files.
        private CodeCompileUnit codeUnit;

        /// <summary>
        /// Gets the CodeDOM object for this namespace.
        /// </summary>
        public CodeNamespace CodeNamespace { get; set; }

        /// <summary>
        /// List of nested code creators.
        /// </summary>
        public List<MutationCodeCreator> ChildCodeCreators { get; private set; }

        /// <summary>
        /// Parent code scope if one exists.
        /// </summary>
        public MutationCodeCreator ParentCodeCreator { get; private set; }

        /// <summary>
        /// Gets the CodeDOM class object for this class.
        /// </summary>
        public CodeTypeDeclaration CodeClass { get; private set; }

        // Default import directives for tag definition classes.
        private static readonly string[] DefaultNamespaces = new string[]
        {
            "System",
            "System.IO",
            "Mutation.Halo",
            "Mutation.Halo.TagGroups",
            "Mutation.Halo.TagGroups.Attributes",
            "Mutation.Halo.TagGroups.FieldTypes"
        };

        /// <summary>
        /// Namespaces used in the Mutation tag layouts.
        /// </summary>
        private static readonly string[] MutationNamespaces = new string[]
        {
            "Mutation.Halo.TagGroups",
            "Mutation.Halo.TagGroups.Attributes",
            "Mutation.Halo.TagGroups.FieldTypes"
        };

        /// <summary>
        /// Mutation namespace for the tag layouts.
        /// </summary>
        public const string MutationTagsNamespace = "Mutation.Halo.TagGroups.Tags";

        /// <summary>
        /// Name of the base object type for tag block definitions.
        /// </summary>
        private const string TagBlockDefinitionBaseType = "TagBlockDefinition";

        /// <summary>
        /// Internal dictionary used to store field types and their sizes.
        /// </summary>
        private static Dictionary<string, Tuple<int, int>> fieldSizeDictionary;
        /// <summary>
        /// Dictionary used to record the size of tag fields and blocks.
        /// </summary>
        private static Dictionary<string, Tuple<int, int>> FieldSizeDictionary
        {
            get
            {
                // Check if the dictionary singleton has been instantiated yet.
                if (fieldSizeDictionary == null)
                {
                    // Build the field size dictionary.
                    BuildFieldSizeDictionary();
                }

                // Return the dictionary.
                return fieldSizeDictionary;
            }
        }

        #endregion

        #region Constructor

        public MutationCodeCreator()
        {
            // Build the value type dictionary.
            BuildValueTypeDictionary();

            // Create a new code namespace for the class.
            this.CodeNamespace = new CodeNamespace(MutationTagsNamespace);
            this.ChildCodeCreators = new List<MutationCodeCreator>();

            // Add the standard set of import directives to the namespace.
            foreach (string name in DefaultNamespaces)
            {
                // Add the import to the namespace.
                this.CodeNamespace.Imports.Add(new CodeNamespaceImport(name));
            }

            // Initialize a new code compile unit and add this namespace to it.
            this.codeUnit = new CodeCompileUnit();
            this.codeUnit.Namespaces.Add(this.CodeNamespace);
        }

        #endregion

        public MutationCodeCreator CreateChildCodeCreator()
        {
            // Create a new code creator instance.
            MutationCodeCreator codeCreator = new MutationCodeCreator();

            // Assign us as the parent.
            codeCreator.ParentCodeCreator = this;
            this.ChildCodeCreators.Add(codeCreator);

            // Return the new code creator.
            return codeCreator;
        }

        /// <summary>
        /// Creates a new class for the tag group and returns a MutationCodeCreator who's root namespace is the new class.
        /// </summary>
        /// <param name="className">Name of the class definition.</param>
        /// <param name="attributes">List of attributes to be added to the class.</param>
        /// <param name="baseType">Name of the base type if this class inherits another type.</param>
        /// <returns>A new MutationCodeCreator for the child namespace.</returns>
        public MutationCodeCreator CreateTagGroupClass(string className, CodeAttributeDeclaration[] attributes, string baseType = "")
        {
            // Create a new code creator instance.
            MutationCodeCreator codeCreator = new MutationCodeCreator();

            // Create the class code type declaration.
            codeCreator.CodeClass = new CodeTypeDeclaration(className);
            codeCreator.CodeClass.IsClass = true;

            // Set us as the parent code creator.
            codeCreator.ParentCodeCreator = this;
            this.ChildCodeCreators.Add(codeCreator);

            // Check if there is a base type for this object.
            if (baseType != "")
            {
                // Set the object base type.
                codeCreator.CodeClass.BaseTypes.Add(new CodeTypeReference(baseType));
            }

            // Add the block attribute to the class declaration.
            codeCreator.CodeClass.CustomAttributes.AddRange(attributes);

            // Add the new tag group class to our namespace.
            this.CodeNamespace.Types.Add(codeCreator.CodeClass);

            // Return the new code creator.
            return codeCreator;
        }

        /// <summary>
        /// Creates a new class for the tag block and returns a MutationCodeCreator who's root namespace is the new class.
        /// </summary>
        /// <param name="blockName">Name of the block definition.</param>
        /// <param name="attributes">List of attributes to be added to the class.</param>
        /// <returns>A new MutationCodeCreator for the child namespace.</returns>
        public MutationCodeCreator CreateTagBlockClass(string blockName, CodeAttributeDeclaration[] attributes)
        {
            // This method is here in case I decide to change the functionality of tag block definitions.
            // For now they are created the same as a tag group.
            MutationCodeCreator codeCreator = CreateTagGroupClass(blockName, attributes);

            // Add a region directive to the tag block.
            codeCreator.CodeClass.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, blockName));
            codeCreator.CodeClass.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, string.Empty));

            // Return the new code creator for the tag block.
            return codeCreator;
        }

        public void FixStructureSize()
        {
            // Loop through all of the types in the scope and update their structure sizes.
            foreach (MutationCodeCreator childType in this.ChildCodeCreators)
            {
                // Recursively fix nested structure sizes.
                childType.FixStructureSize();
            }

            // Fix the size of this structure.
            FixStructureSize(this.CodeClass);
        }

        private void FixStructureSize(CodeTypeDeclaration type)
        {
            // If this is part of the global scope then return, we have no fields to update.
            if (type == null)
                return;

            // Check to make sure we haven't already fixed this type.
            if (FieldSizeDictionary.ContainsKey(type.Name) == true)
                return;

            // Dictionary for nested type declarations that are not exposed to the global scope.
            Dictionary<string, int> typeDeclarationDictionary = new Dictionary<string, int>();

            // Loop through all the fields in the class and compute the structure size.
            int cacheFileSize = 0, tagFileSize = 0;
            for (int i = 0; i < type.Members.Count; i++)
            {
                // If this is a type declaration then cache the size of the type.
                if (type.Members[i].GetType() == typeof(CodeTypeDeclaration))
                {
                    // Cast the current member to a type declaration object.
                    CodeTypeDeclaration typeDeclaration = (CodeTypeDeclaration)type.Members[i];

                    // Check to see if the field type dictionary has a size for the type's base type.
                    if (FieldSizeDictionary.ContainsKey(typeDeclaration.BaseTypes[0].BaseType) == false)
                    {
                        // Field size dictionary does not contain an entry for this base type.
                        throw new InvalidOperationException(string.Format("Field size dictionary does not contain an entry for field type '{0}'!", typeDeclaration.BaseTypes[0].BaseType));
                    }

                    // Cache it into the type dictionary.
                    int typeSize = FieldSizeDictionary[typeDeclaration.BaseTypes[0].BaseType].Item1;
                    typeDeclarationDictionary.Add(typeDeclaration.Name, typeSize);
                }
                else
                {
                    bool SkipField = false;

                    // Cast the member to a code member field object.
                    CodeMemberField field = (CodeMemberField)type.Members[i];

                    field.Comments.Add(new CodeCommentStatement(string.Format("CacheOffset: {0}, TagOffset: {1}", cacheFileSize, tagFileSize), false));

                    // Check if the type name exists in the type dictionary.
                    int fieldSizeCacheMap = 0, fieldSizeTagFile = 0;
                    if (typeDeclarationDictionary.ContainsKey(field.Type.BaseType) == true)
                    {
                        // Base type is a custom type, get the size from the type dictionary.
                        fieldSizeCacheMap = typeDeclarationDictionary[field.Type.BaseType];
                        fieldSizeTagFile = typeDeclarationDictionary[field.Type.BaseType];
                    }
                    else
                    {
                        // Check to see if the block type is already cached, if not find it and cache its size.
                        if (FieldSizeDictionary.ContainsKey(field.Type.BaseType) == false)
                        {
                            // Find and cache the block type size.
                            if (FindAndCacheStructureSize(field.Type.BaseType, true) == false)
                            {
                                // Failed to find the type.
                                throw new InvalidOperationException(string.Format("Could not find code scope for field type '{0}'!", field.Type.BaseType));
                            }
                        }

                        // Type is a primitive type or a type exposed at the global scope.
                        fieldSizeCacheMap = FieldSizeDictionary[field.Type.BaseType].Item1;
                        fieldSizeTagFile = FieldSizeDictionary[field.Type.BaseType].Item2;
                    }

                    // Check if the current field has a TagFieldFlags attribute which may mark it tag/map only.
                    int fieldMultiplierCacheMap = 1, fieldMultiplierTagFile = 1;
                    for (int x = 0; x < field.CustomAttributes.Count; x++)
                    {
                        // Check if this is a TagFieldFlags attribute.
                        if (field.CustomAttributes[x].AttributeType.BaseType == "TagFieldFlagsAttribute")
                        {
                            // Check if this is a tag or map only field.
                            CodeSnippetExpression argument = (CodeSnippetExpression)field.CustomAttributes[x].Arguments[0].Value;
                            if (argument.Value == "TagFieldFlags.CacheMapOnly")
                            {
                                // Field is cache map only.
                                fieldSizeTagFile = 0;
                                break;
                            }
                            else if (argument.Value == "TagFieldFlags.TagFileOnly")
                            {
                                // Field is tag file only.
                                fieldSizeCacheMap = 0;
                                break;
                            }
                            else if (argument.Value == "TagFieldFlags.NonTagField")
                            {
                                // Field is not present in tags or cache maps.
                                fieldSizeCacheMap = 0;
                                fieldSizeTagFile = 0;
                            }
                        }
                        else if (field.CustomAttributes[x].AttributeType.BaseType == "PaddingAttribute")
                        {
                            // Get the attribute parameter values.
                            CodeFieldReferenceExpression paddingType = (CodeFieldReferenceExpression)field.CustomAttributes[x].Arguments[0].Value;
                            CodePrimitiveExpression paddingLength = (CodePrimitiveExpression)field.CustomAttributes[x].Arguments[1].Value;

                            // Check what type of padding this is.
                            if (paddingType.FieldName == "Padding")
                            {
                                // Padding is present always.
                                fieldMultiplierCacheMap = (int)paddingLength.Value;
                                fieldMultiplierTagFile = (int)paddingLength.Value;
                            }
                            else if (paddingType.FieldName == "Useless")
                            {
                                // Padding is only present in tag files.
                                fieldMultiplierCacheMap = 0;
                                fieldMultiplierTagFile = (int)paddingLength.Value;
                            }
                            else
                            {
                                // Padding is fake fields for GUI.
                                fieldMultiplierCacheMap = 0;
                                fieldMultiplierTagFile = 0;
                            }
                        }
                        else if (field.CustomAttributes[x].AttributeType.BaseType == "EngineVersionAttribute")
                        {
                            // Get the attribute parameter value.
                            CodeSnippetExpression minimumVersion = (CodeSnippetExpression)field.CustomAttributes[x].Arguments[0].Value;

                            // Check to see if this is a halo 2 xbox field.
                            if (minimumVersion.Value.Contains("Halo2Vista") == true)
                            {
                                // This is a vista only field, skip it.
                                SkipField = true;
                                break;
                            }
                        }
                    }

                    // Check if we should skip the field or not.
                    if (SkipField == true)
                        continue;

                    // Update the sizes.
                    cacheFileSize += (fieldMultiplierCacheMap * fieldSizeCacheMap);
                    tagFileSize += (fieldMultiplierTagFile * fieldSizeTagFile);
                }
            }

            // Add this tag group/block to the type dictionary.
            FieldSizeDictionary.Add(type.Name, new Tuple<int, int>(cacheFileSize, tagFileSize));

            // Loop through all of the custom attributes until we find the tag group or tag block definition attribute.
            for (int i = 0; i < type.CustomAttributes.Count; i++)
            {
                // Check if this is the tag group or tag block attribute.
                if (type.CustomAttributes[i].Name == "TagGroupDefinitionAttribute" || type.CustomAttributes[i].Name == "TagBlockDefinitionAttribute")
                {
                    // Update the sizes for this tag definition.
                    type.CustomAttributes[i].Arguments[0].Value = new CodeSnippetExpression(string.Format("cacheFileSize: {0}", cacheFileSize));
                    type.CustomAttributes[i].Arguments[1].Value = new CodeSnippetExpression(string.Format("tagFileSize: {0}", tagFileSize));
                }
            }
        }

        private bool FindAndCacheStructureSize(string typeName, bool searchParent)
        {
            // Loop through all of the child types in this scope and search for the type.
            foreach (CodeTypeDeclaration childType in this.CodeNamespace.Types)
            {
                // Check if this is the type we are looking for.
                //System.Diagnostics.Debug.WriteLine(string.Format("Searching: {0}", childType.Name));
                if (childType.Name == typeName)
                {
                    // Cache the structure size for this type.
                    FixStructureSize(childType);
                    return true;
                }
            }

            // Loop through all of the child code creators and recursively search for the type.
            foreach (MutationCodeCreator childCreator in this.ChildCodeCreators)
            {
                // Recursively search for the type.
                if (childCreator.FindAndCacheStructureSize(typeName, false) == true)
                    return true;
            }

            // Type was not found in any child scope, recursively search the parent scope.
            if (searchParent == true && this.ParentCodeCreator != null)
            {
                // Search the parent code scope.
                return this.ParentCodeCreator.FindAndCacheStructureSize(typeName, true);
            }

            // The type was not found.
            return false;
        }

        /// <summary>
        /// Creates a new field for the specified type and adds it to the current code object.
        /// </summary>
        /// <param name="fieldType">Guerilla field type of the field.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="attributeCollection">Collection of attributes to be put on the field.</param>
        public void AddField(field_type fieldType, string fieldName, CodeAttributeDeclarationCollection attributeCollection = null)
        {
            // Get the underlying type for this field.
            Type standardFieldType = ValueTypeDictionary[fieldType];

            // Create a new code member field for the tag field.
            CodeMemberField field = new CodeMemberField(MutationCodeFormatter.CreateShortCodeTypeReference(standardFieldType, MutationNamespaces), fieldName);
            field.Attributes = MemberAttributes.Public;

            // Add any attributes for this field.
            field.CustomAttributes = attributeCollection;

            // Check if this field has an EngineVersionAttribute, and if so move it to the end of the attribute list.
            for (int i = 0; i < field.CustomAttributes.Count; i++)
            {
                // Check if this attribute is the EngineVersionAttribute and if so move it to the front of the list.
                if (field.CustomAttributes[i].Name == "EngineVersionAttribute")
                {
                    // Move the attribute to the end of the list so it appears on top of the field declaration.
                    CodeAttributeDeclaration attribute = field.CustomAttributes[i];
                    field.CustomAttributes.RemoveAt(i);
                    field.CustomAttributes.Add(attribute);

                    // Break the loop.
                    break;
                }
            }

            // Add the field to the class definition.
            this.CodeClass.Members.Add(field);
        }

        /// <summary>
        /// Creates a new field for a custom type and adds it to the current code object.
        /// </summary>
        /// <param name="fieldType">Guerilla field type of the field.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="fieldTypeName">Name of the custom type.</param>
        /// <param name="attributeCollection">Collection of attributes to be put on the field.</param>
        public void AddCustomTypedField(field_type fieldType, string fieldName, string fieldTypeName, CodeAttributeDeclarationCollection attributeCollection = null)
        {
            // Get the underlying type for this field.
            Type standardFieldType = ValueTypeDictionary[fieldType];

            // If the field name is the same as the type name then we have to append an '@' character.
            if (fieldName.Equals(fieldTypeName) == true)
                fieldName.Insert(0, "@");

            // Create a new code member field for the tag field.
            CodeMemberField field = new CodeMemberField(fieldTypeName, fieldName);
            field.Attributes = MemberAttributes.Public;

            // Add any attributes for this field.
            field.CustomAttributes = attributeCollection;

            // Check if this field has an EngineVersionAttribute, and if so move it to the end of the attribute list.
            for (int i = 0; i < field.CustomAttributes.Count; i++)
            {
                // Check if this attribute is the EngineVersionAttribute and if so move it to the front of the list.
                if (field.CustomAttributes[i].Name == "EngineVersionAttribute")
                {
                    // Move the attribute to the end of the list so it appears on top of the field declaration.
                    CodeAttributeDeclaration attribute = field.CustomAttributes[i];
                    field.CustomAttributes.RemoveAt(i);
                    field.CustomAttributes.Add(attribute);

                    // Break the loop.
                    break;
                }
            }

            // Add the field to the class definition.
            this.CodeClass.Members.Add(field);
        }

        /// <summary>
        /// Creates a new enum or bitmask type definition in the current code object.
        /// </summary>
        /// <param name="codeScope">Code scope of the enum for ensuring each flag option is unique.</param>
        /// <param name="field">Enum definition from Guerilla.</param>
        public void AddEnumOrBitmask(MutationCodeScope codeScope, enum_definition field)
        {
            // Determine the underlying type for the enum based on the field type.
            Type fieldType = ValueTypeDictionary[field.type];

            // Create the enum field by creating a new CodeTypeDeclaration.
            CodeTypeDeclaration @enum = new CodeTypeDeclaration(codeScope.Namespace);
            @enum.IsEnum = true;
            @enum.BaseTypes.Add(fieldType);

            // Check if this field is a bitmask and if so add the Flags attribute.
            if (codeScope.Type == MutationCodeScopeType.Bitmask)
            {
                // Setup a code attribute declaration object for the Flags attribute.
                CodeAttributeDeclaration attribute = new CodeAttributeDeclaration(new CodeTypeReference(typeof(FlagsAttribute).Name));
                @enum.CustomAttributes.Add(attribute);
            }

            // Loop through all of the enum options and add each one to the enum field.
            for (int i = 0; i < field.option_count; i++)
            {
                // Check if the option name is valid and if not skip it.
                if (field.options[i] == string.Empty)
                    continue;

                // Create a code safe field name for the enum option.
                string displayName, units, tooltip, color;
                EditorMarkUpFlags markupFlags;
                string optionName = codeScope.CreateCodeSafeFieldName(field_type._field_enum_option, field.options[i], out displayName, out units, out tooltip, out color, out markupFlags);

                // Create a new CodeMemberField for the enum option.
                CodeMemberField option = new CodeMemberField
                {
                    Name = optionName,

                    // Set the flag value accordingly.
                    InitExpression = new CodeSnippetExpression(string.Format("0x{0}", 
                    (codeScope.Type == MutationCodeScopeType.Bitmask ? (1 << i) : i).ToString("x"))),
                };

                // Create a new UI markup attribute and add it to the enum option.
                option.CustomAttributes.Add(EditorMarkUpAttribute.CreateAttributeDeclaration(flags: markupFlags, displayName: displayName, unitsSpecifier: units, tooltipText: tooltip, fieldColor: color));

                // Add the option to the enum.
                @enum.Members.Add(option);
            }

            // Check if this field has an EngineVersionAttribute, and if so move it to the end of the attribute list.
            for (int i = 0; i < @enum.CustomAttributes.Count; i++)
            {
                // Check if this attribute is the EngineVersionAttribute and if so move it to the front of the list.
                if (@enum.CustomAttributes[i].Name == "EngineVersionAttribute")
                {
                    // Move the attribute to the end of the list so it appears on top of the field declaration.
                    CodeAttributeDeclaration attribute = @enum.CustomAttributes[i];
                    @enum.CustomAttributes.RemoveAt(i);
                    @enum.CustomAttributes.Add(attribute);

                    // Break the loop.
                    break;
                }
            }

            // Add the enum to the class definition.
            this.CodeClass.Members.Add(@enum);
        }

        /// <summary>
        /// Creates a new padding field and adds it to the current code object.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="paddingLength">Size of the padding field.</param>
        /// <param name="attributeCollection">Collection of attributes to be put on the field.</param>
        public void AddPaddingField(string fieldName, int paddingLength, CodeAttributeDeclarationCollection attributeCollection = null)
        {
            // Create a new code member field for the tag field.
            CodeMemberField field = new CodeMemberField(typeof(byte[]), fieldName);
            field.Attributes = MemberAttributes.Public;

            // Add any attributes for this field.
            field.CustomAttributes = attributeCollection;

            // Check if this field has an EngineVersionAttribute, and if so move it to the end of the attribute list.
            for (int i = 0; i < field.CustomAttributes.Count; i++)
            {
                // Check if this attribute is the EngineVersionAttribute and if so move it to the front of the list.
                if (field.CustomAttributes[i].Name == "EngineVersionAttribute")
                {
                    // Move the attribute to the end of the list so it appears on top of the field declaration.
                    CodeAttributeDeclaration attribute = field.CustomAttributes[i];
                    field.CustomAttributes.RemoveAt(i);
                    field.CustomAttributes.Add(attribute);

                    // Break the loop.
                    break;
                }
            }

            // Add the field to the class definition.
            this.CodeClass.Members.Add(field);
        }

        /// <summary>
        /// Creates a new Explanation field using the information provided.
        /// </summary>
        /// <param name="fieldName">Name of the explanation field.</param>
        /// <param name="blockName">Name of the explanation block.</param>
        /// <param name="explanation">Explanation for the block.</param>
        /// <param name="attributeCollection">Collection of attributes to be put on the field.</param>
        public void AddExplanationField(string fieldName, string blockName = "", string explanation = "", CodeAttributeDeclarationCollection attributeCollection = null)
        {
            // Get the underlying type for this field.
            Type standardFieldType = ValueTypeDictionary[field_type._field_explanation];

            // Create a new code member field for the explanation block.
            CodeMemberField field = new CodeMemberField(MutationCodeFormatter.CreateShortCodeTypeReference(standardFieldType, MutationNamespaces), fieldName);
            field.Attributes = MemberAttributes.Public;

            // Create a list of parameters to give to the explanation constructor.
            List<CodeExpression> initializers = new List<CodeExpression>();

            // Check if the block name is present.
            if (blockName != string.Empty)
            {
                // Create a code expression for the block name initializer.
                initializers.Add(new CodeSnippetExpression(string.Format("name: \"{0}\"", blockName)));
            }

            // Check if the explanation is present.
            if (MutationCodeFormatter.IsValidFieldName(explanation) == true)
            {
                // Create a code expression for the explanation initializer.
                initializers.Add(new CodeSnippetExpression(string.Format("explanation: {0}", MutationCodeFormatter.CreateCodeSafeStringLiteral(explanation))));
            }

            // Create the init expression which will call the constructor of the Explanation object.
            field.InitExpression = new CodeObjectCreateExpression(MutationCodeFormatter.CreateShortCodeTypeReference(standardFieldType, MutationNamespaces), initializers.ToArray());

            // Add any attributes for this field.
            field.CustomAttributes = attributeCollection;

            // Check if this field has an EngineVersionAttribute, and if so move it to the end of the attribute list.
            for (int i = 0; i < field.CustomAttributes.Count; i++)
            {
                // Check if this attribute is the EngineVersionAttribute and if so move it to the front of the list.
                if (field.CustomAttributes[i].Name == "EngineVersionAttribute")
                {
                    // Move the attribute to the end of the list so it appears on top of the field declaration.
                    CodeAttributeDeclaration attribute = field.CustomAttributes[i];
                    field.CustomAttributes.RemoveAt(i);
                    field.CustomAttributes.Add(attribute);

                    // Break the loop.
                    break;
                }
            }

            // Add the field to the class definition.
            this.CodeClass.Members.Add(field);
        }

        /// <summary>
        /// Creates a new tag block field and adds it to the current code object.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="blockTypeName">Name of the underlying tag block definition type.</param>
        /// <param name="attributeCollection">Collection of attributes to be put on the field.</param>
        public void AddTagBlockField(string fieldName, string blockTypeName, CodeAttributeDeclarationCollection attributeCollection = null)
        {
            // Create a new code type reference to reference the tag_block data type.
            CodeTypeReference tagBlockType = MutationCodeFormatter.CreateShortCodeTypeReference(ValueTypeDictionary[field_type._field_block], MutationNamespaces);
            tagBlockType.TypeArguments.Add(blockTypeName);

            // Create a new code member field for the tag field.
            CodeMemberField field = new CodeMemberField(tagBlockType, fieldName);
            field.Attributes = MemberAttributes.Public;

            // Add any attributes for this field.
            field.CustomAttributes = attributeCollection;

            // Check if this field has an EngineVersionAttribute, and if so move it to the end of the attribute list.
            for (int i = 0; i < field.CustomAttributes.Count; i++)
            {
                // Check if this attribute is the EngineVersionAttribute and if so move it to the front of the list.
                if (field.CustomAttributes[i].Name == "EngineVersionAttribute")
                {
                    // Move the attribute to the end of the list so it appears on top of the field declaration.
                    CodeAttributeDeclaration attribute = field.CustomAttributes[i];
                    field.CustomAttributes.RemoveAt(i);
                    field.CustomAttributes.Add(attribute);

                    // Break the loop.
                    break;
                }
            }

            // Add the field to the class definition.
            this.CodeClass.Members.Add(field);
        }

        /// <summary>
        /// Writes the current code scope to file.
        /// </summary>
        /// <param name="fileName">File name to write the code to.</param>
        public void WriteToFile(string fileName)
        {
            // Create a new CSharpCodeProvider to generate the code for us.
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();

            // Create a new stream writer to write the file.
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Create a new IndentedTextWriter to format the code is a nice mannor.
                IndentedTextWriter tw = new IndentedTextWriter(writer, "    ");

                // Setup the code generation options for style preferences.
                CodeGeneratorOptions options = new CodeGeneratorOptions();
                options.BlankLinesBetweenMembers = true;
                options.BracingStyle = "C";
                options.VerbatimOrder = false;

                // Generate the code using the code provider.
                codeProvider.GenerateCodeFromCompileUnit(this.codeUnit, tw, options);

                // Close the text writer.
                tw.Close();
            }

            // Dispose of the code provider.
            codeProvider.Dispose();
        }

        /// <summary>
        /// Recursively searches for an existing code creator with the specified class name.
        /// </summary>
        /// <param name="className">Class name of the code creator to find.</param>
        /// <returns>A MutationCodeCreator with the specified class name if one exists, or null otherwise.</returns>
        public MutationCodeCreator FindExistingCodeCreator(string className)
        {
            // Check if any of our child code creators have a code class with the specified class name.
            if (this.ChildCodeCreators.Count(creator => creator.CodeClass != null && creator.CodeClass.Name == className) > 0)
            {
                // Return the code creator with the specified class name.
                return this.ChildCodeCreators.Single(creator => creator.CodeClass != null && creator.CodeClass.Name == className);
            }

            // Check if we have a parent code creator and if so recursively search for a code creator with the specified class name.
            if (this.ParentCodeCreator != null)
            {
                // Recursively search for the code creator.
                return this.ParentCodeCreator.FindExistingCodeCreator(className);
            }

            // A code creator with the specified class name was not found.
            return null;
        }

        #region Caching Functions

        /// <summary>
        /// Builds the list of .Net types that encapsulate Guerilla field types.
        /// </summary>
        private static void BuildValueTypeDictionary()
        {
            // Add the basic field types to the dictionary.
            ValueTypeDictionary = new Dictionary<field_type, Type>((int)field_type._field_type_max);
            ValueTypeDictionary.Add(field_type._field_char_integer, typeof(byte));
            ValueTypeDictionary.Add(field_type._field_short_integer, typeof(short));
            ValueTypeDictionary.Add(field_type._field_long_integer, typeof(int));
            ValueTypeDictionary.Add(field_type._field_angle, typeof(float));
            ValueTypeDictionary.Add(field_type._field_real, typeof(float));
            ValueTypeDictionary.Add(field_type._field_real_fraction, typeof(float));
            ValueTypeDictionary.Add(field_type._field_char_enum, typeof(byte));
            ValueTypeDictionary.Add(field_type._field_enum, typeof(short));
            ValueTypeDictionary.Add(field_type._field_long_enum, typeof(int));
            ValueTypeDictionary.Add(field_type._field_byte_flags, typeof(byte));
            ValueTypeDictionary.Add(field_type._field_word_flags, typeof(short));
            ValueTypeDictionary.Add(field_type._field_long_flags, typeof(uint));
            ValueTypeDictionary.Add(field_type._field_byte_block_flags, typeof(byte));
            ValueTypeDictionary.Add(field_type._field_word_block_flags, typeof(short));
            ValueTypeDictionary.Add(field_type._field_long_block_flags, typeof(int));
            ValueTypeDictionary.Add(field_type._field_char_block_index1, typeof(byte));
            ValueTypeDictionary.Add(field_type._field_short_block_index1, typeof(short));
            ValueTypeDictionary.Add(field_type._field_long_block_index1, typeof(int));
            ValueTypeDictionary.Add(field_type._field_char_block_index2, typeof(byte));
            ValueTypeDictionary.Add(field_type._field_short_block_index2, typeof(short));
            ValueTypeDictionary.Add(field_type._field_long_block_index2, typeof(int));

            // Generate a list of types from the Mutation.Halo assembly.
            Type[] assemblyTypes = Assembly.GetAssembly(typeof(GuerillaTypeAttribute)).GetTypes();

            // Find all the types that have a GuerillaTypeAttribute attached to them.
            var guerillaTypes = from type in assemblyTypes
                                where type.GetCustomAttributes(typeof(GuerillaTypeAttribute), false).Count() > 0
                                select type;

            // Add all the types to the value type dictionary.
            foreach (Type fieldType in guerillaTypes)
            {
                // Get the guerilla type attributes attached to the type.
                GuerillaTypeAttribute[] guerillaAttr = (GuerillaTypeAttribute[])fieldType.GetCustomAttributes(typeof(GuerillaTypeAttribute), false);
                foreach (GuerillaTypeAttribute singleAttr in guerillaAttr)
                {
                    // Add the field type to the value type dictionary.
                    ValueTypeDictionary.Add(singleAttr.FieldType, fieldType);
                }
            }
        }

        /// <summary>
        /// Builds the field size dictionary using all known field types and their sizes.
        /// </summary>
        private static void BuildFieldSizeDictionary()
        {
            // Initialize the dictionary.
            fieldSizeDictionary = new Dictionary<string, Tuple<int, int>>();

            // Add the built in primitive types.
            fieldSizeDictionary.Add("System.Byte", new Tuple<int, int>(1, 1));
            fieldSizeDictionary.Add("System.Char", new Tuple<int, int>(1, 1));
            fieldSizeDictionary.Add("System.Int16", new Tuple<int, int>(2, 2));
            fieldSizeDictionary.Add("System.UInt16", new Tuple<int, int>(2, 2));
            fieldSizeDictionary.Add("System.Int32", new Tuple<int, int>(4, 4));
            fieldSizeDictionary.Add("System.UInt32", new Tuple<int, int>(4, 4));
            fieldSizeDictionary.Add("System.Single", new Tuple<int, int>(4, 4));

            // Special cases.
            fieldSizeDictionary.Add("Explanation", new Tuple<int, int>(0, 0));
            fieldSizeDictionary.Add("tag_block`1", new Tuple<int, int>(8, 8));

            // Generate a list of types from the Mutation.Halo assembly.
            Type[] assemblyTypes = Assembly.GetAssembly(typeof(GuerillaTypeAttribute)).GetTypes();

            // Find all the types that have a GuerillaTypeAttribute attached to them.
            var guerillaTypes = from type in assemblyTypes
                                where type.GetCustomAttributes(typeof(GuerillaTypeAttribute), false).Count() > 0
                                select type;

            // Loop through all of the field types and add them to the dictionary.
            foreach (Type fieldType in guerillaTypes)
            {
                // Find the kSizeOf field so we can add this type to the size dictionary.
                FieldInfo kSizeOf = fieldType.GetFields().FirstOrDefault(field => field.Name == "kSizeOf");
                if (kSizeOf == null)
                {
                    // Field type does not have a kSizeOf field.
                    throw new InvalidOperationException(string.Format("Field type '{0}' does not contain a kSizeOf field!", fieldType.Name));
                }

                // Check to make sure we haven't already added this type.
                if (fieldSizeDictionary.ContainsKey(fieldType.Name) == false)
                {
                    // Create a new instance of the field so that we can get the kSizeOf value.
                    object fieldInstance = Activator.CreateInstance(fieldType);

                    // Cache the field type and its size.
                    int fieldSize = (int)kSizeOf.GetValue(fieldType);
                    fieldSizeDictionary.Add(fieldType.Name, new Tuple<int, int>(fieldSize, fieldSize));
                }
            }
        }

        #endregion
    }
}
