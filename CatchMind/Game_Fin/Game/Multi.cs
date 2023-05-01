using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Multi : Player, Igoal ,Itimer
    {
        public int second = 0;
        public int minute = 2;

        public void Timer()
        {

           second = second - 1;
            if (second==-1)
            {
                minute = minute - 1;
                second = 59;
            }

        

            
        }
        public void FinishGame()
        {
            Console.Write("시간종료!");
        }

        public override int GoalSet()
        {
            return random.Next(180, 200);
        }
        public int Goal()
        {
            goal = 150;
            return goal;
        }
        public int ComScore()
        {
            return random.Next(100, 150);
        }
    }
}
