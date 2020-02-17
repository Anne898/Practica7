using System;

namespace Prcatica7
{
    class Program
    {
        static void Main(string[] args)
        {
          
        bool isFizzOrBuzz = false;
        string fizzBuzzMessage = "";

            for (int i = 1; i <= 100; i++) {
                isFizzOrBuzz = false;
                fizzBuzzMessage = "";

                if (i % 3 == 0) {
                    fizzBuzzMessage += "Fizz";  // Console.Write("Fizz");
                    isFizzOrBuzz = true;
                }
                if (i % 5 == 0) {
                    fizzBuzzMessage += "Buzz";  // Console.Write("Buzz");
                    isFizzOrBuzz = true;
                }

                Console.Write(isFizzOrBuzz ? fizzBuzzMessage : i.ToString());
                Console.WriteLine("");
            }
        }
    }
}