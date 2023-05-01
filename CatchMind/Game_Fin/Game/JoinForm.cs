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
    public partial class JoinForm : Form
    { 

        public JoinForm()
        {
            InitializeComponent();
        }

        private bool f_writer(string filepath)
        {
            FileStream filestream = File.Open(filepath, FileMode.Append);

            if (filestream == null)
            {
                MessageBox.Show("파일을 여는데 실패하였습니다.");
                return false;
            }

            if (textBoxJoinPW.Text.Length < 4)
            {
                MessageBox.Show("비밀번호는 4자리이상이어야 합니다.");
                filestream.Close();
                return false;
            }

            BinaryWriter writer = new BinaryWriter(filestream);

            writer.Write(textBoxName.Text);
            writer.Write(textBoxJoinID.Text);
            writer.Write(textBoxJoinPW.Text);

            filestream.Close();
            return true;
        }

        private bool f_overlapCheck(string filepath)
        {
            FileStream filestream = File.Open(filepath, FileMode.OpenOrCreate);
            if (filestream == null)
            {
                MessageBox.Show("파일을 여는데 실패하였습니다.");
                return false;
            }

            BinaryReader reader = new BinaryReader(filestream);
            string id_check;

            while (reader != null)
            {
                if(reader.BaseStream.Position == reader.BaseStream.Length)
                {
                    MessageBox.Show(textBoxJoinID.Text + " 는 사용가능한 아이디입니다.");
                    break;
                }

                if (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    id_check = reader.ReadString();
                    if(id_check == textBoxJoinID.Text)
                    {
                        MessageBox.Show(textBoxJoinID.Text + " 는 이미 있는 ID입니다. 다시 입력해주세요");
                        break;
                    }
                }

            }

            filestream.Close();
            return true;
        }

        private void buttonJoin_Click_1(object sender, EventArgs e)
        {
            bool filecheck = f_writer("memberData");
            if (filecheck)
            {
                MessageBox.Show("가입 되었습니다.");

                this.Visible = false;
                LoginForm showLoginForm = new LoginForm();
                showLoginForm.ShowDialog();
            }
        }

        private void buttonOverlap_Click_1(object sender, EventArgs e)
        {
            f_overlapCheck("memberData");
        }

    }
}
