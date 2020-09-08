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
    public partial class FrmPlayerSelection : FrmTemplate
    {
        private string _firstPlayer;
        string _secondPlayer;
        PlayerBLL allPlayer;
        DataTable dataTableAllPlayers;
        RadioButton rdoAllPlayer;

        public FrmPlayerSelection(string FirstPLayer)
        {
            InitializeComponent();
            _firstPlayer = FirstPLayer;
        }

        private void PlayerSelection_Load(object sender, EventArgs e)
        {
            playerWelcome();
            generateAllPLayer();
        }

        private void playerWelcome()
        {
            lblGreetings.Text += _firstPlayer;
        }

        private void generateAllPLayer()
        {
            allPlayer = new PlayerBLL();
            dataTableAllPlayers=allPlayer.GetPlayerDetails();
           
            int x = 20;
            int y = 30;
           
            for (int i = 0; i < dataTableAllPlayers.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new System.Drawing.Size(100, 50);
                btn.Text = dataTableAllPlayers.Rows[i][1].ToString();
                
                btn.UseVisualStyleBackColor = true;
                grpBoxPlayerSelection.Controls.Add(btn);
                
                
                y += 60;
                if (y > 150)
                {
                    x += 120;
                    y = 30;
                }

                btn.Click += (s, e) => {
                    Game newGame = new Game(_firstPlayer, btn.Text);
                    this.Hide();
                    newGame.ShowDialog();
                    this.Close();
                };
            }
        }

        //private void playerselection()
        //{
        //    foreach (RadioButton rdoAllPlayer in grpBoxPlayerSelection.Controls)
        //    {
        //        if (rdoAllPlayer.Checked)
        //        {
        //            _secondPlayer = rdoAllPlayer.Text;
        //        }
        //    }
        //}

        //private void btnStartGame_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("" + _secondPlayer);
        //    Game newGame = new Game(_firstPlayer, _secondPlayer);
        //    this.Hide();
        //    newGame.ShowDialog();
        //    this.Close();
        //}
    }
}
