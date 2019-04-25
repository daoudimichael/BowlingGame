using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this state is when the player dropped all the pins in two shots
/// </summary>
namespace BowlingGameProject
{
    class SpareState : State
    {
        #region constructor
        public SpareState(EnvProperties envProperties)
        {
            NumOfExtraIterationsToCalc = envProperties.SpareExtraThrows;
            Name = "Spare";
        }
        #endregion
    }
}
