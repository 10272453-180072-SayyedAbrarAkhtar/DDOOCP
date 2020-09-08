namespace BrainGame
{
    partial class FrmAddWords
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
            this.dgViewAllWords = new System.Windows.Forms.DataGridView();
            this.wordid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateWord = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.txtFrenchWord = new System.Windows.Forms.TextBox();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlFormName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAllWords)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormName
            // 
            this.pnlFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.pnlFormName.Controls.Add(this.lblwelcomePlayer);
            this.pnlFormName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormName.Location = new System.Drawing.Point(0, 42);
            this.pnlFormName.Name = "pnlFormName";
            this.pnlFormName.Size = new System.Drawing.Size(954, 63);
            this.pnlFormName.TabIndex = 4;
            // 
            // lblwelcomePlayer
            // 
            this.lblwelcomePlayer.AutoSize = true;
            this.lblwelcomePlayer.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcomePlayer.Location = new System.Drawing.Point(414, 18);
            this.lblwelcomePlayer.Name = "lblwelcomePlayer";
            this.lblwelcomePlayer.Size = new System.Drawing.Size(127, 27);
            this.lblwelcomePlayer.TabIndex = 0;
            this.lblwelcomePlayer.Text = "Add Word";
            // 
            // dgViewAllWords
            // 
            this.dgViewAllWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewAllWords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.dgViewAllWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAllWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordid,
            this.Column1,
            this.Column2,
            this.btnUpdateWord,
            this.btnDelete});
            this.dgViewAllWords.Location = new System.Drawing.Point(38, 333);
            this.dgViewAllWords.Margin = new System.Windows.Forms.Padding(2);
            this.dgViewAllWords.Name = "dgViewAllWords";
            this.dgViewAllWords.Size = new System.Drawing.Size(879, 156);
            this.dgViewAllWords.TabIndex = 3;
            this.dgViewAllWords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewAllWords_CellContentClick);
            // 
            // wordid
            // 
            this.wordid.DataPropertyName = "wordid";
            this.wordid.FillWeight = 126.9036F;
            this.wordid.HeaderText = "S.No.";
            this.wordid.Name = "wordid";
            this.wordid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "englishWord";
            this.Column1.FillWeight = 93.27411F;
            this.Column1.HeaderText = "English Word";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "frenchWord";
            this.Column2.FillWeight = 93.27411F;
            this.Column2.HeaderText = "French Word";
            this.Column2.Name = "Column2";
            // 
            // btnUpdateWord
            // 
            this.btnUpdateWord.FillWeight = 93.27411F;
            this.btnUpdateWord.HeaderText = "Update";
            this.btnUpdateWord.Name = "btnUpdateWord";
            this.btnUpdateWord.Text = "Update";
            this.btnUpdateWord.ToolTipText = "Update";
            this.btnUpdateWord.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 93.27411F;
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnAddNewWord.FlatAppearance.BorderSize = 0;
            this.btnAddNewWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewWord.Location = new System.Drawing.Point(310, 230);
            this.btnAddNewWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(335, 30);
            this.btnAddNewWord.TabIndex = 2;
            this.btnAddNewWord.Text = "Add New Word";
            this.btnAddNewWord.UseVisualStyleBackColor = false;
            this.btnAddNewWord.Click += new System.EventHandler(this.btnAddNewWord_Click);
            // 
            // txtFrenchWord
            // 
            this.txtFrenchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrenchWord.Location = new System.Drawing.Point(639, 150);
            this.txtFrenchWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrenchWord.Name = "txtFrenchWord";
            this.txtFrenchWord.Size = new System.Drawing.Size(272, 27);
            this.txtFrenchWord.TabIndex = 1;
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishWord.Location = new System.Drawing.Point(170, 148);
            this.txtEnglishWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.Size = new System.Drawing.Size(251, 27);
            this.txtEnglishWord.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "French Word:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "English Word:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 504);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(22, 17);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "**";
            this.lblError.Visible = false;
            // 
            // FrmAddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 530);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgViewAllWords);
            this.Controls.Add(this.btnAddNewWord);
            this.Controls.Add(this.txtFrenchWord);
            this.Controls.Add(this.txtEnglishWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFormName);
            this.Name = "FrmAddWords";
            this.Text = "FrmAddWords";
            this.Load += new System.EventHandler(this.FrmAddWords_Load);
            this.Controls.SetChildIndex(this.pnlFormName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtEnglishWord, 0);
            this.Controls.SetChildIndex(this.txtFrenchWord, 0);
            this.Controls.SetChildIndex(this.btnAddNewWord, 0);
            this.Controls.SetChildIndex(this.dgViewAllWords, 0);
            this.Controls.SetChildIndex(this.lblError, 0);
            this.pnlFormName.ResumeLayout(false);
            this.pnlFormName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAllWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormName;
        private System.Windows.Forms.Label lblwelcomePlayer;
        private System.Windows.Forms.DataGridView dgViewAllWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdateWord;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.TextBox txtFrenchWord;
        private System.Windows.Forms.TextBox txtEnglishWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
    }
}