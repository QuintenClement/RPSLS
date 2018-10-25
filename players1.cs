using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public partial class Players
    {
        public int score;
        public string gesture;

        public Players(int score, string gesture)
        {
            this.score = score;
            this.gesture = gesture;
        }

        public void PlayerInput()
        {
            Console.WriteLine("Please enter the gesture you would like to use. ex.(Rock, Paper, Scissors, Lizard, Spock");
            Console.ReadLine();
        }

        public void DisplayUserScore()
        {
            Console.WriteLine(score);
        }
    }
}