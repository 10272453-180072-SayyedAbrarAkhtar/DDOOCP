namespace BrainGame
{
    partial class Game
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
            this.grpBxPlayerDetails = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPlayer2Timer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOverallTotlTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlayer1Timer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.grpBxEnglishWord = new System.Windows.Forms.GroupBox();
            this.grpBxFrenchWord = new System.Windows.Forms.GroupBox();
            this.player1Timer = new System.Windows.Forms.Timer(this.components);
            this.player2Timer = new System.Windows.Forms.Timer(this.components);
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
            this.grpBxPlayerDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxPlayerDetails
            // 
            this.grpBxPlayerDetails.Controls.Add(this.panel3);
            this.grpBxPlayerDetails.Controls.Add(this.panel2);
            this.grpBxPlayerDetails.Controls.Add(this.panel1);
            this.grpBxPlayerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxPlayerDetails.Location = new System.Drawing.Point(0, 0);
            this.grpBxPlayerDetails.Name = "grpBxPlayerDetails";
            this.grpBxPlayerDetails.Size = new System.Drawing.Size(1023, 70);
            this.grpBxPlayerDetails.TabIndex = 2;
            this.grpBxPlayerDetails.TabStop = false;
            this.grpBxPlayerDetails.Text = "Players";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPlayer2Timer);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblPlayer2Score);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.lblPlayer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(441, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 51);
            this.panel3.TabIndex = 9;
            // 
            // lblPlayer2Timer
            // 
            this.lblPlayer2Timer.AutoSize = true;
            this.lblPlayer2Timer.Location = new System.Drawing.Point(411, 20);
            this.lblPlayer2Timer.Name = "lblPlayer2Timer";
            this.lblPlayer2Timer.Size = new System.Drawing.Size(13, 13);
            this.lblPlayer2Timer.TabIndex = 7;
            this.lblPlayer2Timer.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time:";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(239, 20);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(13, 13);
            this.lblPlayer2Score.TabIndex = 5;
            this.lblPlayer2Score.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(195, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Score:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(51, 20);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(41, 13);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "player1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOverallTotlTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(876, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 51);
            this.panel2.TabIndex = 1;
            // 
            // lblOverallTotlTime
            // 
            this.lblOverallTotlTime.AutoSize = true;
            this.lblOverallTotlTime.Location = new System.Drawing.Point(100, 20);
            this.lblOverallTotlTime.Name = "lblOverallTotlTime";
            this.lblOverallTotlTime.Size = new System.Drawing.Size(13, 13);
            this.lblOverallTotlTime.TabIndex = 7;
            this.lblOverallTotlTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Time:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlayer1Timer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPlayer1Score);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPlayer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 51);
            this.panel1.TabIndex = 0;
            // 
            // lblPlayer1Timer
            // 
            this.lblPlayer1Timer.AutoSize = true;
            this.lblPlayer1Timer.Location = new System.Drawing.Point(415, 19);
            this.lblPlayer1Timer.Name = "lblPlayer1Timer";
            this.lblPlayer1Timer.Size = new System.Drawing.Size(13, 13);
            this.lblPlayer1Timer.TabIndex = 2;
            this.lblPlayer1Timer.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Time:";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(225, 19);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(13, 13);
            this.lblPlayer1Score.TabIndex = 1;
            this.lblPlayer1Score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(10, 16);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(41, 13);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "player1";
            // 
            // grpBxEnglishWord
            // 
            this.grpBxEnglishWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxEnglishWord.Location = new System.Drawing.Point(0, 70);
            this.grpBxEnglishWord.Name = "grpBxEnglishWord";
            this.grpBxEnglishWord.Size = new System.Drawing.Size(1023, 159);
            this.grpBxEnglishWord.TabIndex = 3;
            this.grpBxEnglishWord.TabStop = false;
            this.grpBxEnglishWord.Text = "English";
            // 
            // grpBxFrenchWord
            // 
            this.grpBxFrenchWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBxFrenchWord.Location = new System.Drawing.Point(0, 230);
            this.grpBxFrenchWord.Name = "grpBxFrenchWord";
            this.grpBxFrenchWord.Size = new System.Drawing.Size(1023, 191);
            this.grpBxFrenchWord.TabIndex = 4;
            this.grpBxFrenchWord.TabStop = false;
            this.grpBxFrenchWord.Text = "French";
            // 
            // player1Timer
            // 
            this.player1Timer.Tick += new System.EventHandler(this.player1Timer_Tick);
            // 
            // player2Timer
            // 
            this.player2Timer.Tick += new System.EventHandler(this.player2Timer_Tick);
            // 
            // totalTimer
            // 
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1023, 421);
            this.Controls.Add(this.grpBxFrenchWord);
            this.Controls.Add(this.grpBxEnglishWord);
            this.Controls.Add(this.grpBxPlayerDetails);
            this.Name = "Game";
            this.Text = "Brain Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.grpBxPlayerDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBxPlayerDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlayer2Timer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOverallTotlTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlayer1Timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.GroupBox grpBxEnglishWord;
        private System.Windows.Forms.GroupBox grpBxFrenchWord;
        private System.Windows.Forms.Timer player1Timer;
        private System.Windows.Forms.Timer player2Timer;
        private System.Windows.Forms.Timer totalTimer;
    }
}