using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this class is manage the Bowling game
/// -----------------------------------------------------------------
/// -> loop on frames number
///     -> check if the frame is still active
///     -> get from user how many pins dropped
///     -> validate number
///     -> play
///     -> updating score for previous frames with specific states
///     -> print status
/// -> loop until there isn't frame to update
///     -> updating scores
///     -> print status
///     -------------------------------------------------------------
/// </summary>
namespace BowlingGameProject
{
    class GameManager
    {
        #region members
        private EnvProperties envProperties;
        private LinkedList<Frame> frames;
        #endregion

        #region constructor
        public GameManager(EnvProperties envProperties)
        {
            this.envProperties = envProperties;
            frames = new LinkedList<Frame>();
        }
        #endregion

        #region public methods
        public void StartGame()
        {
            Console.WriteLine("lets start Bowling gmae!! yyaaaaa sooooooo funnn :)");
            for (int i = 0; i < this.envProperties.FrameNumber; i++)
            {
                Console.WriteLine("R U Ready????, Frame number {0} is starting!!", i + 1);
                Frame frame = new Frame(envProperties, i + 1);
                while (frame.StillPlay)
                {
                    Console.WriteLine("Please enter how many pins are dropped: ");
                    String number = Console.ReadLine();
                    bool isNumber = int.TryParse(number, out int num);
                    if (isNumber)
                    {
                        if (ValidateNumber(num, frame))
                        {
                            frame.Play(num);
                            UpdateScoreForPreviousFrames(num);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, Please enter a number!");
                    }
                }
                frames.AddLast(frame);
                WriteCurrentStatus();
            }
            while (CheckIfExtraIterationsIsNeeded())
            {
                Console.WriteLine("U R So good bro!! U have more throw...");
                Console.WriteLine("Please enter how many pins are dropped: ");
                String number = Console.ReadLine();
                bool isNumber = int.TryParse(number, out int num);
                if (isNumber && ValidateNumber(num, new Frame(envProperties, 0)))
                {
                    UpdateScoreForPreviousFrames(num);
                    WriteCurrentStatus();
                }
                else
                {
                    Console.WriteLine("Invalid number, please try again!");
                }
            }
        }
        #endregion

        #region private methods
        private void WriteCurrentStatus()
        {
            Console.WriteLine("**************************************************************");
            int currentTotalScore = 0;
            foreach (Frame frame in frames)
            {
                Console.WriteLine("Frame #{0}: Score - {1}, State - {2}", frame.Number, frame.Score, frame.State.Name);
                currentTotalScore += frame.Score;
            }
            Console.WriteLine("Total score: {0}", currentTotalScore);
            Console.WriteLine("**************************************************************");
        }

        private void UpdateScoreForPreviousFrames(int num)
        {
            foreach (Frame frame in frames)
            {
                if (frame.State.ThereIsMoreIteration())
                {
                    frame.UpdateScore(num);
                }
            }
        }

        private bool CheckIfExtraIterationsIsNeeded()
        {
            foreach (Frame frame in frames)
            {
                if (frame.State.ThereIsMoreIteration())
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateNumber(int num, Frame currentFrame)
        {
            if (num < 0 || num > envProperties.PinNumber)
            {
                Console.WriteLine("Invalid entry, Please enter a number in range of 0 until {0}", envProperties.PinNumber);
                return false;
            }
            else if ((currentFrame.Score + num) > envProperties.PinNumber)
            {
                Console.WriteLine("Whaatttt???? How much pins U have there???? Makes no sense :(");
                return false;
            }
            return true;
        }
        #endregion
    }
}
