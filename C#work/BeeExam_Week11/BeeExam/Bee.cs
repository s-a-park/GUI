using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeExam
{
    class Bee
    {
        protected bool Life;

        public static Random rnd = new Random();
        public virtual int HoneyConsumption() { return 0; } //일벌과 여왕벌의 꿀 소비량이 다름
    }
}
