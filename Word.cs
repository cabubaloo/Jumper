using System;
namespace Jumper
{
    class Word
    {
        private readonly Random _random = new Random();
        public string WordGen() //gives a random 5 letter word
        {
            string[] wordList = {"mouse", "crash", "paint", "drive", "break", "slide", "death"};
            int count = 0;

            foreach(string forString in wordList)
            {
                count += 1;
            }
            int randomInt =  _random.Next(0,count - 1);
            string word = wordList[randomInt];

            return word;
        }
    }
}