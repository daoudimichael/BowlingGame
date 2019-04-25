using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// base class for all game states
/// contains for each game state how many extra iterations are staying to this frame
/// </summary>
namespace BowlingGameProject
{
    class State
    {
        #region protected properties
        protected int NumOfExtraIterationsToCalc
        {
            get; set;
        }
        #endregion

        #region public properties
        public string Name
        {
            get; set;
        }

        public Boolean ThereIsMoreIteration()
        {
            if (NumOfExtraIterationsToCalc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region public methods
        public void UpdateOfExtraIterationToCalc()
        {
            NumOfExtraIterationsToCalc--;
        }
        #endregion
    }
}
