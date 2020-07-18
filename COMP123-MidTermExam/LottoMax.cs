using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_MidTermExam
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
            
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            PickElements();
        }

        public void Print()
        {
            string [] finalNumbers = ToString().Split(' ');
            Console.Write("Ticket 1: ");
            for (int i = 0; i < 7; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Ticket 2: ");
            for (int i = 7; i < 14; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Ticket 3: ");
            for (int i = 14; i < 21; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Ticket 4: ");
            for (int i = 21; i < 28; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Ticket 5: ");
            for (int i = 28; i < 35; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Ticket 6: ");
            for (int i = 35; i < 42; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Ticket 7: ");
            for (int i = 42; i < 49; i++)
            {
                if (finalNumbers[i] == String.Empty)
                {
                    Console.Write($"00" + " ");
                }
                else
                {
                    Console.Write($"{finalNumbers[i],2}" + " ");
                }
            }
        }
    }
}