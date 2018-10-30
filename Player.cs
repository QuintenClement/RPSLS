using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRPSLS
{
    public abstract class Player
    {
        public int score;
        public string gesture;


        public Player()
        {

        }
        public void DisplayUserScore()
        {
            Console.WriteLine(score);
        }
        public abstract void ChooseGesture();
    }
}
