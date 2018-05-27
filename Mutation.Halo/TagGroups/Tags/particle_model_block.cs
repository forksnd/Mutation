//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mutation.Halo.TagGroups.Tags
{
    using System;
    using System.IO;
    using Mutation.Halo;
    using Mutation.Halo.TagGroups;
    using Mutation.Halo.TagGroups.Attributes;
    using Mutation.Halo.TagGroups.FieldTypes;
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 224, tagFileSize: 292, version: 1, groupTag: "PRTM", parentGroupTag: "", name: "particle_model", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class particle_model_block
    {
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "orientation")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_orientation orientation;
        
        [PaddingAttribute(PaddingType.Padding, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "shader")]
        [TagReferenceAttribute("shad")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference shader;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "SCALE X", explanation: "scale of model on x axis");
        
        [EditorMarkUpAttribute(displayName: "scale x")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public particle_property_scalar_struct_new_block scale_x;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "SCALE Y", explanation: "scale of model on y axis");
        
        [EditorMarkUpAttribute(displayName: "scale y")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public particle_property_scalar_struct_new_block scale_y;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "SCALE Z", explanation: "scale of model on z axis");
        
        [EditorMarkUpAttribute(displayName: "scale z")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public particle_property_scalar_struct_new_block scale_z;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "ROTATION", explanation: "rotation where 0=0 degrees, 0.5=180 degrees, 1.0=360 degrees");
        
        [EditorMarkUpAttribute(displayName: "rotation")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public particle_property_scalar_struct_new_block rotation;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField4 = new Explanation(name: "Spawned Effects", explanation: "collision occurs when particle physics has collision, death spawned when particle" +
    " dies");
        
        [EditorMarkUpAttribute(displayName: "collision effect", tooltipText: "effect, material effect or sound spawned when this particle collides with somethi" +
    "ng")]
        [TagReferenceAttribute("")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference collision_effect;
        
        [EditorMarkUpAttribute(displayName: "death effect", tooltipText: "effect, material effect or sound spawned when this particle dies")]
        [TagReferenceAttribute("")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference death_effect;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField5 = new Explanation(name: "Attached Particle Systems", explanation: "Locations:\nup - particles shoot straight up\ngravity - particles shoot straight do" +
    "wn\nNONE - opposite of particle direction");
        
        [EditorMarkUpAttribute(displayName: "locations")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<effect_locations_block> locations;
        
        [EditorMarkUpAttribute(displayName: "attached particle systems")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particle_system_definition_block_new> attached_particle_systems;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "models")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particle_models_block> models;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "raw vertices")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particle_model_vertices_block> raw_vertices;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "indices")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particle_model_indices_block> indices;
        
        [EditorMarkUpAttribute(displayName: "cached data")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<cached_data_block> cached_data;
        
        [EditorMarkUpAttribute(displayName: "geometry section info")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public global_geometry_block_info_struct_block geometry_section_info;
        
        [PaddingAttribute(PaddingType.Padding, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [PaddingAttribute(PaddingType.Padding, 8)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "spins")]
            spins = 0x1,
            
            [EditorMarkUpAttribute(displayName: "random u mirror")]
            random_u_mirror = 0x2,
            
            [EditorMarkUpAttribute(displayName: "random v mirror")]
            random_v_mirror = 0x4,
            
            [EditorMarkUpAttribute(displayName: "frame animation one shot")]
            frame_animation_one_shot = 0x8,
            
            [EditorMarkUpAttribute(displayName: "select random sequence")]
            select_random_sequence = 0x10,
            
            [EditorMarkUpAttribute(displayName: "disable frame blending")]
            disable_frame_blending = 0x20,
            
            [EditorMarkUpAttribute(displayName: "can animate backwards")]
            can_animate_backwards = 0x40,
            
            [EditorMarkUpAttribute(displayName: "receive lightmap lighting")]
            receive_lightmap_lighting = 0x80,
            
            [EditorMarkUpAttribute(displayName: "tint from diffuse texture")]
            tint_from_diffuse_texture = 0x100,
            
            [EditorMarkUpAttribute(displayName: "dies at rest")]
            dies_at_rest = 0x200,
            
            [EditorMarkUpAttribute(displayName: "dies on structure collision")]
            dies_on_structure_collision = 0x400,
            
            [EditorMarkUpAttribute(displayName: "dies in media")]
            dies_in_media = 0x800,
            
            [EditorMarkUpAttribute(displayName: "dies in air")]
            dies_in_air = 0x1000,
            
            [EditorMarkUpAttribute(displayName: "bitmap authored vertically")]
            bitmap_authored_vertically = 0x2000,
            
            [EditorMarkUpAttribute(displayName: "has sweetener")]
            has_sweetener = 0x4000,
        }
        
        public enum e_orientation : int
        {
            
            [EditorMarkUpAttribute(displayName: "screen facing")]
            screen_facing = 0x0,
            
            [EditorMarkUpAttribute(displayName: "parallel to direction")]
            parallel_to_direction = 0x1,
            
            [EditorMarkUpAttribute(displayName: "perpendicular to direction")]
            perpendicular_to_direction = 0x2,
            
            [EditorMarkUpAttribute(displayName: "vertical")]
            vertical = 0x3,
            
            [EditorMarkUpAttribute(displayName: "horizontal")]
            horizontal = 0x4,
        }
    }
    
    #region particle_models_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 256)]
    public class particle_models_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "model name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id model_name;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "index start")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short index_start;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "index count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short index_count;
    }
    #endregion
    
    #region particle_model_vertices_block
    [TagBlockDefinitionAttribute(cacheFileSize: 56, tagFileSize: 56, alignment: 4, maxBlockCount: 32768)]
    public class particle_model_vertices_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "position")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d position;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "normal")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d normal;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "tangent")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d tangent;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "binormal")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d binormal;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "texcoord")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d texcoord;
    }
    #endregion
    
    #region particle_model_indices_block
    [TagBlockDefinitionAttribute(cacheFileSize: 2, tagFileSize: 2, alignment: 4, maxBlockCount: 32768)]
    public class particle_model_indices_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short index;
    }
    #endregion
    
    #region cached_data_block
    [TagBlockDefinitionAttribute(cacheFileSize: 32, tagFileSize: 32, alignment: 4, maxBlockCount: 1)]
    public class cached_data_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "vertex buffer")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public VertexBuffer vertex_buffer;
    }
    #endregion
}
