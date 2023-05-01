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
    public partial class Form4 : Form
    {
        UniverStudent uv = new UniverStudent();
        BusinessMan bs = new BusinessMan();
        Grandma gr = new Grandma();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uv.costAllowance();
            uv.getAllowance();
            uv.Home();
            lb_St.Text = Convert.ToString(uv.money);

            gr.getAllowance();
            gr.getAllowance();
            gr.Home();
            lb_GranMa.Text = Convert.ToString(gr.money);

            bs.Cost_Money();
            bs.Earn_Money();
            bs.Home();
            lb_BM.Text = Convert.ToString(bs.money); 


            if (uv.money < 0)
            {
                lb_St.Text = "탕진!";
            }else if (bs.money < 0)
            {
                lb_BM.Text = "탕진!";
            }else if (gr.money < 0)
            {
                lb_GranMa.Text = "탕진!";
            }
        }
    }
}
