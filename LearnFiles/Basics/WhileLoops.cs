using System;

namespace LearnCS
{
    class WhileStatment
    {
         static void Main(string[] args)
        {
            WhileStatement();
        }
        static void WhileStatement()
        {
            Random rd = new Random();

            int computer = rd.Next(1, 10); //Create a random number between 1 and 10
            Console.WriteLine("Guess My Number!");
            int i = 0;
            while (i < 3) //While (condition), while I less than 3
            {
                string msg = Console.ReadLine(); //Get user input for guess
                int intmsg = int.Parse(msg); //Convert to int
                if (intmsg == computer)
                {
                    Console.WriteLine("You are correct!");
                    Console.ReadLine();
                    break;                //Break of loop
                }
                else if (i < 2)
                {
                    Console.WriteLine("That is incorrect! You have " + (2 - i) + " turns left.");
                }
                else if (i==2)
                {
                    Console.WriteLine("You lost! My number was " + computer);
                    Console.ReadLine();
                    break;
                }
                i++; //Increment i by one everytime it loops
            }
        }
    }
}
