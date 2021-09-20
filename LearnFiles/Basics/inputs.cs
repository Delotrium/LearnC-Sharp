using System;
using System.Net; //Import Net/Dns functions
namespace LearnCS
{
    class greeting
    {
        static void Main(string[] args)
        {
            UserGreeting();
        }
        static void UserGreeting()
        {
            string HostName = Dns.GetHostName(); //Get the name of the computer
            Console.WriteLine("Greetings User! What is your name?"); //Print the question we want to ask the user
            string name = Console.ReadLine(); //Take input into "name" variable
            Console.WriteLine("Oh, hello " + name + "! What is your age?"); //Ask second question
            string age = Console.ReadLine(); // Get input as age
            Console.WriteLine("Good day " + name + "! You are " + age + " years old, and your computer name is " + HostName+".");//output final statement with all variables
            Console.ReadLine();
        }
    }

}
