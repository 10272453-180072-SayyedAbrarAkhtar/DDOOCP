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
    public partial class Game : Form
    {
        PlayerScoreBLL playerResult = new PlayerScoreBLL();
        DataTable dataTableWords = new DataTable();
        WordBLL WordClicked;
        Button btnEnglishWord = new Button();

        int points;
        bool lockEnglishWord = false;
        bool lockFrenchWord = false;
        bool player1 = true;
        bool player2;
        bool status;        
        string EnglishWord, FrenchWord;      
        int player1Score = 0;
        int player2Score = 0;
        int x = 20, y = 20;

        int counterPlayer1Timer = 0;
        int counterPlayer2Timer = 0;
        int counterTotalTimer = 0;

        private string _player1, _player2;
        public Game(string Player1, string Player2)
        {
            _player1 = Player1;
            _player2 = Player2;
            InitializeComponent();
        }

        private void loadPlayers()
        {
            lblPlayer1.Text = _player1;
            lblPlayer2.Text = _player2;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            wordSetGrpBoxDimension();
            loadPlayers();
            WordClicked = new WordBLL();
            dataTableWords = WordClicked.GetAllWords();
            loadEnglishWord();
            loadFrenchWord();
            player1Timer.Start();
            totalTimer.Start();
            

        }

        private void wordSetGrpBoxDimension()
        {
            grpBxEnglishWord.Height = (this.Height - grpBxPlayerDetails.Height) / 2;
            grpBxFrenchWord.Height = (this.Height - grpBxPlayerDetails.Height) / 2;
        }


        private void loadEnglishWord()
        {
            if (CheckWordsLoaded())
            {
                for (int i = 0; i < dataTableWords.Rows.Count; i++)
                {
                    
                    Button button = new Button();
                    button.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.Location = new Point(x, y);
                    button.Size = new Size(130, 60);
                    button.Name = dataTableWords.Rows[i][1].ToString();
                    button.Text = "Guess What??";
                    button.UseVisualStyleBackColor = true;
                    grpBxEnglishWord.Controls.Add(button);

                    x = x + 150;

                    button.Click += (s, e) =>
                    {
                        if (!lockEnglishWord)
                        {
                            button.Text = button.Name;
                            lockEnglishWord = true;
                            EnglishWord = button.Name;
                            btnEnglishWord.Name = button.Name;
                        }
                    };

                    EnglishButtonLocation();
                }
            }
            else
            {
                MessageBox.Show("No any words found. :(");
            }
        }

        private void loadFrenchWord()
        {
            x = 20;
            y = 30;
            if (CheckWordsLoaded())
            {
                for (int i = 0; i< dataTableWords.Rows.Count; i++)
                {

                    Button button = new Button();
                    button.Font = new Font("Microsoft Himalaya", 20.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.Location = new Point(x, y);
                    button.Size = new Size(130, 60);
                    button.Name = dataTableWords.Rows[i][2].ToString();
                    button.Text = "Guess what!!";
                    button.UseVisualStyleBackColor = true;
                    grpBxFrenchWord.Controls.Add(button);

                    x = x + 150;

                    button.Click += (s, e) =>
                    {
                        if (!lockEnglishWord)
                        { 
                            MessageBox.Show("Please select nepali word first");
                            return;
                        }
                        if(!lockFrenchWord)
                        {
                            button.Text = button.Name;
                            lockFrenchWord = true;
                            FrenchWord = button.Name;
                            MatchEnglishAndFrench();
                            points += 1;
                            playerScore();
                            if (status)
                            {                              
                                button.Text = button.Name;
                                button.Enabled = false;
                                setDisable();
}
                            else
                            {
                                setEnglishDisable();
                                button.Text = "Guess what??";
                            }
                            changePlayerTurn();
                        }
                       
                    };

                    FrenchButtonLocation();
                }
            }

            

            else
            {
                MessageBox.Show("No any words found. :(");
            }
        }




        private Boolean CheckWordsLoaded()
        {
            Boolean flag;
            if (dataTableWords.Rows.Count > 0)
            {
                flag = true;
            }
            else
            {              
                flag = false;
            }
            return flag;
        }
        private void EnglishButtonLocation()
        {
            if (x >= grpBxEnglishWord.Width - 120)
            {
                x = 20;
                y += 80;
            }
        }
        private void FrenchButtonLocation()
        {
            if (x >= grpBxFrenchWord.Width - 120)
            {
                x = 20;
                y += 80;
            }
        }



        private void MatchEnglishAndFrench()
        {
            WordClicked = new WordBLL();
            WordClicked.EnglishWord = EnglishWord;
            WordClicked.FrenchWord = FrenchWord;
            Boolean Match = WordClicked.MatchWord();
            if (Match)
            {
                status = true;
                if (player1)
                {
                    player1Score += 1;
                    lblPlayer1Score.Text = player1Score.ToString();
                }
                else
                {
                    player2Score += 1;
                    lblPlayer2Score.Text = player2Score.ToString();
                }
            }
            playerScore();
        }



        private void changePlayerTurn()
        {
            if (player1)
            {
                player1Timer.Start();
                player2Timer.Stop();
                player2 = true;
                player1 = false;
            }
            else
            {
                player1Timer.Stop();
                player2Timer.Start();
                player1 = true;
                player2 = false;
            }
        }



        private void setDisable()
        {
            foreach (Button btn in grpBxEnglishWord.Controls)
            {
                if (btnEnglishWord.Name == btn.Name)
                {
                    btn.Enabled = false;
                    btn.Text = "Guess What??";
                    lockFrenchWord = false;
                    lockEnglishWord = false;
                }
            }
        }

        private void player1Timer_Tick(object sender, EventArgs e)
        {
            counterPlayer1Timer += 1;
            lblPlayer1Timer.Text = counterPlayer1Timer.ToString();

        }

        private void player2Timer_Tick(object sender, EventArgs e)
        {
            counterPlayer2Timer += 1;
            lblPlayer2Timer.Text = counterPlayer2Timer.ToString();
        }

        private void totalTimer_Tick(object sender, EventArgs e)
        {
            counterTotalTimer += 1;
            lblOverallTotlTime.Text = counterTotalTimer.ToString();
        }

        private void setEnglishDisable()
        {
            foreach (Button btn in grpBxEnglishWord.Controls)
            {
                if (btnEnglishWord.Name == btn.Name)
                {
                    btn.Text = "Guess what??";
                    lockFrenchWord = false;
                    lockEnglishWord = false;
                }
            }
        }

        private void playerScore()
        {
            if (points == dataTableWords.Rows.Count)
            {
                string winner;
                playerResult.Player1 = lblPlayer1.Text;
                playerResult.Player2 = lblPlayer2.Text;
                playerResult.Player1score = lblPlayer1Score.Text;
                playerResult.Player2score = lblPlayer2Score.Text;
                playerResult.Player1time = lblPlayer1Timer.Text;
                playerResult.Player2time = lblPlayer2Timer.Text;
                playerResult.TotalTime = lblOverallTotlTime.Text;
                if (int.Parse(lblPlayer1Score.Text) > int.Parse(lblPlayer2Score.Text))
                {
                    winner = lblPlayer1.Text;
                }
                else if (int.Parse(lblPlayer1Score.Text) < int.Parse(lblPlayer2Score.Text))
                {
                    winner = lblPlayer2.Text;


                }
                else
                {
                    winner = "draw";
                }
                playerResult.Winner = winner;
                playerResult.insertdata();
                this.Hide();
                FrmScoreBoard score  = new FrmScoreBoard(lblPlayer1.Text, lblPlayer2.Text);
                score.ShowDialog();
                this.Close();
            }
        }


    }
}
