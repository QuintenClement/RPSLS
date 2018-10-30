using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRPSLS
{
    class Human : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("Player, please enter the gesture you would like to use.(rock, paper, scissors, lizard, or spock)");
            string userChoice = Console.ReadLine();
            gesture = userChoice.ToLower();
        }
    }
}
