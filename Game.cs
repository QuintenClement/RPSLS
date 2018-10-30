using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRPSLS
{
    class Game
    {
        // member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;

        public Game()
        {
            playerOne = new Human();
        }

        public void StartGame()
        {
            // display instructions
            // ask what type of game
            // choose gestures
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
        }

        public void SelectGameType()
        {
            Console.WriteLine("Would you like to play against another person or against a computer? (person or computer)");
            string Gametype = Console.ReadLine();
            if (Gametype.Equals("person") || Gametype.Equals("Person"))
            {
                Console.WriteLine("You chose to play against another person.");
                playerTwo = new Human();
            }
            else if (Gametype.Equals("computer") || Gametype.Equals("Computer"))
            {
                Console.WriteLine("You chose to play against a computer.");
                playerTwo = new Computer();
            }
            else
            {
                Console.WriteLine("Please enter a valid response.");
                SelectGameType();
            }
        }

    }
}
