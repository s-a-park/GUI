namespace FinalExam
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label_ConnectFlag = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_Hak = new System.Windows.Forms.Label();
            this.textBox_BiBun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(704, 65);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(92, 35);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 35);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(387, 129);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(123, 39);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // label_ConnectFlag
            // 
            this.label_ConnectFlag.AutoSize = true;
            this.label_ConnectFlag.Location = new System.Drawing.Point(376, 29);
            this.label_ConnectFlag.Name = "label_ConnectFlag";
            this.label_ConnectFlag.Size = new System.Drawing.Size(81, 12);
            this.label_ConnectFlag.TabIndex = 4;
            this.label_ConnectFlag.Text = "Connecting...";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 324);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "문제2번";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "문제3번";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "문제4번";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "문제5번";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_Hak
            // 
            this.label_Hak.AutoSize = true;
            this.label_Hak.Location = new System.Drawing.Point(385, 418);
            this.label_Hak.Name = "label_Hak";
            this.label_Hak.Size = new System.Drawing.Size(0, 12);
            this.label_Hak.TabIndex = 10;
            // 
            // textBox_BiBun
            // 
            this.textBox_BiBun.Location = new System.Drawing.Point(533, 384);
            this.textBox_BiBun.Name = "textBox_BiBun";
            this.textBox_BiBun.Size = new System.Drawing.Size(100, 21);
            this.textBox_BiBun.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "비밀번호입력 후 문제5번 버튼 클릭";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BiBun);
            this.Controls.Add(this.label_Hak);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_ConnectFlag);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label_ConnectFlag;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_Hak;
        private System.Windows.Forms.TextBox textBox_BiBun;
        private System.Windows.Forms.Label label2;
    }
}

