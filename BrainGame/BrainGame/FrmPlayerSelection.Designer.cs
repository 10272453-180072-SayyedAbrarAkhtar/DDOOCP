namespace BrainGame
{
    partial class FrmPlayerSelection
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
            this.lblGreetings = new System.Windows.Forms.Label();
            this.grpBoxPlayerSelection = new System.Windows.Forms.GroupBox();
            this.pnlFormName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormName
            // 
            this.pnlFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.pnlFormName.Controls.Add(this.lbl);
            this.pnlFormName.Location = new System.Drawing.Point(0, 41);
            this.pnlFormName.Name = "pnlFormName";
            this.pnlFormName.Size = new System.Drawing.Size(738, 63);
            this.pnlFormName.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(321, 18);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(97, 27);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Players";
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(26, 129);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(89, 21);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "Welcome";
            // 
            // grpBoxPlayerSelection
            // 
            this.grpBoxPlayerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.grpBoxPlayerSelection.Location = new System.Drawing.Point(30, 183);
            this.grpBoxPlayerSelection.Name = "grpBoxPlayerSelection";
            this.grpBoxPlayerSelection.Size = new System.Drawing.Size(674, 215);
            this.grpBoxPlayerSelection.TabIndex = 3;
            this.grpBoxPlayerSelection.TabStop = false;
            this.grpBoxPlayerSelection.Text = "Please select any player";
            // 
            // FrmPlayerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 435);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.grpBoxPlayerSelection);
            this.Controls.Add(this.pnlFormName);
            this.Name = "FrmPlayerSelection";
            this.Text = "PlayerSelection";
            this.Load += new System.EventHandler(this.PlayerSelection_Load);
            this.Controls.SetChildIndex(this.pnlFormName, 0);
            this.Controls.SetChildIndex(this.grpBoxPlayerSelection, 0);
            this.Controls.SetChildIndex(this.lblGreetings, 0);
            this.pnlFormName.ResumeLayout(false);
            this.pnlFormName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.GroupBox grpBoxPlayerSelection;
    }
}