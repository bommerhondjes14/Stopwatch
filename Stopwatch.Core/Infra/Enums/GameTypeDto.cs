using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Infra.Enums
{
    /// <summary>
    /// Type of the game.
    /// </summary>
    public enum GameTypeDto
    {
        /// <summary>
        /// Custom games.
        /// </summary>
        CustomGame,

        /// <summary>
        /// Neither tutorial nor custom games
        /// </summary>
        MatchedGame,

        /// <summary>
        /// Tutorial games.
        /// </summary>
        TutorialGame
    }
}
