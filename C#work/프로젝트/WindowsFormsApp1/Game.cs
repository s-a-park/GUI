using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Game
    {
        public int Allscore = 0;
        public string GameAnswer = "";
        public int TimeCount = 120;
        public string Result = "";
        public int PlayerGoal = 100;
        public string PicWord = "";
        public int imagenum = 0;

        public static Random random = new Random();


        public void ImageChange()
        {

           imagenum = random.Next(0, 2);

        }
        public void TimeOut()
        {
            
        }

       

    }
}
