namespace Game
{
    partial class MultiForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiForm2));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(745, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "채팅창";
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(651, 392);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(188, 21);
            this.textBoxChat.TabIndex = 44;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(857, 392);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 43;
            this.buttonSend.Text = "전송";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.Location = new System.Drawing.Point(648, 55);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.Size = new System.Drawing.Size(271, 306);
            this.richTextBoxChat.TabIndex = 42;
            this.richTextBoxChat.Text = "";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(506, 380);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(77, 32);
            this.buttonInput.TabIndex = 41;
            this.buttonInput.Text = "정답입력";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(256, 388);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(210, 21);
            this.textBoxAnswer.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(209, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelScore.Location = new System.Drawing.Point(74, 159);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(32, 29);
            this.labelScore.TabIndex = 37;
            this.labelScore.Text = "점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(74, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "점수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "MUITI PLAY";
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
            this.imageList1.Images.SetKeyName(5, "블럭체인.jpg");
            this.imageList1.Images.SetKeyName(6, "백수.jpg");
            this.imageList1.Images.SetKeyName(7, "샴푸.jpg");
            this.imageList1.Images.SetKeyName(8, "소방관.jpg");
            this.imageList1.Images.SetKeyName(9, "연장전.jpg");
            this.imageList1.Images.SetKeyName(10, "오동나무.jpg");
            this.imageList1.Images.SetKeyName(11, "일간신문.jpg");
            this.imageList1.Images.SetKeyName(12, "진혼곡.jpg");
            this.imageList1.Images.SetKeyName(13, "초등학교.jpg");
            this.imageList1.Images.SetKeyName(14, "카카오나무.jpg");
            this.imageList1.Images.SetKeyName(15, "파워킹.jpg");
            this.imageList1.Images.SetKeyName(16, "포크레인.jpg");
            this.imageList1.Images.SetKeyName(17, "KakaoTalk_20190616_200813041.jpg");
            this.imageList1.Images.SetKeyName(18, "KakaoTalk_20190616_200813153.jpg");
            this.imageList1.Images.SetKeyName(19, "KakaoTalk_20190616_200813255.jpg");
            this.imageList1.Images.SetKeyName(20, "KakaoTalk_20190616_200813347.jpg");
            this.imageList1.Images.SetKeyName(21, "KakaoTalk_20190616_200813454.jpg");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(71, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "0점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(50, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "목표점수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(636, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "처음 입력한 것이 닉네임이 되어요!";
            // 
            // MultiForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1007, 435);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultiForm2";
            this.Text = "MultiForm2";
            this.Load += new System.EventHandler(this.MultiForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}