using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this state is when the player dropped all the pins in the first shot
/// </summary>
namespace BowlingGameProject
{
    class StrikeState : State
    {
        #region constructor
        public StrikeState(EnvProperties envProperties)
        {
            NumOfExtraIterationsToCalc = envProperties.StrikeExtraThrows;
            Name = "Strike";
        }
        #endregion
    }
}
