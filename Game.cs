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
            Console.WriteLine("Hello! And welcome to the first ever RPSLS Championship!");
            Console.WriteLine("My my, you look like one hell of a challenger. Do you have what it takes to become the next Champion?");
            Console.WriteLine("The rules are simple: scissors cuts paper, paper covers rock, rock crushers lizard, lizard poisens spock, spock smashes scissors, scissors decapitates lizard,);" +
                "lizard eats paper, paper disproves spock, spock vaporizes rock, and as it always has rock crushes scissors");
            Console.WriteLine("Got it?");
            Console.WriteLine("Good!");
            // ask what type of game
            SelectGameType();
            // choose gestures
            Console.ReadLine();

            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
        }

        public void SelectGameType()
        {
            Console.WriteLine("Would you like to play against another person or against a computer? (person or computer)");
            string Gametype = Console.ReadLine().ToLower();
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

        public void WhoWins()
        {
            if (playerOne.gesture == "rock" && playerTwo.gesture == "paper" || playerTwo.gesture == "spock")
            {
                playerTwo.score++;
                Console.WriteLine("Player 2 won! Better luck next time Player 1");
            }

            else if (playerOne.gesture == "paper" && playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
            {
                playerTwo.score++;
                Console.WriteLine("Player 2 won! Better luck next time Player 1");
            }

            else if (playerOne.gesture == "scissors" && playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
            {
                playerTwo.score++;
                Console.WriteLine("Player 2 won! Better luck next time Player 1");
            }

            else if (playerOne.gesture == "lizard" && playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
            {
                playerTwo.score++;
                Console.WriteLine("Player 2 won! Better luck next time Player 1");
            }

            else if (playerOne.gesture == "spock" && playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
            {
                playerTwo.score++;
                Console.WriteLine("Player 2 won! Better luck next time Player 1");
            }

            else if (playerOne.gesture == "spock" && playerTwo.gesture == "rock" || playerTwo.gesture == "scissors")
            {
                playerOne.score++;
                Console.WriteLine("Player 1 won! Better luck next time Player 2");
            }
            else if (playerOne.gesture == "lizard" && playerTwo.gesture == "paper" || playerTwo.gesture == "spock")
            {
                playerOne.score++;
                Console.WriteLine("Player 1 won! Better luck next time Player 2");
            }
            else if (playerOne.gesture == "scissors" && playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
            {
                playerOne.score++;
                Console.WriteLine("Player 1 won! Better luck next time Player 2");
            }
            else if (playerOne.gesture == "paper" && playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
            {
                playerOne.score++;
                Console.WriteLine("Player 1 won! Better luck next time Player 2");
            }
            else if (playerOne.gesture == "rock" && playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
            {
                playerOne.score++;
                Console.WriteLine("Player 1 won! Better luck next time Player 2");
            }
        }
    }
}
