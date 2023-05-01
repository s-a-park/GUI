using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class UniverStudent:Human,IPocketMoney
    {

       public int money = 100;

        Random rnd = new Random();
        public override void Home()//적금돈
        {
            Save_Money(money);
        }

        public void getAllowance()
        {
            money = money + rnd.Next(20,50);
        }

        public void costAllowance()
        {
            money = money - rnd.Next(10,100);
        }
    }
}
