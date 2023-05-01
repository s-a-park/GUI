using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        public int Allscore ;
        public string GameAnswer = null;
        public int TimeCount = 120;
        public string Result = null;
        public int PlayerGoal = 100;
        public int Thisnum = 0;
        public int imagenum = 0;

        public static Random random = new Random();


        public void ImageChange()
        {

            imagenum = random.Next(0, 21);
          
        }

        public void TimeOut()
        {
            TimeCount = 0;
        }

        public void ImageAnswer()
        {
            if (imagenum == 0)
            {
                GameAnswer = "가라오케";
            }
            else if (imagenum==1)
            {
                GameAnswer = "가로수";
            }
            else if (imagenum==2)
            {
               GameAnswer = "가이드북";
            }
            else if (imagenum==3)
            {
                GameAnswer = "공중전화";
            }
            else if (imagenum==4)
            {
                GameAnswer = "도시";
            }
            else if (imagenum==5)
            {
               GameAnswer = "백수";
            }
            else if (imagenum==6)
            {
                GameAnswer = "블럭체인";
            }
            else if (imagenum==7)
            {
                GameAnswer = "샴푸";
            }
            else if (imagenum==8)
            {
                GameAnswer = "소방관";
            }
            else if (imagenum==9)
            {
                GameAnswer = "연장전";
            }
            else if (imagenum==10)
            {
                GameAnswer = "오동나무";
            }
            else if (imagenum==11)
            {
                GameAnswer = "일간신문";
            }
            else if (imagenum==12)
            {
                GameAnswer = "진혼곡";
            }
            else if (imagenum==13)
            {
               GameAnswer = "초등학교";
            }
            else if (imagenum==14)
            {
                GameAnswer = "카카오나무";
            }
            else if (imagenum==15)
            {
                GameAnswer = "파워킹";
            }
            else if (imagenum==16)
            {
                GameAnswer = "포크레인";
            }
            else if (imagenum == 17)
            {
                GameAnswer = "양팔";
            }
            else if (imagenum == 18)
            {
                GameAnswer = "잎새";
            }
            else if (imagenum == 19)
            {
                GameAnswer = "자녀";
            }
            else if (imagenum == 20)
            {
                GameAnswer = "제철소";
            }
            else if (imagenum == 21)
            {
                GameAnswer = "춤사위";
            }
        }
    }
}
