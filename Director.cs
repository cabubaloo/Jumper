using System;
namespace Jumper
{
    class Director
    {
        Word word = new Word();
        Parachute parachute = new Parachute();
        TS ts = new TS();
        bool keepPlaying = true;
        int misses = 0;
        public void startGame()
        {
            while (keepPlaying == true)
            {    
                //Generates the users random word
                string randomWord = word.WordGen();
                DoOutputs();
                GetInputs();
                DoUpdates();
            }
        }
        private void GetInputs()
        {
            ts.UserGuess();
        }
        private void DoOutputs()
        {
            parachute.PrintParachute(misses);
            List<string> blanklist = word.BlankGen();

            ts.PrintBlanks(blanklist);
            parachute.PrintParachute(misses);
        }
        private int DoUpdates()
        {
            List<string> Word = new List<string>(){word.WordGen()};
            
            word.UpdateBlanks();

            keepPlaying = ts.CheckIfDone();
            //UpdateBlanks();
            //UpdateParachute();
            //CheckIfDone();
        }
    }
}