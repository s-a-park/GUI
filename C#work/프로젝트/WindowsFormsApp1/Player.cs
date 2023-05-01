using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Player : Game
    {
        public int PlayerScore=0;
        public string PlayerAnswer="";
       

        public void EndScore()
        {
            Allscore = Allscore + PlayerScore;

        }
       

        public void MatchingAnswer()
        {
            if (GameAnswer == PlayerAnswer)
            {
                Result = "정답";
                PlayerScore = PlayerScore + 10;
            }
            else Result = "오답";
        }

       
    }
}
