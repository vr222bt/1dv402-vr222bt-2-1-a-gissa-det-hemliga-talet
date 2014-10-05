using System;
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
        public const int MaxValue = 100;
        public const int MinValue = 1;
        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
            //Ger _count ett startvärde
            _count = 0;

            //Tar fram det hemliga talet
            Random random = new Random();
            _number = random.Next(MinValue, MaxValue + 1);
        }

        public bool MakeGuess(int number)
        {

            //Undersöker så det inmatade värdet inte är utanför räckviden för det hemliga talet
            if (number > MaxValue || number < MinValue)
            {              
                throw new ArgumentOutOfRangeException();
            }

            //Undersöker så det inte sker för många gissningar
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }
            
            //Håller ordning på antalet gissningar som gjorts
            _count++;

            //Undersöker om gissningen är rätt
            if (_number == number)
            {
                Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} försök", _count);
                return true;
            }

            //Undersöker om det hemliga talet är högre än gissningen
            if (_number > number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                
            }

            //Om det hemliga talet är lägre än gissningen
            else
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
   
            }
            if (_count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Det hemliga talet är {0}", _number);
            }
            return false;
        }
           
        
    
    }
}
