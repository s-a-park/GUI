using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            panelLoginJoin.Visible = false;
            panelTimer.Visible = true;
            
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("게임을 시작합니다.");
            this.Visible = false;
            SingleForm singleForm = new SingleForm();
            singleForm.Show();
        }
        private void buttonNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("게임을 시작합니다.");
            this.Visible = false;
            SingleForm2 singleForm2 = new SingleForm2();
            singleForm2.Show();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm showMainForm = new MainForm();
            showMainForm.ShowDialog();
        }

        private void buttonMulti_Click_1(object sender, EventArgs e)
        {
            panelTimer.Visible = true;
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm showLoginForm = new LoginForm();
            showLoginForm.ShowDialog();
        }

        private void buttonJoin_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            JoinForm showJoinForm = new JoinForm();
            showJoinForm.ShowDialog();
        }

        private void buttonBack2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm showMainForm = new MainForm();
            showMainForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
