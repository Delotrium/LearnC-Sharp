using System;
namespace LearnCS
{
    public class MainClass //Create a public class, public classes can be accessed outside of the origin namespace
    {
        public static void main(string[] args)
        {
            SecondClass.Print("Hello User");
            //SecondClass.PrivateMethod();       -If were to uncomment this code and error would appear as the method is private and can only be called in the origin class
            //SecondClass.PrintPrivateMethod;    -This would also create an error even though PrintPrivateMethod() is public, the code itself is running private method(s) which cannot be accessed/called
        }
    }
    
    public class SecondClass //Second class
    {
         public static void Print(string phrase) //Make a PUBLIC method that prints the parameters
        {
            Console.WriteLine(phrase);
            Console.ReadLine();
        }
        private static void PrivateMethod() //Make a PRIVATE class, a private method CANNOT be accessed or called from outside its origin class, wheras a public class can
        {
            Print("This is a private method");
        }
        public static void PrintPrivateMethod() //Create a public class which calls a private class
        {
            PrivateMethod();
        }
    }
}
