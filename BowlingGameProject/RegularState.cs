using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this state is a basic game state
/// </summary>
namespace BowlingGameProject
{
    class RegularState : State
    {
        #region constructor
        public RegularState(EnvProperties envProperties)
        {
            NumOfExtraIterationsToCalc = 0;
            Name = "Regular";
        }
        #endregion
    }
}
