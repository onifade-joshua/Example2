using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            var TotalNumber = 100;
            var GuessMyNumber = Convert.ToInt16(Console.ReadLine());
           ;
           
            if(GuessMyNumber == 0)
            {
                Console.WriteLine("You guessed zero, which is not allowed.");
            }
            else
            {
                //var ActualGuess = TotalNumber - GuessMyNumber;
                if(GuessMyNumber <= TotalNumber)
                {
                    Console.WriteLine("Yo! your number is lesser...");
                }
                else
                {
                    Console.WriteLine("Hey!, your number is higher!!!");
                }
                
            }
            Console.WriteLine("Pls press a key to continue...");
            Console.ReadKey();
          
        }
    }
}
