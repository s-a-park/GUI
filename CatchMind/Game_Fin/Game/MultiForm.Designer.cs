namespace Game
{
    partial class MultiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "MUITI PLAY";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelScore.Location = new System.Drawing.Point(66, 174);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(46, 29);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "0점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(66, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "점수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(40, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "남은 시간";
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(643, 406);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(188, 21);
            this.textBoxChat.TabIndex = 30;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(849, 406);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 29;
            this.buttonSend.Text = "전송";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.Location = new System.Drawing.Point(640, 70);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.Size = new System.Drawing.Size(271, 306);
            this.richTextBoxChat.TabIndex = 28;
            this.richTextBoxChat.Text = "";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(498, 394);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(77, 32);
            this.buttonInput.TabIndex = 27;
            this.buttonInput.Text = "정답입력";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(248, 402);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(210, 21);
            this.textBoxAnswer.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(737, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "채팅창";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "가라오케.jpg");
            this.imageList1.Images.SetKeyName(1, "가로수.jpg");
            this.imageList1.Images.SetKeyName(2, "가이드북.jpg");
            this.imageList1.Images.SetKeyName(3, "공중전화.jpg");
            this.imageList1.Images.SetKeyName(4, "도시.jpg");
            this.imageList1.Images.SetKeyName(5, "백수.jpg");
            this.imageList1.Images.SetKeyName(6, "블럭체인.jpg");
            this.imageList1.Images.SetKeyName(7, "샴푸.jpg");
            this.imageList1.Images.SetKeyName(8, "소방관.jpg");
            this.imageList1.Images.SetKeyName(9, "연장전.jpg");
            this.imageList1.Images.SetKeyName(10, "오동나무.jpg");
            this.imageList1.Images.SetKeyName(11, "일간신문.jpg");
            this.imageList1.Images.SetKeyName(12, "진혼곡.jpg");
            this.imageList1.Images.SetKeyName(13, "초등학생.jpg");
            this.imageList1.Images.SetKeyName(14, "카카오나무.jpg");
            this.imageList1.Images.SetKeyName(15, "파워킹.jpg");
            this.imageList1.Images.SetKeyName(16, "포크레인.jpg");
            this.imageList1.Images.SetKeyName(17, "KakaoTalk_20190616_200813041.jpg");
            this.imageList1.Images.SetKeyName(18, "KakaoTalk_20190616_200813153.jpg");
            this.imageList1.Images.SetKeyName(19, "KakaoTalk_20190616_200813255.jpg");
            this.imageList1.Images.SetKeyName(20, "KakaoTalk_20190616_200813347.jpg");
            this.imageList1.Images.SetKeyName(21, "KakaoTalk_20190616_200813454.jpg");
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMin.Location = new System.Drawing.Point(51, 270);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(27, 29);
            this.labelMin.TabIndex = 34;
            this.labelMin.Text = "2";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSec.Location = new System.Drawing.Point(98, 270);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(41, 29);
            this.labelSec.TabIndex = 33;
            this.labelSec.Text = "00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(79, 270);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 29);
            this.label.TabIndex = 32;
            this.label.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(223, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "컴퓨터와 싸우는 중!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(639, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "처음 입력한 것이 닉네임이 되어요!";
            // 
            // MultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(970, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultiForm";
            this.Text = "MultiForm";
            this.Load += new System.EventHandler(this.MultiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}