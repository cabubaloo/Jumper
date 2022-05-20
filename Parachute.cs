using System;
using System.Collections.Generic;
namespace Jumper
{
    class Parachute
    {
        public void PrintParachute(int misses) //prints the parachuter based on the amount of misses
        {
            List<string> paraList = new List<string>(){"  ___", " /___\\  ", " \\   /", "  \\ /","   O","  /|\\","  / \\"};

            if(misses >= 4)
            {
                for(int i = 0; i < 4; i++)
                {
                    paraList.RemoveAt(0);
                }
                paraList[0] = "   X";
            }
            else
            {
                for(int i = 0; i < misses; i++)
                {
                    paraList.RemoveAt(0);
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