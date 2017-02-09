namespace Ducks
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbWinChance1 = new System.Windows.Forms.Label();
            this.lbDuck1 = new System.Windows.Forms.Label();
            this.lbDuck2 = new System.Windows.Forms.Label();
            this.lbDuck3 = new System.Windows.Forms.Label();
            this.lbDuck4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Win chance in one game";
            // 
            // lbWinChance1
            // 
            this.lbWinChance1.AutoSize = true;
            this.lbWinChance1.Location = new System.Drawing.Point(128, 97);
            this.lbWinChance1.Name = "lbWinChance1";
            this.lbWinChance1.Size = new System.Drawing.Size(13, 13);
            this.lbWinChance1.TabIndex = 2;
            this.lbWinChance1.Text = "0";
            // 
            // lbDuck1
            // 
            this.lbDuck1.AutoSize = true;
            this.lbDuck1.Location = new System.Drawing.Point(54, 143);
            this.lbDuck1.Name = "lbDuck1";
            this.lbDuck1.Size = new System.Drawing.Size(35, 13);
            this.lbDuck1.TabIndex = 3;
            this.lbDuck1.Text = "label2";
            // 
            // lbDuck2
            // 
            this.lbDuck2.AutoSize = true;
            this.lbDuck2.Location = new System.Drawing.Point(54, 169);
            this.lbDuck2.Name = "lbDuck2";
            this.lbDuck2.Size = new System.Drawing.Size(35, 13);
            this.lbDuck2.TabIndex = 4;
            this.lbDuck2.Text = "label3";
            // 
            // lbDuck3
            // 
            this.lbDuck3.AutoSize = true;
            this.lbDuck3.Location = new System.Drawing.Point(54, 195);
            this.lbDuck3.Name = "lbDuck3";
            this.lbDuck3.Size = new System.Drawing.Size(35, 13);
            this.lbDuck3.TabIndex = 5;
            this.lbDuck3.Text = "label4";
            // 
            // lbDuck4
            // 
            this.lbDuck4.AutoSize = true;
            this.lbDuck4.Location = new System.Drawing.Point(54, 220);
            this.lbDuck4.Name = "lbDuck4";
            this.lbDuck4.Size = new System.Drawing.Size(35, 13);
            this.lbDuck4.TabIndex = 6;
            this.lbDuck4.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbDuck4);
            this.Controls.Add(this.lbDuck3);
            this.Controls.Add(this.lbDuck2);
            this.Controls.Add(this.lbDuck1);
            this.Controls.Add(this.lbWinChance1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ducks & chance to win";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWinChance1;
        private System.Windows.Forms.Label lbDuck1;
        private System.Windows.Forms.Label lbDuck2;
        private System.Windows.Forms.Label lbDuck3;
        private System.Windows.Forms.Label lbDuck4;
    }
}

