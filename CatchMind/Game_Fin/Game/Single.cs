using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Single : Player, Itimer
    {
        public int second = 0;
        public int minute = 1;

        public void Timer()
        {

            second = second - 1;
            if (second == -1)
            {
                minute = minute - 1;
                second = 59;
            }

            
        }

        public void FinishGame()
        {
            Console.Write("시간종료!");
        }
        public int Goal()
        {
            goal = GoalSet();
            return goal;
        }
        public override int GoalSet()
        {
            return random.Next(150, 200);
        }
        
    }
}
