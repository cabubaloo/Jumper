using System;
namespace Jumper
{
    class Parachute
    {
        public void PrintParachute(int misses) //prints the parachuter based on the amount of misses
        {
            string[] paraList = {"  ___", " /___\\  ", " \\   /", "  \\ /","   O","  /|\\","  / \\"};
            string x = "X";
            foreach(string i in paraList)
            {
                Console.WriteLine(i);
            }

            //THIS FUNCTION IS INCOMPLETE, IT CURRENTLY ONLY PRINTS THE PARACHUTER WITHOUT CHANGES
        }
    }
}