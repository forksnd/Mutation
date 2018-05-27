using Mutation.Halo.Cache.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string mapFile = "G:\\Halo 2\\Xbox\\Maps\\clean\\foundation.map";

            // Create a new cache map object and read the map file.
            H2XCacheMap cacheMap = new H2XCacheMap(mapFile);
            if (cacheMap.Read() == false)
            {
                // Read to read the map file.
                Console.WriteLine("Failed to read cache map \"{0}\"!", mapFile);
                return;
            }
        }
    }
}
