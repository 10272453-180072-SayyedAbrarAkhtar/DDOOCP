namespace BrainGame
{
    partial class FrmWelcome
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
            this.lblwelcomePlayer = new System.Windows.Forms.Label();
            this.btnRegisterNewPlayer = new System.Windows.Forms.Button();
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.pnlFormName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormName
            // 
            this.pnlFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.pnlFormName.Controls.Add(this.lblwelcomePlayer);
            this.pnlFormName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormName.Location = new System.Drawing.Point(0, 42);
            this.pnlFormName.Name = "pnlFormName";
            this.pnlFormName.Size = new System.Drawing.Size(555, 63);
            this.pnlFormName.TabIndex = 3;
            // 
            // lblwelcomePlayer
            // 
            this.lblwelcomePlayer.AutoSize = true;
            this.lblwelcomePlayer.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcomePlayer.Location = new System.Drawing.Point(71, 19);
            this.lblwelcomePlayer.Name = "lblwelcomePlayer";
            this.lblwelcomePlayer.Size = new System.Drawing.Size(138, 27);
            this.lblwelcomePlayer.TabIndex = 0;
            this.lblwelcomePlayer.Text = "Welcome   ";
            // 
            // btnRegisterNewPlayer
            // 
            this.btnRegisterNewPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnRegisterNewPlayer.FlatAppearance.BorderSize = 0;
            this.btnRegisterNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNewPlayer.Location = new System.Drawing.Point(35, 150);
            this.btnRegisterNewPlayer.Name = "btnRegisterNewPlayer";
            this.btnRegisterNewPlayer.Size = new System.Drawing.Size(485, 41);
            this.btnRegisterNewPlayer.TabIndex = 0;
            this.btnRegisterNewPlayer.Text = "Register New Player";
            this.btnRegisterNewPlayer.UseVisualStyleBackColor = false;
            this.btnRegisterNewPlayer.Click += new System.EventHandler(this.btnRegisterNewPlayer_Click);
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnAddNewWord.FlatAppearance.BorderSize = 0;
            this.btnAddNewWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWord.Location = new System.Drawing.Point(35, 210);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(485, 41);
            this.btnAddNewWord.TabIndex = 1;
            this.btnAddNewWord.Text = "Add New Words";
            this.btnAddNewWord.UseVisualStyleBackColor = false;
            this.btnAddNewWord.Click += new System.EventHandler(this.btnAddNewWord_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnPlayGame.FlatAppearance.BorderSize = 0;
            this.btnPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayGame.Location = new System.Drawing.Point(35, 270);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(485, 41);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 358);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnAddNewWord);
            this.Controls.Add(this.btnRegisterNewPlayer);
            this.Controls.Add(this.pnlFormName);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmWelcome";
            this.Text = "FrmWelcome";
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            this.Controls.SetChildIndex(this.pnlFormName, 0);
            this.Controls.SetChildIndex(this.btnRegisterNewPlayer, 0);
            this.Controls.SetChildIndex(this.btnAddNewWord, 0);
            this.Controls.SetChildIndex(this.btnPlayGame, 0);
            this.pnlFormName.ResumeLayout(false);
            this.pnlFormName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormName;
        private System.Windows.Forms.Label lblwelcomePlayer;
        private System.Windows.Forms.Button btnRegisterNewPlayer;
        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.Button btnPlayGame;
    }
}