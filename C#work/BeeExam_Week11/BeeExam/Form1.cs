using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeExam
{
    public partial class Form1 : Form
    {
        TheHive hive;
        PatrolBee pb;
        NectarCollector nc;
        Queen queen;
        INectarCollector inc;

        public Form1()
        {
            InitializeComponent();
            hive = new TheHive();
            pb = new PatrolBee();
            inc = pb;

            nc = new NectarCollector();
            queen = new Queen();

            label_Honey.Text = hive.Honey+" ";
            label_Enemy.Text = hive.Enemy + " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int honey=0;
            int enemy=0;
            int consume=0;

            if (hive.Honey>20)
            {
                queen.MakeOrder(nc);
            }
            else
            {
                queen.MakeOrder(inc,nc);
            }

            if(hive.Enemy>10)
            {
                queen.MakeOrder(pb);
            }

            label_QueenEnemy.Text = queen.BeatedEnemyReport+" ";
            label_QueenHoney.Text = queen.CollectedHoneyInfo + " ";

            honey = queen.CollectedHoneyInfo;
            enemy = queen.BeatedEnemyReport;
            consume = queen.HoneyConsumption()+nc.HoneyConsumption()+pb.HoneyConsumption();
            queen.ReportReset();

            hive.HiveUpdate(consume, honey, enemy);

            label_Honey.Text = hive.Honey + " ";
            label_Enemy.Text = hive.Enemy + " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
