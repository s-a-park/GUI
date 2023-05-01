using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeExam
{
    class TheHive:Bee
    {
        public int Enemy;
        public int Honey;

        public TheHive()
        {
            Enemy = 0;
            Honey = 30;
        }
        private void MakeEnemy(int killenemy)
        {
            Enemy= Enemy+rnd.Next(1, 2)- killenemy;
        }
        private void HoneyCalc(int consume, int collect)
        {
            Honey = Honey - consume + collect;
        }
        public void HiveUpdate(int consume, int collect, int killenemy)
        {
            MakeEnemy(killenemy);
            HoneyCalc(consume, collect);
        }
    }
}
