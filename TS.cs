/// needs a generic print statement that prints anything passed into it
/// needs a way to check if the player has won or lost
/// other functions that will be called often.
using System;
namespace Jumper
{
    class TS
    {
        public void printGuessLine(List<string> word)
        {
            //Prints the list of characters passed, if the string holds {_, _, A, _, L}, should look like this: _ _ A _ L
        }

        public void PrintBlanks(List<string> blanklist)
        {
            // Takes a blanklist and prints it to the console. 

            Console.WriteLine(blanklist);
        }

        public bool CheckIfDone(List<string> word, List<string> blanks, int turnNumber, int wrongGuessNumber)
        {
            if(word == blanks)
            {
                Console.WriteLine("Congrats! You didn't die!");
                return false;
            }
            else if(wrongGuessNumber == turnNumber - 5)
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
            Console.WriteLine("Guess a letter: ");
            string userGuess = Console.ReadLine();
            return userGuess;
        }

    }

       
}