using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRPSLS
{
    class Computer : Player //  (Is a type of)
    {
        public override void ChooseGesture()  
        {
            List<string> gestureList = new List<string>();
            gestureList.Add("rock");
            gestureList.Add("paper");
            gestureList.Add("scissors");
            gestureList.Add("lizard");
            gestureList.Add("spock");

            Random rnd = new Random();
            int randomChoice = rnd.Next(gestureList.Count);

            switch(randomChoice)
            {
                case 1:
                    {
                        gesture = gestureList[0]; //rock
                        break;
                    }
                case 2:
                    {
                        gesture = gestureList[1]; //paper
                        break;
                    }
                case 3:
                    {
                        gesture = gestureList[2]; //scissors
                        break;
                    }
                case 4:
                    {
                        gesture = gestureList[3]; //lizard
                        break;
                    }
                case 5:
                    {
                        gesture = gestureList[4]; //spock
                        break;
                    }

            }

        }
    }
}
