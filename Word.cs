using System;
namespace Jumper
{
    class Word
    {
        private readonly Random _random = new Random();
        public string WordGen() //gives a random 5 letter word
        {
            List<string> wordList = new List<string>();
            wordList = {"mouse", "crash", "paint", "drive", "break", "slide", "death"};
            int count = 0;

            foreach(string forString in wordList)
            {
                count += 1;
            }
            int randomInt =  _random.Next(0,count - 1);
            string word = wordList[randomInt];

            return word;
        }

        public string WordUpdate(word, guessedLetter, previousGuesses) //updates the state of the chosen word
        {
            if(CorrectGuess(word, guessedLetter, previousGuesses) == true)
            {
                //replace associated blank space
            }
            else
            {

            }
        }
        public List<string> BlankGen() //generates a blank list of 5 _
        {
            List<string> blankList = new List<string>(){"_", "_", "_", "_", "_"};
            return blankList;
        }

        public string LetterGuess() //asks the user for input
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            String returnString = Console.ReadLine();
            return returnString;
            //POSSIBLE ERROR: user may give an int instead of a string
        }

        public List<string> updateBlank(List<string> updateThisList, int indexToChange, string changeIndexToThis) //changes the lists underscores into the desired letter
        {
            updateThisList[indexToChange] = changeIndexToThis;
            return updateThisList;
        }

    }
}