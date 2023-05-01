namespace Game
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.panelLoginJoin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.panelTimer.SuspendLayout();
            this.panelLoginJoin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(191, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "그림 맞추기 게임";
            // 
            // buttonSingle
            // 
            this.buttonSingle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSingle.Location = new System.Drawing.Point(136, 234);
            this.buttonSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(75, 27);
            this.buttonSingle.TabIndex = 3;
            this.buttonSingle.Text = "Single";
            this.buttonSingle.UseVisualStyleBackColor = true;
            this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.Thistle;
            this.panelTimer.Controls.Add(this.panelLoginJoin);
            this.panelTimer.Controls.Add(this.buttonBack);
            this.panelTimer.Controls.Add(this.buttonNo);
            this.panelTimer.Controls.Add(this.buttonYes);
            this.panelTimer.Controls.Add(this.label2);
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(700, 360);
            this.panelTimer.TabIndex = 6;
            this.panelTimer.Visible = false;
            // 
            // panelLoginJoin
            // 
            this.panelLoginJoin.BackColor = System.Drawing.Color.Lavender;
            this.panelLoginJoin.Controls.Add(this.panel1);
            this.panelLoginJoin.Controls.Add(this.buttonBack2);
            this.panelLoginJoin.Controls.Add(this.buttonJoin);
            this.panelLoginJoin.Controls.Add(this.buttonLogin);
            this.panelLoginJoin.Controls.Add(this.label4);
            this.panelLoginJoin.Location = new System.Drawing.Point(0, 0);
            this.panelLoginJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLoginJoin.Name = "panelLoginJoin";
            this.panelLoginJoin.Size = new System.Drawing.Size(700, 361);
            this.panelLoginJoin.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(574, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 6);
            this.panel1.TabIndex = 14;
            // 
            // buttonBack2
            // 
            this.buttonBack2.Location = new System.Drawing.Point(86, 266);
            this.buttonBack2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(66, 29);
            this.buttonBack2.TabIndex = 13;
            this.buttonBack2.Text = "이전";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click_1);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(436, 189);
            this.buttonJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(66, 25);
            this.buttonJoin.TabIndex = 12;
            this.buttonJoin.Text = "회원가입";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(196, 189);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(66, 25);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼편지체", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(242, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "로그인 OR 회원가입 ?";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(74, 291);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(66, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "이전";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(389, 195);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(66, 26);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "아니오";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(228, 195);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(66, 26);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "예";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(169, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "타이머 기능을 설정하시겠습니까?";
            // 
            // buttonMulti
            // 
            this.buttonMulti.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonMulti.Location = new System.Drawing.Point(484, 234);
            this.buttonMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(75, 27);
            this.buttonMulti.TabIndex = 7;
            this.buttonMulti.Text = "Multi";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSingle);
            this.Controls.Add(this.buttonMulti);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.panelLoginJoin.ResumeLayout(false);
            this.panelLoginJoin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Panel panelLoginJoin;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}