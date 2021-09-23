using System;

namespace LearnCS
{
    class Methods
    {
        static void Main(string[] args)
        {
            Print("Hi"); //Using the "Print" method we made, with parameter  "Hi"
            Print((AddTwoNumbers(1,3).ToString())); //Print The result of "AddTwoNumbers", note ToString method converts int type to string type, using the methods we made
        }
        /* Template of methods:
        static <return type> <Name>(<parameters>)
        {
            Code;
            return x;
        }
        */
        static void Print(string phrase) //Create neew method "Print" with one string parameter
        {
            Console.WriteLine(phrase); //Print the parameter
            Console.ReadLine(); //Wait for user input
        }
        static uint AddTwoNumbers(uint numberA, uint numberB) //Make new method taking two unsigned integers
        {
            uint result = numberA + numberB; //Add the two numbers
            return result; //Return the result to where the it was called
        }
    }
}
