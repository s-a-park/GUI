namespace Game
{
    partial class LoginForm
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
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(144, 149);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(88, 21);
            this.textBoxPW.TabIndex = 21;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(144, 117);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(88, 21);
            this.textBoxID.TabIndex = 20;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(124, 215);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(66, 23);
            this.buttonLogin.TabIndex = 19;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "비밀번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "아이디 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(121, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "로그인";
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.buttonNo);
            this.panelTimer.Controls.Add(this.buttonYes);
            this.panelTimer.Controls.Add(this.label3);
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(310, 289);
            this.panelTimer.TabIndex = 23;
            this.panelTimer.Visible = false;
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(185, 173);
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
            this.buttonYes.Location = new System.Drawing.Point(69, 173);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(66, 26);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "예";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "타이머 기능을 설정하시겠습니까?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(310, 289);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label3;
    }
}