using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo
{
    /// <summary>
    /// Enum of supported Halo engine types.
    /// </summary>
    public enum EngineVersion
    {
        Minimum,
        Halo2Xbox,
        Halo2Vista,
        Maximum
    }

    public enum e_map_type : int
    {
        Singleplayer = 0,
        Multiplayer = 1,
        MainMenu = 2,
        Shared = 3,
        SingleplayerShared = 4
    }
}
