namespace BrainGame
{
    partial class FrmScoreBoard
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
            this.pnlFormName = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.lbltime2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltime1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblp2 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pnlFormName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormName
            // 
            this.pnlFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.pnlFormName.Controls.Add(this.lbl);
            this.pnlFormName.Location = new System.Drawing.Point(0, 41);
            this.pnlFormName.Name = "pnlFormName";
            this.pnlFormName.Size = new System.Drawing.Size(858, 63);
            this.pnlFormName.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(280, 18);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(88, 27);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Scores";
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(481, 383);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(106, 49);
            this.btnno.TabIndex = 18;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(211, 383);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(106, 49);
            this.btnyes.TabIndex = 19;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // lbltime2
            // 
            this.lbltime2.AutoSize = true;
            this.lbltime2.Location = new System.Drawing.Point(661, 213);
            this.lbltime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime2.Name = "lbltime2";
            this.lbltime2.Size = new System.Drawing.Size(17, 17);
            this.lbltime2.TabIndex = 4;
            this.lbltime2.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Do You Want To Play Again?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Player 2 Time: ";
            // 
            // lbltime1
            // 
            this.lbltime1.AutoSize = true;
            this.lbltime1.Location = new System.Drawing.Point(227, 213);
            this.lbltime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime1.Name = "lbltime1";
            this.lbltime1.Size = new System.Drawing.Size(17, 17);
            this.lbltime1.TabIndex = 7;
            this.lbltime1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player 1 Time:";
            // 
            // lblp2
            // 
            this.lblp2.AutoSize = true;
            this.lblp2.Location = new System.Drawing.Point(661, 120);
            this.lblp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(17, 17);
            this.lblp2.TabIndex = 9;
            this.lblp2.Text = "0";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Location = new System.Drawing.Point(661, 165);
            this.lblscore2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(17, 17);
            this.lblscore2.TabIndex = 10;
            this.lblscore2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player 2 Score:";
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Location = new System.Drawing.Point(227, 120);
            this.lblp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(17, 17);
            this.lblp1.TabIndex = 13;
            this.lblp1.Text = "0";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Location = new System.Drawing.Point(227, 165);
            this.lblscore1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(17, 17);
            this.lblscore1.TabIndex = 14;
            this.lblscore1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Player 1 Score:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(259, 280);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(58, 17);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "Winner";
            // 
            // FrmScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 479);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.lbltime2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltime1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblp2);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.lblscore1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlFormName);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmScoreBoard";
            this.Text = "Score Board";
            this.Load += new System.EventHandler(this.FrmScoreBoard_Load);
            this.Controls.SetChildIndex(this.pnlFormName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblscore1, 0);
            this.Controls.SetChildIndex(this.lblp1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lblscore2, 0);
            this.Controls.SetChildIndex(this.lblp2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblWinner, 0);
            this.Controls.SetChildIndex(this.lbltime1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.lbltime2, 0);
            this.Controls.SetChildIndex(this.btnyes, 0);
            this.Controls.SetChildIndex(this.btnno, 0);
            this.pnlFormName.ResumeLayout(false);
            this.pnlFormName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label lbltime2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblp2;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinner;
    }
}