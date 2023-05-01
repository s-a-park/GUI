using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    abstract class Human
    {
        
        public double Save_Money(int a) {
            double s = a * 1.2;
            return s;
        }

        public abstract void Home(); 
           


      
       
    }
}
