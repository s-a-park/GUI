using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class Form2 : Form
    {
        Point p;

        int x ;
        int y ;

        int i = 0;
        public Form2()
        { InitializeComponent();
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            int r = i % 10;
            if (r < 5)
            {
                x = x + 10;
                p = new Point(x,y);
                pictureBox1.Location = p;
            }
            else
            {
                x = x - 10;
                p = new Point(x,y);
                pictureBox1.Location = p;
            }

        }
    }
}
