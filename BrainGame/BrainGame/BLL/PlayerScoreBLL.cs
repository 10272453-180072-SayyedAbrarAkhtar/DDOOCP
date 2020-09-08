using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrainGame.BLL;

namespace BrainGame.BLL
{
    class PlayerScoreBLL
    {
        private string _player1, _player2, _player1score, _player2score, _player1time, _player2time, _totaltime;
        private string _winner;
        BrainGameDatabaseConnection dbcon;
        DataTable dt;
        string playr1, playr2;
        public string Player1
        {
            get
            {
                return _player1;
            }
            set
            {
                _player1 = value;
            }
        }

        public string Player2
        {
            get
            {
                return _player2;
            }
            set
            {
                _player2 = value;
            }
        }

        public string Player1score
        {
            get
            {
                return _player1score;
            }
            set
            {
                _player1score = value;
            }
        }


        public string Player2score
        {
            get
            {
                return _player2score;
            }
            set
            {
                _player2score = value;
            }
        }

        public string Player1time
        {
            get
            {
                return _player1time;
            }
            set
            {
                _player1time = value;
            }
        }


        public string Player2time
        {
            get
            {
                return _player2time;
            }
            set
            {
                _player2time = value;
            }
        }


        public string TotalTime
        {
            get
            {
                return _totaltime;
            }
            set
            {
                _totaltime = value;
            }
        }

        public string Winner
        {
            get
            {
                return _winner;
            }
            set
            {
                _winner = value;
            }
        }

        
       public DataTable retrieveScore()
        {
            try
            {
                DataTable dtScore;
                dbcon = new BrainGameDatabaseConnection();
                string query;
                query = "select * from record order by recordid desc";
                dtScore = dbcon.retrieve(query);
                return dtScore;

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return null;
            }

        }

        public void insertdata()
        {
            try
            {
               
                dbcon = new BrainGameDatabaseConnection();
                string query;
                query = "insert into record(player1, player2, player1score, player2score, player1time, player2time, totaltime, winner) values('" + _player1 +
                "','" + _player2 +
                "'," + _player1score +
                "," + _player2score +
                ",'" + _player1time +
                "','" + _player2time +
                "','" + _totaltime +
                "','" + _winner + "');";
                dbcon.manipulate(query);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
            }

        }

    }
}
