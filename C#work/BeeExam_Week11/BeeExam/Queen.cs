using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeExam
{
    class Queen:Bee
    {
        public int BeatedEnemyReport;
        public int CollectedHoneyInfo;
        public string ResponseToOrder;

        public override int HoneyConsumption()
        {
            return rnd.Next(5, 10);
        }

        public void MakeOrder(PatrolBee pb)  //오버로드
        {
            BeatedEnemyReport = pb.BeatEnemy();
            ResponseToOrder = pb.DoYourJob();
        }

        public void MakeOrder(NectarCollector nc) //오버로드
        {
            CollectedHoneyInfo = nc.GetHoney();
            ResponseToOrder = nc.DoYourJob();
        }

        public void MakeOrder(INectarCollector inc, NectarCollector nc) //오버로드
        {
            CollectedHoneyInfo = inc.CollectHoney() + nc.GetHoney();
            ResponseToOrder = nc.DoYourJob();
        }

        public void ReportReset()
        {
            BeatedEnemyReport = 0;
            CollectedHoneyInfo = 0;
            ResponseToOrder = null;
        }   
    }
}
