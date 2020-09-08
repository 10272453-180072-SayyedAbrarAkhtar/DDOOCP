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
    public partial class FrmRegister : FrmTemplate
    {
        PlayerBLL registerPlayer, playerdata, manipulatePlayer;
        DataTable dataTablePlayerData;
        int currentPlayerId;
        public FrmRegister()
        {
            InitializeComponent();
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {

            registerPlayer = new PlayerBLL();
            registerPlayer.FirstName = txtFirstName.Text;
            registerPlayer.LastName = txtLastName.Text;
            registerPlayer.PlayerName = txtPlayerName.Text;
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                registerPlayer.Password = txtPassword.Text;
            }
            else
            {
                lblErrorMessage.Text = "Your password and Confirm Password didnot matched!!!";
                lblErrorMessage.Visible = true;
                txtConfirmPassword.ForeColor = Color.Red;
                return;
            }
            txtConfirmPassword.ForeColor = Color.Black;
            lblErrorMessage.Visible = false;

            registerPlayer.AddPlayerDetails();
            MessageBox.Show("Player added successfully !!");
            retrieveCurrentPlayer();
            clearControls();

        }

        private void clearControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPlayerName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFirstName.Focus();
        }


        private void dgViewPlayerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manipulatePlayer = new PlayerBLL();
            int columnIndex = dgViewPlayerDetails.CurrentCell.ColumnIndex;
            currentPlayerId = int.Parse(dgViewPlayerDetails.CurrentRow.Cells["playerid"].Value.ToString());
            if (dgViewPlayerDetails.CurrentRow.Cells[columnIndex].Value.ToString() == "Update")
            {
                dataTablePlayerData = manipulatePlayer.GetPlayerDetails();
                txtFirstName.Text = dataTablePlayerData.Rows[0][1].ToString();
                txtLastName.Text = dataTablePlayerData.Rows[0][2].ToString();
                txtPlayerName.Text = dataTablePlayerData.Rows[0][3].ToString();
                txtPassword.Text = dataTablePlayerData.Rows[0][4].ToString();
                btnRegister.Text = "Update";
            }
            else if (dgViewPlayerDetails.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    manipulatePlayer.CurrentPlayerId = currentPlayerId;
                    manipulatePlayer.DeletePlayer();
                    retrieveCurrentPlayer();
                    clearControls();
                }
            }
        }

        public void retrieveCurrentPlayer()
        {
            playerdata = new PlayerBLL();
            dataTablePlayerData = playerdata.GetCurrentPlayerDetails();
            dgViewPlayerDetails.DataSource = dataTablePlayerData;
        }
    }
}
