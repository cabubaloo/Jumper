using System;
namespace Jumper
{
    class Director
    {

        private Word word = new Word();
        private Parachute parachute = new Parachute();
        private TS ts = new TS();



        private bool keepPlaying = true;
        int misses = 0;
        int turns = 0;
        string userGuess = "<3";
        List<string> guessWord = new List<string>(){};
        List<string> userGuessList = new List<string>(){};
        List<string> oldUserGuessList = new List<string>(){"_", "_", "_", "_", "_"};
        

        public void startGame()
        {
            guessWord = word.SplitString(word.WordGen());
            userGuessList = word.BlankGen();
            DoOutputs();

            while (keepPlaying == true) //will stay true until CheckIfDone() sets this to false
            {    
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }


        private void GetInputs()
        {
            foreach(string i in guessWord)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            userGuess = ts.UserGuess();
        }

        private void DoUpdates()
        {
            // oldUserGuessList = userGuessList;

            userGuessList = word.UpdateBlanks(guessWord, userGuessList, userGuess);
            //oldUserGuessList is being set to equal userGuessList again for some reason.
            //this leads to misses always being zero.

            misses = misses + word.updateMiss(oldUserGuessList, userGuessList);

            keepPlaying = ts.CheckIfDone(guessWord, userGuessList, misses);

            for(int i = 0; i <= userGuessList.Count - 1 ; i++)
            {
                oldUserGuessList[i] = userGuessList[i];
            }
        }

        private void DoOutputs()
        {
            ts.PrintBlanks(userGuessList);
            parachute.PrintParachute(misses);
        }


    }
}