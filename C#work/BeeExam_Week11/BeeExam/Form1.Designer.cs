namespace BeeExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Honey = new System.Windows.Forms.Label();
            this.label_Enemy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_QueenHoney = new System.Windows.Forms.Label();
            this.label_QueenEnemy = new System.Windows.Forms.Label();
            this.label1_HoneyEmergency = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "TheHive";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(115, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Hive Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(115, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Honey:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(115, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enemy:";
            // 
            // label_Honey
            // 
            this.label_Honey.AutoSize = true;
            this.label_Honey.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Honey.Location = new System.Drawing.Point(203, 335);
            this.label_Honey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Honey.Name = "label_Honey";
            this.label_Honey.Size = new System.Drawing.Size(22, 19);
            this.label_Honey.TabIndex = 5;
            this.label_Honey.Text = "0";
            // 
            // label_Enemy
            // 
            this.label_Enemy.AutoSize = true;
            this.label_Enemy.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Enemy.Location = new System.Drawing.Point(203, 369);
            this.label_Enemy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Enemy.Name = "label_Enemy";
            this.label_Enemy.Size = new System.Drawing.Size(22, 19);
            this.label_Enemy.TabIndex = 6;
            this.label_Enemy.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(115, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "The Queen Work";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(56, 445);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Honey Collect:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(44, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Beating Enemy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(15, 515);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Honey Emergency:";
            // 
            // label_QueenHoney
            // 
            this.label_QueenHoney.AutoSize = true;
            this.label_QueenHoney.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_QueenHoney.Location = new System.Drawing.Point(228, 445);
            this.label_QueenHoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_QueenHoney.Name = "label_QueenHoney";
            this.label_QueenHoney.Size = new System.Drawing.Size(0, 19);
            this.label_QueenHoney.TabIndex = 11;
            // 
            // label_QueenEnemy
            // 
            this.label_QueenEnemy.AutoSize = true;
            this.label_QueenEnemy.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_QueenEnemy.Location = new System.Drawing.Point(228, 480);
            this.label_QueenEnemy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_QueenEnemy.Name = "label_QueenEnemy";
            this.label_QueenEnemy.Size = new System.Drawing.Size(0, 19);
            this.label_QueenEnemy.TabIndex = 12;
            // 
            // label1_HoneyEmergency
            // 
            this.label1_HoneyEmergency.AutoSize = true;
            this.label1_HoneyEmergency.Font = new System.Drawing.Font("HY목각파임B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_HoneyEmergency.Location = new System.Drawing.Point(228, 515);
            this.label1_HoneyEmergency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1_HoneyEmergency.Name = "label1_HoneyEmergency";
            this.label1_HoneyEmergency.Size = new System.Drawing.Size(0, 19);
            this.label1_HoneyEmergency.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 676);
            this.Controls.Add(this.label1_HoneyEmergency);
            this.Controls.Add(this.label_QueenEnemy);
            this.Controls.Add(this.label_QueenHoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Enemy);
            this.Controls.Add(this.label_Honey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Honey;
        private System.Windows.Forms.Label label_Enemy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_QueenHoney;
        private System.Windows.Forms.Label label_QueenEnemy;
        private System.Windows.Forms.Label label1_HoneyEmergency;
        private System.Windows.Forms.Timer timer1;
    }
}

