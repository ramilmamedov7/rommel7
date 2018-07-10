using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("By Ramil Mamedov", "Tic Tac Toe About");
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NewGame(object sender, EventArgs e)
        {
            this.Hide();
            var Game = new Game();
            Game.ShowDialog();
        }
        private void Rules(object sender, EventArgs e)
        {
            MessageBox.Show("Player one = 'X'\nPlayer two = 'O'", "Tic Tac Toe Rules");
        }
        //Aplication Menu Stuff

        int Player1Score = 0, Player2Score = 0;
        //Score

        static String FirstPlayer, SecondPlayer;
        private void Form1Load(object sender, EventArgs e)
        {
            var Game = new Form1();
            Game.ShowDialog();
            label2.Text = FirstPlayer;
            label3.Text = SecondPlayer;
        }
        public static void SetPlayerNames(String name1, String name2)
        {
            FirstPlayer = name1;
            SecondPlayer = name2;
        }
        //Set Name to Player

        string turn = "X";
        private void ChangeTurn()
        {
            string TurnResult = turn == "X" ? (this.turn = "0") : (this.turn = "X");
        }
        //Set Turn

        private void Display()
        {
            string DisplayResult = turn == "X" ? (displayturn.Text = FirstPlayer + "'s") : (displayturn.Text = SecondPlayer + "'s");
        }
        //Display Turn

        private void AllBtnClick(object sender, EventArgs e)
        {
            var Button = sender as Button;
            if (Button.Text == string.Empty)
            {
                Button.Text = this.turn;
                this.ChangeTurn();
            }
            Display();
            Check();
        }
        // Click event of all 9 buttons

        private void Check()
        {
            if (Btn1.Text != string.Empty && Btn1.Text == Btn2.Text && Btn2.Text == Btn3.Text)
            {
                Display();
                ChangeTurn();
                Btn1.BackColor = Color.Green;
                Btn1.ForeColor = Color.White;
                Btn2.BackColor = Color.Green;
                Btn2.ForeColor = Color.White;
                Btn3.BackColor = Color.Green;
                Btn3.ForeColor = Color.White;
                if (Btn1.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn4.Text != string.Empty && Btn4.Text == Btn5.Text && Btn5.Text == Btn6.Text)
            {
                Display();
                ChangeTurn();
                Btn4.BackColor = Color.Green;
                Btn4.ForeColor = Color.White;
                Btn5.BackColor = Color.Green;
                Btn5.ForeColor = Color.White;
                Btn6.BackColor = Color.Green;
                Btn6.ForeColor = Color.White;
                if (Btn4.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn7.Text != string.Empty && Btn7.Text == Btn8.Text && Btn8.Text == Btn9.Text)
            {
                Display();
                ChangeTurn();
                Btn7.BackColor = Color.Green;
                Btn7.ForeColor = Color.White;
                Btn8.BackColor = Color.Green;
                Btn8.ForeColor = Color.White;
                Btn9.BackColor = Color.Green;
                Btn9.ForeColor = Color.White;
                if (Btn7.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn1.Text != string.Empty && Btn1.Text == Btn4.Text && Btn4.Text == Btn7.Text)
            {
                Display();
                ChangeTurn();
                Btn1.BackColor = Color.Green;
                Btn1.ForeColor = Color.White;
                Btn4.BackColor = Color.Green;
                Btn4.ForeColor = Color.White;
                Btn7.BackColor = Color.Green;
                Btn7.ForeColor = Color.White;
                if (Btn1.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn2.Text != string.Empty && Btn2.Text == Btn5.Text && Btn5.Text == Btn8.Text)
            {
                Display();
                ChangeTurn();
                Btn2.BackColor = Color.Green;
                Btn2.ForeColor = Color.White;
                Btn5.BackColor = Color.Green;
                Btn5.ForeColor = Color.White;
                Btn8.BackColor = Color.Green;
                Btn8.ForeColor = Color.White;
                if (Btn2.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn3.Text != string.Empty && Btn3.Text == Btn6.Text && Btn6.Text == Btn9.Text)
            {
                Display();
                ChangeTurn();
                Btn3.BackColor = Color.Green;
                Btn3.ForeColor = Color.White;
                Btn6.BackColor = Color.Green;
                Btn6.ForeColor = Color.White;
                Btn9.BackColor = Color.Green;
                Btn9.ForeColor = Color.White;
                if (Btn3.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn1.Text != string.Empty && Btn1.Text == Btn5.Text && Btn5.Text == Btn9.Text)
            {
                Display();
                ChangeTurn();
                Btn1.BackColor = Color.Green;
                Btn1.ForeColor = Color.White;
                Btn5.BackColor = Color.Green;
                Btn5.ForeColor = Color.White;
                Btn9.BackColor = Color.Green;
                Btn9.ForeColor = Color.White;
                if (Btn1.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
            if (Btn3.Text != string.Empty && Btn3.Text == Btn5.Text && Btn5.Text == Btn7.Text)
            {
                Display();
                ChangeTurn();
                Btn3.BackColor = Color.Green;
                Btn3.ForeColor = Color.White;
                Btn5.BackColor = Color.Green;
                Btn5.ForeColor = Color.White;
                Btn7.BackColor = Color.Green;
                Btn7.ForeColor = Color.White;
                if (Btn3.Text == "X")
                {
                    MessageBox.Show(FirstPlayer + " wins!");
                    Player1Score++;
                    PlayerOne.Text = Player1Score.ToString();
                }
                else
                {
                    MessageBox.Show(SecondPlayer + " wins!");
                    Player2Score++;
                    PlayerTwo.Text = Player2Score.ToString();
                }
                ClearGame();
            }
        }
        // Check for winner

        public void ClearGame()
        {
            displayturn.Text = "";
            turn = "X";
            Btn1.Text = "";
            Btn2.Text = "";
            Btn3.Text = "";
            Btn4.Text = "";
            Btn5.Text = "";
            Btn6.Text = "";
            Btn7.Text = "";
            Btn8.Text = "";
            Btn9.Text = "";
            Btn1.BackColor = Color.Empty;
            Btn1.ForeColor = Color.Black;
            Btn1.UseVisualStyleBackColor = true;
            Btn2.BackColor = Color.Empty;
            Btn2.ForeColor = Color.Black;
            Btn2.UseVisualStyleBackColor = true;
            Btn3.BackColor = Color.Empty;
            Btn3.ForeColor = Color.Black;
            Btn3.UseVisualStyleBackColor = true;
            Btn4.BackColor = Color.Empty;
            Btn4.ForeColor = Color.Black;
            Btn4.UseVisualStyleBackColor = true;
            Btn5.BackColor = Color.Empty;
            Btn5.ForeColor = Color.Black;
            Btn5.UseVisualStyleBackColor = true;
            Btn6.BackColor = Color.Empty;
            Btn6.ForeColor = Color.Black;
            Btn6.UseVisualStyleBackColor = true;
            Btn7.BackColor = Color.Empty;
            Btn7.ForeColor = Color.Black;
            Btn7.UseVisualStyleBackColor = true;
            Btn8.BackColor = Color.Empty;
            Btn8.ForeColor = Color.Black;
            Btn8.UseVisualStyleBackColor = true;
            Btn9.BackColor = Color.Empty;
            Btn9.ForeColor = Color.Black;
            Btn9.UseVisualStyleBackColor = true;
        }
        // Clear Game

        private void PlayAgainClick(object sender, EventArgs e)
        {
            ClearGame();
        }
        //New Game

        private void ResetClick(object sender, EventArgs e)
        {
            PlayerOne.Text = "";
            PlayerTwo.Text = "";
            Player1Score = 0;
            Player2Score = 0;
            ClearGame();
        }
        //Reset All Scores
    }
}
