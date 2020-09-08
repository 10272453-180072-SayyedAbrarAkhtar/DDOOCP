namespace BrainGame
{
    partial class FrmLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.btnRegisterNewPlayer = new System.Windows.Forms.Button();
            this.btnPlayerLogin = new System.Windows.Forms.Button();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormName
            // 
            this.pnlFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.pnlFormName.Controls.Add(this.label3);
            this.pnlFormName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormName.Location = new System.Drawing.Point(0, 42);
            this.pnlFormName.Name = "pnlFormName";
            this.pnlFormName.Size = new System.Drawing.Size(582, 63);
            this.pnlFormName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log In";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(104, 318);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(22, 17);
            this.lblLoginError.TabIndex = 11;
            this.lblLoginError.Text = "**";
            this.lblLoginError.Visible = false;
            // 
            // btnRegisterNewPlayer
            // 
            this.btnRegisterNewPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnRegisterNewPlayer.FlatAppearance.BorderSize = 0;
            this.btnRegisterNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNewPlayer.Location = new System.Drawing.Point(340, 246);
            this.btnRegisterNewPlayer.Name = "btnRegisterNewPlayer";
            this.btnRegisterNewPlayer.Size = new System.Drawing.Size(139, 36);
            this.btnRegisterNewPlayer.TabIndex = 3;
            this.btnRegisterNewPlayer.Text = "Register";
            this.btnRegisterNewPlayer.UseVisualStyleBackColor = false;
            this.btnRegisterNewPlayer.Click += new System.EventHandler(this.btnRegisterNewPlayer_Click);
            // 
            // btnPlayerLogin
            // 
            this.btnPlayerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnPlayerLogin.FlatAppearance.BorderSize = 0;
            this.btnPlayerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerLogin.Location = new System.Drawing.Point(108, 246);
            this.btnPlayerLogin.Name = "btnPlayerLogin";
            this.btnPlayerLogin.Size = new System.Drawing.Size(139, 36);
            this.btnPlayerLogin.TabIndex = 2;
            this.btnPlayerLogin.Text = "Log In";
            this.btnPlayerLogin.UseVisualStyleBackColor = false;
            this.btnPlayerLogin.Click += new System.EventHandler(this.btnPlayerLogin_Click);
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(228, 182);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.PasswordChar = '*';
            this.txtPlayerPassword.Size = new System.Drawing.Size(251, 25);
            this.txtPlayerPassword.TabIndex = 1;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(228, 135);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(251, 25);
            this.txtPlayerName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player Name:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.btnRegisterNewPlayer);
            this.Controls.Add(this.btnPlayerLogin);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFormName);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Controls.SetChildIndex(this.pnlFormName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPlayerName, 0);
            this.Controls.SetChildIndex(this.txtPlayerPassword, 0);
            this.Controls.SetChildIndex(this.btnPlayerLogin, 0);
            this.Controls.SetChildIndex(this.btnRegisterNewPlayer, 0);
            this.Controls.SetChildIndex(this.lblLoginError, 0);
            this.pnlFormName.ResumeLayout(false);
            this.pnlFormName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Button btnRegisterNewPlayer;
        private System.Windows.Forms.Button btnPlayerLogin;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}