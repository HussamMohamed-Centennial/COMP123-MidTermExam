using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     */
    public class Program
    {
        // Instantiate lotto649 object
        static Lotto649 lotto649 = new Lotto649();
        // Instantiate lottoMax object
        static LottoMax lottoMax = new LottoMax();

        /**
         * @static
         * @method Main
         * @returns {void}
         */
        public static void Main(string[] args)
        {     
            // Call the Menu
            LottoMenu();
        }

        /**
         * <summary>
         * This utility method creates a console menu that allows the user to choose
         * a Lotto game to execute.
         * </summary>
         * 
         * @static
         * @method LottoMenu
         * @returns {void}
         */
        public static void LottoMenu()
        {
            // declare a variable to record if menu is active
            bool menuActive = true;

            // While the menu is active...loop
            while(menuActive)
            {
                // show options in the console menu
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine(" Please make your selection");
                Console.WriteLine(" 1. Lotto 6/49");
                Console.WriteLine(" 2. Lotto Max");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key - Select Lotto 6 / 49
                        Console.Clear();
                        Console.WriteLine("+ Lotto 6/49 +++++++++++++++++++");
                        lotto649.GenerateLottoNumbers();
                        lotto649.print();
                        //string outPut = lotto649.ToString();
                        //string[] finalNumbers = lotto649.ToString().Split(' ');
                        //Console.Write("Ticket 1: ");
                        //for (int i = 0; i < 7; i++)
                        //{
                        //    if (finalNumbers[i] == String.Empty)
                        //    {
                        //        Console.Write($"00" + " ");
                        //    }
                        //    else
                        //    {
                        //        Console.Write($"{finalNumbers[i],2}" + " ");
                        //    }
                        //}
                        //Console.WriteLine();
                        //Console.Write("Ticket 2: ");
                        //for (int i = 7; i < 14; i++)
                        //{
                        //    if (finalNumbers[i] == String.Empty)
                        //    {
                        //        Console.Write($"00" + " ");
                        //    }
                        //    else
                        //    {
                        //        Console.Write($"{finalNumbers[i],2}" + " ");
                        //    }
                        //}
                        //Console.WriteLine();
                        //Console.Write("Ticket 3: ");
                        //for (int i = 14; i < 21; i++)
                        //{
                        //    if (finalNumbers[i] == String.Empty)
                        //    {
                        //        Console.Write($"00" + " ");
                        //    }
                        //    else
                        //    {
                        //        Console.Write($"{finalNumbers[i],2}" + " ");
                        //    }
                        //}
                        //Console.WriteLine();
                        //Console.Write("Ticket 4: ");
                        //for (int i = 21; i < 28; i++)
                        //{
                        //    if (finalNumbers[i] == String.Empty)
                        //    {
                        //        Console.Write($"00" + " ");
                        //    }
                        //    else
                        //    {
                        //        Console.Write($"{finalNumbers[i],2}" + " ");
                        //    }
                        //}
                        //Console.WriteLine();
                        //Console.Write("Ticket 5: ");
                        //for (int i = 28; i < 35; i++)
                        //{
                        //    if (finalNumbers[i] == String.Empty)
                        //    {
                        //        Console.Write($"00" + " ");
                        //    }
                        //    else
                        //    {
                        //        Console.Write($"{finalNumbers[i],2}" + " ");
                        //    }
                        //}
                        //Console.WriteLine();
                        //Console.Write("Ticket 6: ");
                        //for (int i = 35; i < 42; i++)
                        //{
                        //    if (finalNumbers[i] == String.Empty)
                        //    {
                        //        Console.Write($"00" + " ");
                        //    }
                        //    else
                        //    {
                        //        Console.Write($"{finalNumbers[i],2}" + " ");
                        //    }
                        //}
                        //Console.WriteLine();

                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key - Select Lotto Max
                        Console.Clear();
                        Console.WriteLine("+ Lotto MAX ++++++++++++++++++++");
                        lottoMax.GenerateLottoNumbers();
                        lottoMax.Print();
                        Console.WriteLine();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3: // The "3" Key - Exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }         
        }
    }
}
