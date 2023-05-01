using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class BusinessMan : Human
    {

        public int money = 400;
        Random rnd = new Random();

        public override void Home()
        {
            Save_Money(money);
        }

        public void Earn_Money()
        {
            money += 400;
        }

        public void Cost_Money()
        {
            money -= rnd.Next(200,300);
        }
    }

}
