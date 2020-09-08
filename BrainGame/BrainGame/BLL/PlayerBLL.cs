using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainGame.BLL
{
    class PlayerBLL : BrainGameDatabaseConnection
    {
        private string _firstName, _lastName, _playerName, _password;
        private string query;
        private int _currentPlayerId;
        DataTable dtPlayerDetails, dtPlayerLoginDetails;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public int CurrentPlayerId
        {
            get
            {
                return _currentPlayerId;
            }
            set
            {
                _currentPlayerId = value;
            }
        }


        public bool AddPlayerDetails()
        {
            try
            {
                query = $"insert into playerDetails (firstname, lastname, playerName, password) values('{_firstName}', '{_lastName}', '{_playerName}', '{_password}') ";
                manipulate(query);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return false;
            }

        }

        public DataTable GetCurrentPlayerDetails()
        {
            try
            {
                query = "select playerid, firstname, lastname, playerName, password from playerDetails where playerid=(select MAX(playerid) from playerDetails)";
                dtPlayerDetails = retrieve(query);
                return dtPlayerDetails;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return null;
            }
        }


        public DataTable GetPlayerDetails()
        {
            try
            {
                query = "select playerid, firstname, lastname, playerName, password from playerDetails order by playerid desc";
                dtPlayerDetails = retrieve(query);
                return dtPlayerDetails;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return null;
            }
        }

        public DataTable GetPlayerLoginDetails()
        {
            try
            {
                query = $"select playername, password from playerDetails where playername='{_playerName}' and password='{_password}'";
                dtPlayerLoginDetails = retrieve(query);
                return dtPlayerLoginDetails;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return null;
            }
        }
        public bool DeletePlayer()
        {
            try
            {
                query = "delete from playerDetails where playerid=" + _currentPlayerId;
                manipulate(query);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return false;
            }
        }
    }
}
