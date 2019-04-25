using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this class manage game configurations
/// -> default values: frameNumber = "10", pinNum = "10", spareExtraThrows = "1", strikeExtraThrows = "2"
/// </summary>
namespace BowlingGameProject
{
    class EnvProperties
    {
        #region public properties
        public int FrameNumber
        {
            get;
        }

        public int PinNumber
        {
            get;
        }

        public int SpareExtraThrows
        {
            get;
        }

        public int StrikeExtraThrows
        {
            get;
        }
        #endregion

        #region constructor
        public EnvProperties(string frameNumber = "10", string pinNum = "10", string spareExtraThrows = "1", string strikeExtraThrows = "2")
        {
            FrameNumber = int.Parse(frameNumber);
            PinNumber = int.Parse(pinNum);
            SpareExtraThrows = int.Parse(spareExtraThrows);
            StrikeExtraThrows = int.Parse(strikeExtraThrows);
        }
        #endregion
    }
}
