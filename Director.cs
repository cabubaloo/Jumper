using System;
namespace Jumper
{
    class Director
    {
        Word word = new Word();
        public void startGame()
        {
            string randomWord = word.WordGen();
            Console.WriteLine(randomWord);
        }
    }
}