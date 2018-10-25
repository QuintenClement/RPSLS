using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public string Gametype;
        public string Players;
        public string Gestures;
        public string Rules;
       

        public Game(string Players, string Gestures, string Rules, string Gametype)
        {
            this.Players = Players;
            this.Gestures = Gestures;
            this.Rules = Rules;
            this.Gametype = Gametype;
        }

        public string SelectGameType()
        {
            Console.WriteLine("Would you like to play against another person or against a computer? (person or computer)");
            string Gametype = Console.ReadLine();
            if (Gametype.Equals("person"))
            {
                Console.WriteLine("You chose to play against another person. Please have player one enter their gesture now.");
                Players.PlayerInput();
            }
            else if (Gametype.Equals("Person"))
            {
                Console.WriteLine("You chose to play against another person. Please have player one enter their gesture now.");
                Console.ReadLine();
            }
            else if (Gametype.Equals("computer"))
            {
                Console.WriteLine("You chose to play against a computer. Please enter your choice of gesture.");
                Console.ReadLine();
            }
            else if (Gametype.Equals("Computer"))
            {
                Console.WriteLine("You chose to play against a computer. Please enter your choice of gesture.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid response.");
                SelectGameType();
            }
        }
    }
}
