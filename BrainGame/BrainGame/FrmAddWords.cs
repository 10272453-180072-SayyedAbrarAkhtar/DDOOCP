using BrainGame.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainGame
{
    public partial class FrmAddWords : FrmTemplate
    {
        int WordId;
        public FrmAddWords()
        {
            InitializeComponent();
        }

        private void btnAddNewWord_Click(object sender, EventArgs e)
        {
            WordBLL addWord, updateWord;
            if (btnAddNewWord.Text == "Add New Word")
            {
                addWord = new WordBLL();
                addWord.EnglishWord = txtEnglishWord.Text;
                addWord.FrenchWord = txtFrenchWord.Text;
                addWord.AddNewWords();
                clearControls();
                retrieveAllWords();
                return;
            }
            else if (btnAddNewWord.Text == "Update")
            {
                updateWord = new WordBLL();
                updateWord.EnglishWord = txtEnglishWord.Text;
                updateWord.FrenchWord = txtFrenchWord.Text;
                updateWord.WordId = WordId;
                updateWord.UpdateWord();
                clearControls();
                retrieveAllWords();
                return;
            }
        }


        private void clearControls()
        {
            txtEnglishWord.Clear();
            txtFrenchWord.Clear();
            txtEnglishWord.Focus();
        }


        public void retrieveAllWords()
        {
            WordBLL retrieveAllWord = new WordBLL();
            DataTable dtAllWords = retrieveAllWord.GetAllWords();
            dgViewAllWords.DataSource = dtAllWords;
        }

        private void dgViewAllWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WordBLL updateWord = new WordBLL();
            int columnIndex = dgViewAllWords.CurrentCell.ColumnIndex;
            WordId = int.Parse(dgViewAllWords.CurrentRow.Cells["wordid"].Value.ToString());
            DataTable dtAllWords;
            if (dgViewAllWords.CurrentRow.Cells[columnIndex].Value.ToString() == "Update")
            {
                dtAllWords = updateWord.GetAllWords();
                txtEnglishWord.Text = dtAllWords.Rows[0][1].ToString();
                txtFrenchWord.Text = dtAllWords.Rows[0][2].ToString();
                btnAddNewWord.Text = "Update";
            }
            else if (dgViewAllWords.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    updateWord.DeleteWord();
                    retrieveAllWords();
                    clearControls();
                }
            }
        }

        private void FrmAddWords_Load(object sender, EventArgs e)
        {
            retrieveAllWords();
            selectWordSet();
        }

        private void selectWordSet()
        {
        }
    }
}
