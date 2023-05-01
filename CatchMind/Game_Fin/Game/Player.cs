using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player : Game
    {
        public int PlayerScore;
        public int goal = 100;
        public string PlayerAnswer=null;

        public void EndScore()
        {
            Allscore = Allscore + PlayerScore;
        }

        public void MatchingAnswer()
        {
           
          
                Result = "정답입니다.";
                PlayerScore += 10;
            Allscore += PlayerScore;

        }
        public void MatchingAnswer2()
        {
            Result = "오답입니다.";
        } 
            
               
               
            

     

        public virtual int GoalSet()   //추상메소드
        {
            return 0;
        }
   }
}
