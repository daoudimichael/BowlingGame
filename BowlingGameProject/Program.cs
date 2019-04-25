using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameProject
{
    /// <summary>
    /// main class
    /// -> create a game configuration (optional - if get a valid (4 positive numbers) args from the user than updating game configuration ('EnvProperties'))
    /// -> create Game manager
    /// -> start play
    /// </summary>
    class Program
    {
        #region MyClass definition  
        static void Main(string[] args)
        {
            EnvProperties envProperties;
            if (args.Length == 4)
            {
                bool usingArgs = true;
                foreach (String arg in args)
                {
                    bool isNumber = int.TryParse(arg, out int num);
                    if (!isNumber || num < 0)
                    {
                        Console.WriteLine("Invalid args, using defults.");
                        usingArgs = false;
                    }
                }
                if (usingArgs)
                {
                    envProperties = new EnvProperties(args[0], args[1], args[2], args[3]);
                }
                else
                {
                    envProperties = new EnvProperties();
                }
            }
            else
            {
                envProperties = new EnvProperties();
            }

            GameManager gameManager = new GameManager(envProperties);
            gameManager.StartGame();
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
        }
        #endregion
    }
}
