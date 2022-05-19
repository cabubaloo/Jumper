using System;
namespace Jumper
{
    class Parachute
    {
        public void PrintParachute(int misses) //prints the parachuter based on the amount of misses
        {
            string[] paraList = {"  ___", " /___\\  ", " \\   /", "  \\ /","   O","  /|\\","  / \\"};

            if(misses >= 4)
            {
                for(int i = 0; i < 4; i++)
                {
                    paraList[i] = " ";
                }
                paraList[4] = "   X";
            }
            else
            {
                for(int i = 0; i < misses; i++)
                {
                    paraList[i] = " ";
                }
            }

            foreach(string i in paraList)
            {
                Console.WriteLine(i);
            }

            //THIS FUNCTION IS INCOMPLETE, IT CURRENTLY ONLY PRINTS THE PARACHUTER WITHOUT CHANGES
        }
    }
}