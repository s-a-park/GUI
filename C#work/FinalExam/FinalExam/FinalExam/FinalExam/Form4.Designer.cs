namespace FinalExam
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_GranMa = new System.Windows.Forms.Label();
            this.lb_BM = new System.Windows.Forms.Label();
            this.lb_St = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(115, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GrandMa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(320, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "BusinessMan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(572, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "UnvercityStudent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(272, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "탕진잼 파티";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "누구돈이 먼저 -가 될까요?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "갱신!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_GranMa
            // 
            this.lb_GranMa.AutoSize = true;
            this.lb_GranMa.Location = new System.Drawing.Point(149, 215);
            this.lb_GranMa.Name = "lb_GranMa";
            this.lb_GranMa.Size = new System.Drawing.Size(38, 12);
            this.lb_GranMa.TabIndex = 6;
            this.lb_GranMa.Text = "label6";
            // 
            // lb_BM
            // 
            this.lb_BM.AutoSize = true;
            this.lb_BM.Location = new System.Drawing.Point(377, 215);
            this.lb_BM.Name = "lb_BM";
            this.lb_BM.Size = new System.Drawing.Size(38, 12);
            this.lb_BM.TabIndex = 7;
            this.lb_BM.Text = "label7";
            // 
            // lb_St
            // 
            this.lb_St.AutoSize = true;
            this.lb_St.Location = new System.Drawing.Point(634, 215);
            this.lb_St.Name = "lb_St";
            this.lb_St.Size = new System.Drawing.Size(38, 12);
            this.lb_St.TabIndex = 8;
            this.lb_St.Text = "label8";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_St);
            this.Controls.Add(this.lb_BM);
            this.Controls.Add(this.lb_GranMa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_GranMa;
        private System.Windows.Forms.Label lb_BM;
        private System.Windows.Forms.Label lb_St;
    }
}