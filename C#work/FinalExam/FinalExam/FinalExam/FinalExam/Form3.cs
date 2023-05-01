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
    public partial class Form3 : Form
    {
        Point p;
        int x, y;

        public Form3()
        {
            InitializeComponent();
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case  Keys.Up:
                    y = y - 10;
                    p = new Point(x, y);
                    pictureBox1.Location = p;
                    break;

                case Keys.Down:
                    p = new Point(x, y);
                    pictureBox1.Location = p;
                    y = y + 10;
                    break;
                case Keys.Left:
                    p = new Point(x, y);
                    pictureBox1.Location = p;
                    x = x - 10;
                    break;
                case Keys.Right:
                    p = new Point(x, y);
                    pictureBox1.Location = p;
                    x = x + 10;
                    break;

                                                                                                      }

        }
    }
}
