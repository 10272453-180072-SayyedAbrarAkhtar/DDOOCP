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
    public partial class FrmWelcome : FrmTemplate
    {
        private string _currentPlayerName;
        FrmRegister addNewPLayer;


        public FrmWelcome(string CurrentPlayerName)
        {
            InitializeComponent();
            _currentPlayerName = CurrentPlayerName;
        
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            lblwelcomePlayer.Text += _currentPlayerName;
        }

        private void btnRegisterNewPlayer_Click(object sender, EventArgs e)
        {
            addNewPLayer = new FrmRegister();
            this.Hide();
            addNewPLayer.ShowDialog();
            this.Close();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            FrmPlayerSelection selectPlayer = new FrmPlayerSelection(_currentPlayerName);
            this.Hide();
            selectPlayer.ShowDialog();
            this.Close();

        }

        private void btnAddNewWord_Click(object sender, EventArgs e)
        {
            FrmAddWords addWords = new FrmAddWords();
            this.Hide();
            addWords.ShowDialog();
            this.Close();
        }
    }
}
