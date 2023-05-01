using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeExam
{
    class NectarCollector:Worker
    {
        public override string DoYourJob()
        {
            return "꿀을 따왔어요";
        }

        public int GetHoney()
        {
            return rnd.Next(7, 12);
        }                
    }
}
