using System;

namespace LearnCS
{ 
    class ClassIfStatements
    {
        static void Main(string[] args)
        {
            PrintResult();
        }
        static bool IsEven(uint number) //Check if the input number is even
        {
            if (number % 2 == 0) //if statement follows, if (condition), in this case, if (the input number divided by two gives no remainder (modulus))
            {
                return true; //Return true if this case is true
            }
            else //If the remainder is not 0 return false
            {
                return false;
            }
            
        }
        static void PrintResult()
        {
            Console.WriteLine("Give me a number:"); //Ask for user input
            string input = Console.ReadLine(); //Get input
            uint IntInput = uint.Parse(input); //Convert string to uint
            if (IsEven(IntInput) == true) //if (input number is even)
            {
                Console.WriteLine(input + " is even!");
                Console.ReadLine();
            }
            else //else return number is odd
            {
                Console.WriteLine(input + " is odd!");
                Console.ReadLine();
            }
        }
     }
}
