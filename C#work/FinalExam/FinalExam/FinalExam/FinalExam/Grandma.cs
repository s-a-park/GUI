using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Grandma:Human,IPocketMoney
    {
        public int money = 400;



        Random rnd = new Random();
        public override  void Home()
        {
            Save_Money(money);
        }

        public void getAllowance()
        {
            money += rnd.Next(40,100);
        }

        public void costAllowance()
        {
            money -= rnd.Next(80,100);
        }
    }
}
