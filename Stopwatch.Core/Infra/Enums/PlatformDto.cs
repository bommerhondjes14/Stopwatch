using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Infra.Enums
{
    public enum PlatformDto
    {
        /// <summary>
        /// North America.
        /// </summary>
        NA1,

        /// <summary>
        /// Brasil.
        /// </summary>
        BR1,

        /// <summary>
        /// Latin America North.
        /// </summary>
        LA1,

        /// <summary>
        /// Latin America South.
        /// </summary>
        LA2,

        /// <summary>
        /// Oceania.
        /// </summary>
        OC1,

        /// <summary>
        /// North-eastern Europe.
        /// </summary>
        EUN1,

        /// <summary>
        /// Turkey.
        /// </summary>
        TR1,

        /// <summary>
        /// Russia.
        /// </summary>
        RU,

        /// <summary>
        /// Western Europe.
        /// </summary>
        EUW1,

        /// <summary>
        /// Korea.
        /// </summary>
        KR,

        /// <summary>
        /// No Platform (e.g. platformId of bot players).
        /// </summary>
        NoPlatform
    }
}
