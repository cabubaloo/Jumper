using System;
namespace Jumper
{
    class Word
    {
        private readonly Random _random = new Random();
        public string WordGen()//gives a random 5 letter word (no double letters!)
        {
            List<string> wordList = new List<string>(){
"eeeee",
"mouse", 
"crash", 
"paint", 
"drive", 
"break", 
"slide", 
"death", 
"which",
"there",
"their",
"about",
"would",
"these",
"other",
"words",
"could",
"write",
"first",
"water",
"after",
"where",
"right",
"think",
"three",
"years",
"place",
"sound",
"great",
"again",
"still"};
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

        public List<string> UpdateBlanks(List<string> word, List<string> blanks, string userGuess) //changes the lists underscores into the desired letter
        {
            for (int i = 0; i <= 4; i++)
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
                wordlist.Add(word[i].ToString());
            }
            return wordlist;
        }

        public int updateMiss(List<string> oldWord, List<string> newWord)
        {
            int missUpdate = 0;

            bool run = false;
            int counter = 0;

            for(int z = 0; z <= 4; z++)
            {
                if(oldWord[z] == newWord[z])
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
                missUpdate = 1;
            }

            return missUpdate;
        }
    }
}