using System;
namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {//I was unable to figure out how to make this program case insensitive.

            //New string created and set to the first sentence from Alice in Wonderland.
            string ally = "Alice was beginning to get very tired of sitting\n" +
                 " by her sister on the bank, and of having nothing to do: once or twice\n" +
                 " she had peeped into the book her sister was reading, but\n it had no pictures" +
                 " or conversations in it, ‘and what is\n the use of a book,’ thought Alice " +
                 "‘without pictures or conversation?’";

            //This will print the line above to the console and the length of the string.
            Console.WriteLine(ally + " \n \nLength: " + ally.Length);

            //Prompts the user to search for a substring.
            //User's substring assigned to new variable called sub.
            Console.WriteLine("Search for a substring: ");
            string sub = Console.ReadLine();

     
    
            //the position of the first occurence of the substring.
            int pos = ally.IndexOf(sub);
            Report(pos, sub);

      
            //the position of the second occurence of the substring. 
            //None of the words appear more than twice.
            pos = ally.LastIndexOf(sub);
            Report(pos, sub);

            Console.ReadLine();

        }
        /// <summary>
        /// This method writes whether the substring was found and where or if it wasn't found at all.
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="sub"></param>
        static void Report(int pos, string sub)
        {
            if (pos != -1)

                Console.WriteLine(sub + " found at " + pos);
            else
                Console.WriteLine(sub + " not Found!"); 
        }
    
    }
}
