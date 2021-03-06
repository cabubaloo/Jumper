/// needs a generic print statement that prints anything passed into it
/// needs a way to check if the player has won or lost
/// other functions that will be called often.
using System;
namespace Jumper
{
    class TS
    {
        public void printGuessLine(List<string> word) //Prints the list of characters passed, if the string holds {_, _, A, _, L}, should look like this: _ _ A _ L
        {
            Console.WriteLine(word);
            foreach(string characters in word)
            {
                Console.Write("characters");
            }
            Console.WriteLine();
        }

        public void PrintBlanks(List<string> blanklist)
        {
            // Takes a blanklist and prints it to the console. 
            Console.WriteLine();
            foreach(string i in blanklist)
            {
                Console.Write(i + " ");
            }
        }

        public bool CheckIfDone(List<string> word, List<string> blanks, int wrongGuessNumber)
        {
            bool run = false;
            int counter = 0;

            for(int z = 0; z <= 4; z++)
            {
                if(word[z] == blanks[z])
                {
                    counter = counter + 1;
                }
            }

            if(counter == 5)
            {
                run = true;
            }

            if(run)
            {
                Console.WriteLine("Congrats! You didn't die!");
                return false;
            }
            else if(wrongGuessNumber == 4)
            {
                Console.WriteLine("Ya dead son!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public string UserGuess()
        {
            Console.Write("Guess a letter: ");
            string userGuess = Console.ReadLine();
            return userGuess;
        }

        public int turns(int total)
        {
            total += 1;
            return total;
        }
    }
}

       
