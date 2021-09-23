using System;

namespace LearnCS
{
    class Strings
    {
        static void  Main(string[] args)
        {
            String();
            Console.ReadLine();
        }
        static void String()
        {
            string phrase = "Brown jars prevented the mixture from freezing too quickly."; //Set out original phrase
            int phrase_length = phrase.Length; //the .Length function gets a integer value of the length of the string
            string UpperPhrase = phrase.ToUpper(); //ToUpper() makes ALL characters go to their upper counterpart
            string LowerPhrase = phrase.ToLower(); //Opposite to above
           
            bool ContainsBrown = phrase.Contains("Brown"); //Checks if the phrase contains "Brown"
            bool ContainsLowerBrown = phrase.Contains("brown"); //Same as above, HOWEVER, the .Contains function IS CASE SENSETIVE
            bool Contains_Brown = phrase.ToUpper().Contains("BROWN"); //Not case sensetive variant, OOP allows multiple functions on one variable

            char FirstLetter = phrase[0]; //First character in phrase
            char LastLetter = phrase[(phrase_length - 2)]; //Last character in phrase (-2 because of fullstop)

            int index = phrase.IndexOf("jars"); //Gets the index of "jars", the position the first char is in
            string substring = phrase.Substring(index); //Returns the rest of the phrase after the index
            string second_word = phrase.Substring(6,7); //Returns substrings

            Console.WriteLine("The Phrase is: " + phrase);
            Console.WriteLine("The length of the phrase is " + phrase_length + " Characters long");
            Console.WriteLine("The phrase in uppercase is: " + UpperPhrase);
            Console.WriteLine("The lowecase of the phrase is: " + LowerPhrase);
            Console.WriteLine("Does the phrase contain \"Brown\"?: " + ContainsBrown);
            Console.WriteLine("Does the phrase contain \"brown\"?: " + ContainsLowerBrown);
            Console.WriteLine("Does the phrase contain \"brown\"? (Not Case Sensetive): " + Contains_Brown);
            Console.WriteLine("The first letter is: " + FirstLetter);
            Console.WriteLine("The last letter is: " + LastLetter);
            Console.WriteLine("The index of \"jars\" is: " + index);
            Console.WriteLine("The Substring of \"jars\" is: " + substring);
            Console.WriteLine("The Substring of string 6-7 is: " + second_word);
         }
    }
}
