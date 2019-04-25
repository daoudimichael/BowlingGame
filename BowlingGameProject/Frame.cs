using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this class is define one frame during the Bowling game
/// </summary>
namespace BowlingGameProject
{
    class Frame
    {
        #region members
        private EnvProperties _envProperties;
        private int _currentIteration;
        #endregion

        #region properties
        public State State
        {
            get; private set;
        }

        public int Score
        {
            get; private set;
        }

        public bool StillPlay
        {
            get; private set;
        }

        public int Number
        {
            get; private set;
        }
        #endregion

        #region constructor
        public Frame(EnvProperties envProperties, int number)
        {
            _envProperties = envProperties;
            _currentIteration = 1;

            StillPlay = true;
            Score = 0;
            State = new RegularState(envProperties);
            Number = number;
        }
        #endregion

        #region public methods
        public void Play(int pinsFall)
        {
            Score += pinsFall;
            if (_currentIteration == 1 && Score == _envProperties.PinNumber)
            {
                State = new StrikeState(_envProperties);
                StillPlay = false;
            }
            else if (_currentIteration == 2 && Score == _envProperties.PinNumber)
            {
                State = new SpareState(_envProperties);
            }

            if (_currentIteration++ == 2)
            {
                StillPlay = false;
            }

            Console.WriteLine("Updating score: {0}", Score);
            Console.WriteLine("State: {0}", State.Name);
            if (StillPlay)
            {
                Console.WriteLine("U MUST drop all the pins bro! DO IT!");
            }
            else
            {
                Console.WriteLine("This frame is Finished");
                Console.WriteLine("**************************************************************");
            }

        }

        public void UpdateScore(int num)
        {
            Score += num;
            State.UpdateOfExtraIterationToCalc();
            Console.WriteLine("The score of frame #{0} is updated to {1}", Number, Score);
        }
        #endregion
    }
}
