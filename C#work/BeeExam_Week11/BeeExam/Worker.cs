using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeExam
{
    abstract class Worker:Bee
    {

        public Worker()
        {
            this.Life = true;
        }

        public override int HoneyConsumption()
        {
            return rnd.Next(2, 3);
        }

        public abstract string DoYourJob();
    }
}
