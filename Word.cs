using System;
namespace Jumper
{
    class Word
    {
        private readonly Random _random = new Random();
        public string WordGen()//gives a random 5 letter word (no double letters!)
        {
            List<string> wordList = new List<string>(){"mouse", "crash", "paint", "drive", "break", "slide", "death"};
            int count = 0;

            foreach(string forString in wordList)
            {
                count += 1;
            }
            int randomInt =  _random.Next(0,count - 1);
            string word = wordList[randomInt];

            return word;
        }

        public List<string> BlankGen() //generates a blank list (5 blanks)
        {
            List<string> blankList = new List<string>(){"_", "_", "_", "_", "_"};
            return blankList;
        }

        public string UserGuess()
        {
            Console.Write("Guess a letter [a-z]: ");
            String returnString = Console.ReadLine();
            return returnString;
        }

        public List<string> UpdateBlanks(List<string> word, List<string> blanks, string userGuess) //changes the lists underscores into the desired letter
        {
            for (int i = 0; i >= 5; i++)
            {
                if (word[i] == userGuess)
                {
                    blanks[i] = word[i];
                }
            }
            return blanks;
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