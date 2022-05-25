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
            int misses = 0;
            int turns = 0;

            while (keepPlaying == true)
            {    
                //Generates the users random word
                string randomWord = word.WordGen();

                GetInputs();
                DoOutputs();
                DoUpdates(turns, misses);
            }
        }
        private string GetInputs()
        {
            string userGuess = ts.UserGuess();
            return userGuess;
        }
        private void DoOutputs()
        {
            
            int misses = 0;
            parachute.PrintParachute(misses);
            List<string> blanklist = word.BlankGen();

            ts.PrintBlanks(blanklist);
            parachute.PrintParachute(misses);
        }
        private void DoUpdates(int turnNum, int wrongGuessNumber)
        {
            List<string> word = new List<string>(){word.WordGen()};
            
            List<string> blanks = new List<string>(){word.UpdateBlanks()};

            keepPlaying = ts.CheckIfDone(word, blanks, turnNum, wrongGuessNumber);
            //UpdateBlanks();
            //UpdateParachute();
            //CheckIfDone();
        }
    }
}