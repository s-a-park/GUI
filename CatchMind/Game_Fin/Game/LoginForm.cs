using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool f_reader(string filepath)
        {

            FileStream filestream = File.Open(filepath, FileMode.Open);

            if (filestream == null)
            {
                MessageBox.Show("파일을 여는데 실패하였습니다.");
                return false;
            }

            BinaryReader reader = new BinaryReader(filestream);

            string id;
            string password;
       
            while (reader != null)
            {
                if (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    id = reader.ReadString();
                    password = reader.ReadString();

                    if (id != textBoxID.Text || password != textBoxPW.Text)
                    {
                        continue;
                    }

                }

                if (reader.BaseStream.Position == reader.BaseStream.Length)
                {
                    MessageBox.Show("로그인에 실패했습니다. 다시 입력해주세요.");
                    filestream.Close();
                    return false;
                }

                break;
            }

            filestream.Close();
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            bool filecheck = f_reader("memberData");

            if (filecheck)
            {
                MessageBox.Show(textBoxID.Text + " 님 환영합니다.");

                panelTimer.Visible = true;    
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiForm multiTimerForm = new MultiForm();
            multiTimerForm.Show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiForm2 multiForm = new MultiForm2();
            multiForm.Show();
        }
    }
}
