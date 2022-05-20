using System;
namespace Jumper
{
    class Director
    {
        Word word = new Word();
        Parachute parachute = new Parachute();
        public void startGame()
        {
            //Generates the users random word
            string randomWord = word.WordGen();

            int num = 0;
            parachute.PrintParachute(num);
        }
    }
}