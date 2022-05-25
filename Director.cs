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
            ts.UserGuess();
        }
        private void DoOutputs()
        {
            
            int misses = 0;
            parachute.PrintParachute(misses);
            List<string> blanklist = word.BlankGen();

            ts.PrintBlanks(blanklist);
            parachute.PrintParachute(misses);
        }
        private int DoUpdates()
        {
            List<string> word = new List<string>(){word.WordGen()};
            
            List<string> blanks = new List<string>(){word.UpdateBlanks()};

            keepPlaying = ts.CheckIfDone(word, blanks, int turnNumber, int wrongGuessNumber);
            //UpdateBlanks();
            //UpdateParachute();
            //CheckIfDone();
        }
    }
}