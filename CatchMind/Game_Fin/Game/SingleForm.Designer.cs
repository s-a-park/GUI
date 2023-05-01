namespace Game
{
    partial class SingleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSec = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Passbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINGLE PLAY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(127, 300);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(210, 21);
            this.textBoxAnswer.TabIndex = 2;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(367, 295);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(66, 25);
            this.buttonInput.TabIndex = 3;
            this.buttonInput.Text = "정답입력";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(603, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 29);
            this.label.TabIndex = 6;
            this.label.Text = ":";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelScore.Location = new System.Drawing.Point(584, 220);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(46, 29);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "0점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(584, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "점수";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSec.Location = new System.Drawing.Point(622, 136);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(41, 29);
            this.labelSec.TabIndex = 9;
            this.labelSec.Text = "00";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMin.Location = new System.Drawing.Point(575, 136);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(27, 29);
            this.labelMin.TabIndex = 10;
            this.labelMin.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(559, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "남은 시간";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KakaoTalk_20190616_001023049.jpg");
            this.imageList1.Images.SetKeyName(1, "KakaoTalk_20190616_001023137.jpg");
            this.imageList1.Images.SetKeyName(2, "KakaoTalk_20190616_001023322.jpg");
            this.imageList1.Images.SetKeyName(3, "KakaoTalk_20190616_001023463.jpg");
            this.imageList1.Images.SetKeyName(4, "KakaoTalk_20190616_001023589.jpg");
            this.imageList1.Images.SetKeyName(5, "KakaoTalk_20190616_001023782.jpg");
            this.imageList1.Images.SetKeyName(6, "KakaoTalk_20190616_001023881.jpg");
            this.imageList1.Images.SetKeyName(7, "KakaoTalk_20190616_001023965.jpg");
            this.imageList1.Images.SetKeyName(8, "KakaoTalk_20190616_001024100.jpg");
            this.imageList1.Images.SetKeyName(9, "KakaoTalk_20190616_001024217.jpg");
            this.imageList1.Images.SetKeyName(10, "KakaoTalk_20190616_001024363.jpg");
            this.imageList1.Images.SetKeyName(11, "KakaoTalk_20190616_001024463.jpg");
            this.imageList1.Images.SetKeyName(12, "KakaoTalk_20190616_001024602.jpg");
            this.imageList1.Images.SetKeyName(13, "KakaoTalk_20190616_001024726.jpg");
            this.imageList1.Images.SetKeyName(14, "KakaoTalk_20190616_001024887.jpg");
            this.imageList1.Images.SetKeyName(15, "KakaoTalk_20190616_001025032.jpg");
            this.imageList1.Images.SetKeyName(16, "KakaoTalk_20190616_001025193.jpg");
            this.imageList1.Images.SetKeyName(17, "KakaoTalk_20190616_200813041.jpg");
            this.imageList1.Images.SetKeyName(18, "KakaoTalk_20190616_200813153.jpg");
            this.imageList1.Images.SetKeyName(19, "KakaoTalk_20190616_200813255.jpg");
            this.imageList1.Images.SetKeyName(20, "KakaoTalk_20190616_200813347.jpg");
            this.imageList1.Images.SetKeyName(21, "KakaoTalk_20190616_200813454.jpg");
            // 
            // Passbutton
            // 
            this.Passbutton.Location = new System.Drawing.Point(458, 295);
            this.Passbutton.Name = "Passbutton";
            this.Passbutton.Size = new System.Drawing.Size(75, 25);
            this.Passbutton.TabIndex = 21;
            this.Passbutton.Text = "넘어가기";
            this.Passbutton.UseVisualStyleBackColor = true;
            this.Passbutton.Click += new System.EventHandler(this.Passbutton_Click);
            // 
            // SingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.Passbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SingleForm";
            this.Text = "SingleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Passbutton;
    }
}