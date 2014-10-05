﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        //Deklarerar fält
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;  


        public void Initialize()
        {
            //Ger _count ett startvärde
            _count = 0;
            //Tar fram det hemliga talet
            Random random = new Random();
            _number = random.Next(1, 101);
        }

        public bool MakeGuess(int number)
        {
            //Håller ordning på antalet gissningar som gjorts
            _count++;

            //Undersöker om gissningen är rätt
            if (_number == number)
            {
                Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} försök", _count);
                return true;
            }
            //Undersöker om det hemliga talet är högre än gissningen
            else if (_number > number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                return false;
            }
            //Om det hemliga talet är lägre än gissningen
            else
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                return false;
            }
            if (number > 100 || number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

        public SecretNumber()
        {
            Initialize();
        }
    }
}
