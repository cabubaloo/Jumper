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

            parachute.PrintParachute(0);
        }
    }
}