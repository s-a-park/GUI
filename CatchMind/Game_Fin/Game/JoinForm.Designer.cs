namespace Game
{
    partial class JoinForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.textBoxJoinPW = new System.Windows.Forms.TextBox();
            this.textBoxJoinID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOverlap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(130, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "회원가입";
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(197, 162);
            this.radioButtonF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(35, 16);
            this.radioButtonF.TabIndex = 25;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "여";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(147, 162);
            this.radioButtonM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(35, 16);
            this.radioButtonM.TabIndex = 24;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "남";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "성별 :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(147, 127);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(88, 21);
            this.textBoxName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "이름 :";
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(147, 283);
            this.buttonJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(66, 26);
            this.buttonJoin.TabIndex = 20;
            this.buttonJoin.Text = "가입하기";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click_1);
            // 
            // textBoxJoinPW
            // 
            this.textBoxJoinPW.Location = new System.Drawing.Point(147, 224);
            this.textBoxJoinPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJoinPW.Name = "textBoxJoinPW";
            this.textBoxJoinPW.PasswordChar = '*';
            this.textBoxJoinPW.Size = new System.Drawing.Size(88, 21);
            this.textBoxJoinPW.TabIndex = 19;
            // 
            // textBoxJoinID
            // 
            this.textBoxJoinID.Location = new System.Drawing.Point(147, 192);
            this.textBoxJoinID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJoinID.Name = "textBoxJoinID";
            this.textBoxJoinID.Size = new System.Drawing.Size(88, 21);
            this.textBoxJoinID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "비밀번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "아이디 :";
            // 
            // buttonOverlap
            // 
            this.buttonOverlap.Location = new System.Drawing.Point(250, 187);
            this.buttonOverlap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOverlap.Name = "buttonOverlap";
            this.buttonOverlap.Size = new System.Drawing.Size(66, 26);
            this.buttonOverlap.TabIndex = 27;
            this.buttonOverlap.Text = "중복확인";
            this.buttonOverlap.UseVisualStyleBackColor = true;
            this.buttonOverlap.Click += new System.EventHandler(this.buttonOverlap_Click_1);
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(364, 354);
            this.Controls.Add(this.buttonOverlap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.textBoxJoinPW);
            this.Controls.Add(this.textBoxJoinID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JoinForm";
            this.Text = "JoinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.TextBox textBoxJoinPW;
        private System.Windows.Forms.TextBox textBoxJoinID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOverlap;
    }
}