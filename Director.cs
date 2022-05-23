using System;
namespace Jumper
{
    class Director
    {
        Word word = new Word();
        Parachute parachute = new Parachute();
        TS ts = new TS();
        public void startGame()
        {
            //Generates the users random word
            string randomWord = word.WordGen();
            GetInputs();
            DoOutputs();
            DoUpdates();
        }

        private void GetInputs()
        {
            UserGuess();
        }
        private void DoOutputs()
        {
            PrintBlanks();
            PrintParachute();

        }
        private void DoUpdates()
        {
            UpdateBlanks();
            UpdateParachute();
            CheckIfDone();
        }
    }
}