﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lotto649
     */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            PickElements();
        }

        public void print()
        {
            string[] finalNumbers = ToString().Split(' ');
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
        }
    }
}
