namespace Maze
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.finishLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.finishLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 590);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Location = new System.Drawing.Point(547, 561);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(34, 13);
            this.finishLabel.TabIndex = 7;
            this.finishLabel.Text = "Finish";
            this.finishLabel.MouseEnter += new System.EventHandler(this.finishLabel_MouseEnter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(122, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(410, 23);
            this.label7.TabIndex = 6;
            this.label7.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(77, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 23);
            this.label6.TabIndex = 5;
            this.label6.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(477, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 244);
            this.label5.TabIndex = 4;
            this.label5.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(92, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 87);
            this.label4.TabIndex = 3;
            this.label4.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(27, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 23);
            this.label3.TabIndex = 2;
            this.label3.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(95, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 23);
            this.label2.TabIndex = 1;
            this.label2.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 23);
            this.label1.TabIndex = 0;
            this.label1.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finishLabel;
    }
}

