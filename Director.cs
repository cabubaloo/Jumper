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
            string userguesss = ts.UserGuess();
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
            string Word = word.WordGen();
            List<string> Blanks = word.BlankGen();
            


            word.UpdateBlanks();

            keepPlaying = CheckIfDone();
            //UpdateBlanks();
            //UpdateParachute();
            //CheckIfDone();
        }
    }
}