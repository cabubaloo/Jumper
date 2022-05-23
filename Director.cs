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
            word.UserGuess();
        }
        private void DoOutputs()
        {
            int misses = 0;
            List<string> blanklist = word.BlankGen();

            ts.PrintBlanks(blanklist);
            parachute.PrintParachute(misses);
        }
        private void DoUpdates()
        {
            //UpdateBlanks();
            //UpdateParachute();
            //CheckIfDone();
        }
    }
}