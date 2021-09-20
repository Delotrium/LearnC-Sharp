using System;

namespace LearnCS
{
    class arrays
    {
        static void Main(string[] args)
        {
            Array();
            Console.Read();
        }
        static void Array()
        {
            int[] inputarray = { 2, 4, 6, 8, 10, 9 }; //Initiate an array
            int i = 0;
            int total = 0;
            while (i < inputarray.Length) // while(condition), while i is less than the length of the array
            {
                total += inputarray[i]; //add the i^th element of the array to total
                Console.WriteLine(total + "\t+"+total+"+"+inputarray[i]+"="); //output current progress
                i++; //increase i by one
            }
        }
    }
}
