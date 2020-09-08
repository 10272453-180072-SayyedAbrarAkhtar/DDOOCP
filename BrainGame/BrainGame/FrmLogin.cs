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
    public partial class FrmLogin : FrmTemplate
    {
        FrmRegister registration;
        PlayerBLL player;
        FrmWelcome playerWelcome;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnRegisterNewPlayer_Click(object sender, EventArgs e)
        {
            registration = new FrmRegister();
            this.Hide();
            registration.ShowDialog();
            this.Close();
        }

        private void btnPlayerLogin_Click(object sender, EventArgs e)
        {
            player = new PlayerBLL();
            player.PlayerName = txtPlayerName.Text;
            player.Password = txtPlayerPassword.Text;
            DataTable dtPlayerLoginDetails = player.GetPlayerLoginDetails();
            if (dtPlayerLoginDetails.Rows.Count == 1)
            {

                playerWelcome = new FrmWelcome(txtPlayerName.Text);
                this.Hide();
                playerWelcome.ShowDialog();
                this.Close();
            }
            else
            {
                lblLoginError.Text = "Username or Password did not matched!!";
                lblLoginError.Visible = true;
                return;
            }
        }
    }
}
