using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrainGame.BLL;

namespace BrainGame
{
    public partial class FrmScoreBoard : FrmTemplate
    {
        string _player1;
        string _player2;
        public FrmScoreBoard(string player1, string player2)
        {
            _player1 = player1;
            _player2 = player2;
            InitializeComponent();
        }
        PlayerScoreBLL score = new PlayerScoreBLL();
        DataTable dtscore;

        private void btnyes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPlayerSelection select = new FrmPlayerSelection(_player1);
            select.ShowDialog();
            this.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmScoreBoard_Load(object sender, EventArgs e)
        {
            dtscore=score.retrieveScore();
            lblp1.Text = dtscore.Rows[0][1].ToString();
            lblp2.Text = dtscore.Rows[0][2].ToString();
            lblscore1.Text = dtscore.Rows[0][3].ToString();
            lblscore2.Text = dtscore.Rows[0][4].ToString();
            lbltime1.Text = dtscore.Rows[0][5].ToString();
            lbltime2.Text = dtscore.Rows[0][6].ToString();
            lblWinner.Text = "Winner is: " + dtscore.Rows[0][8].ToString();

        }
    }
}
