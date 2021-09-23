using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("|\\--/|\n"); //Create a Random Shape using the console (note \\ represents "\"
            Console.Write("|-\\/-|\n");
            Console.Write("|-/\\-|\n");
            Console.Write("|/--\\|\n");
            Console.Write("|____|\n");
            HelloWorld(); // Call the Hello World Function
        }
        static void HelloWorld() //Hello World Function
        {
            Console.Write("Hello World\n"); //Write "Hello World" to the console (\n represents new line)
            Console.ReadLine(); //Wait for a user input and then close console
        }
    }
}
