using System;
namespace Jumper
{
    class Director
    {
        Word word = new Word();
        Parachute parachute = new Parachute();
        TS ts = new TS();
        bool keepPlaying = true;
        
        public void startGame()
        {
            while (keepPlaying == true)
            {    
                //Generates the users random word
                string randomWord = word.WordGen();
                GetInputs();
                DoOutputs();
                DoUpdates();
            }
        }
        private void GetInputs()
        {
            word.UserGuess();
        }
        private void DoOutputs()
        {
            PrintBlanks(List<string> blankList);
            PrintParachute();
            int misses = 0;
            List<string> blanklist = word.BlankGen();

            ts.PrintBlanks(blanklist);
            parachute.PrintParachute(misses);
        }
        private int DoUpdates()
        {
            UpdateBlanks();
            UpdateParachute();
            keepPlaying = CheckIfDone();
            //UpdateBlanks();
            //UpdateParachute();
            //CheckIfDone();
        }
    }
}