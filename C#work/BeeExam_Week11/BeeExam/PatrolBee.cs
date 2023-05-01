using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeExam
{
    class PatrolBee: Worker,INectarCollector
    {
        public override string DoYourJob()
        {
            return "순찰중이에요";
        }

        public int BeatEnemy()
        {
            return rnd.Next(3,5);
        }

        public int CollectHoney()
        {
            return rnd.Next(2, 5);
        }
    }
}
