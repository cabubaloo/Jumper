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
<<<<<<< HEAD
        {   
            int turns = 0;
=======
        {
            guessWord = word.SplitString(word.WordGen());
            userGuessList = word.BlankGen();
            DoOutputs();

<<<<<<< HEAD
>>>>>>> a473dc6393d35a294c68b0a0d61312960c7a28c5
            while (keepPlaying == true)
=======
            while (keepPlaying == true) //will stay true until CheckIfDone() sets this to false
>>>>>>> 97f4eea15b33d9c3c3e46bbe800ac5fc4d51e4c8
            {    
                GetInputs();
<<<<<<< HEAD
                ts.turns(turns);
=======
                DoUpdates();
>>>>>>> 97f4eea15b33d9c3c3e46bbe800ac5fc4d51e4c8
                DoOutputs();
            }
        }


        private void GetInputs()
        {
<<<<<<< HEAD
<<<<<<< HEAD

            ts.UserGuess();
=======
            string userGuess = ts.UserGuess();
            return userGuess;
>>>>>>> a473dc6393d35a294c68b0a0d61312960c7a28c5
=======
            foreach(string i in guessWord)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            userGuess = ts.UserGuess();
>>>>>>> 97f4eea15b33d9c3c3e46bbe800ac5fc4d51e4c8
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