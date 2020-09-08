using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainGame.BLL
{
    class WordBLL : BrainGameDatabaseConnection
    {
        private int _wordId;
        private string _englishWord;
        private string _frenchWord;
        string query;
        DataTable dtWords;


        public int WordId
        {
            get
            {
                return _wordId;
            }
            set
            {
                _wordId = value;
            }
        }

        public string EnglishWord
        {
            get
            {
                return _englishWord;
            }
            set
            {
                _englishWord = value;
            }
        }

        public string FrenchWord
        {
            get
            {
                return _frenchWord;
            }
            set
            {
                _frenchWord = value;
            }
        }

        public bool AddNewWords()
        {
            try
            {
                query = $"insert into wordSet(englishWord, frenchWord) values('{_englishWord}', N'{_frenchWord}')";
                manipulate(query);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return false;
            }

        }

        public DataTable GetAllWords()
        {
            try
            {
                query = "select * from wordSet";
                dtWords = retrieve(query);
                return dtWords;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return null;
            }
        }

        public bool UpdateWord()
        {
            try
            {
                query = $"update wordSet set englishWord='{_englishWord}', frenchWord=N'{_frenchWord}' where wordid=" + _wordId;
                manipulate(query);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return false;
            }

        }

        public bool DeleteWord()
        {
            try
            {
                query = "delete from wordSet where wordid=" + _wordId;
                manipulate(query);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return false;
            }
        }


        public bool MatchWord()
        {
            try
            {
                query = $"select englishWord, frenchWord from wordSet where englishWord='{_englishWord}'and frenchWord=N'{_frenchWord}'";
                DataTable dtMatch = retrieve(query);
                if (dtMatch.Rows.Count == 1)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return false;
            }
        }
    }
}
