using System;
namespace Jumper
{
    class Director
    {

        private Word word = new Word();
        private Parachute parachute = new Parachute();
        private TS ts = new TS();
        private bool keepPlaying = true;
        

        public void startGame()
<<<<<<< HEAD
        {   
            int turns = 0;
=======
        {
            int misses = 0;
            int turns = 0;

>>>>>>> a473dc6393d35a294c68b0a0d61312960c7a28c5
            while (keepPlaying == true)
            {    
                //Generates the users random word
                string randomWord = word.WordGen();

                GetInputs();
                ts.turns(turns);
                DoOutputs();
                DoUpdates(turns, misses);
            }
        }
        private string GetInputs()
        {
<<<<<<< HEAD

            ts.UserGuess();
=======
            string userGuess = ts.UserGuess();
            return userGuess;
>>>>>>> a473dc6393d35a294c68b0a0d61312960c7a28c5
        }
        private void DoOutputs()
        {
            
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