using System;
namespace Jumper
{
    class Word
    {
        private readonly Random _random = new Random();
        public string WordGen() //gives a random 5 letter word (no double letters!)
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

        public List<string> UpdateBlank(List<string> updateThisList, int indexToChange, string changeIndexToThis) //changes the lists underscores into the desired letter
        {
            updateThisList[indexToChange] = changeIndexToThis;
            return updateThisList;
        }

        public List<string> SplitString(string word)
        {
            List<string> wordlist = new List<string>(){};
            for(int i = 0; i < word.Length; i++)
            {
                wordlist.Add(word.Substring(i, i + 1));
            }
            return wordlist;
        }

    }
}