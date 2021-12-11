using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using GameLogic;

namespace DesktopApplication
{
    internal partial class FormBoard : Form
    {
        private readonly Button[][] m_ButtonsBoard;
        private readonly int r_Rows;
        private readonly int r_Cols;
        private Label m_Player1 = new Label();
        private Label m_Computer = new Label();
        private FourInARow m_GameRound;

        public FormBoard(int i_RowsSize, int i_ColsSize, string i_Player1, string i_Player2)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            m_ButtonsBoard = new Button[i_RowsSize + 1][];
            for (int i = 0; i < i_RowsSize + 1; i++)
            {
                m_ButtonsBoard[i] = new Button[i_ColsSize];
            }

            r_Rows = i_RowsSize + 1;
            r_Cols = i_ColsSize;
            m_GameRound = new FourInARow(i_ColsSize, i_RowsSize, i_Player2 == "[Computer]" ? false : true);
            m_Player1.Text = string.Format("{0} : 0", i_Player1);
            m_Computer.Text = string.Format("{0} : 0", i_Player2);
        }

        public int Rows
        {
            get
            {
                return r_Rows;
            }
        }

        public int Cols
        {
            get
            {
                return r_Cols;
            }
        }

        public Button[][] ButtonsBoard
        {
            get
            {
                return m_ButtonsBoard;
            }
        }

        private void createBoard()
        {

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    initializeComponent(col, row);
                }
            }

            m_Player1.Location = new Point(35, 15 + 29 * Rows);
            m_Computer.Location = new Point(13 + 43 * (Cols - 2), 15 + 29 * Rows);
            m_Computer.AutoSize = true;
            m_Player1.AutoSize = true;
            this.Size = new Size(43 * (Cols + 1), 15 + 29 * (Rows) + 60);
            this.Controls.Add(m_Player1);
            this.Controls.Add(m_Computer);
            this.Text = "4 in a Raw!!";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
        }

        private void initializeComponent(int i_Col, int i_Row)
        {
            Button button = new Button();
            button.Location = new Point(13 + i_Col * 43, 15 + i_Row * 29);
            button.Size = new Size(37, 23);
            if (i_Row == 0)
            {
                button.Text = (i_Col + 1).ToString();
            }

            this.Controls.Add(button);
            ButtonsBoard[i_Row][i_Col] = button;
        }

        public void RunGame()
        {
            createBoard();
            eventAdder();
            this.ShowDialog();
        }

        private void eventAdder()
        {
            foreach (Button button in ButtonsBoard[0])
            {
                button.Click += buttonColNumber_Click;
            }
        }

        private void buttonColNumber_Click(object sender, EventArgs e)
        {
            int colToInsert = int.Parse((sender as Button).Text);
            int row;

            m_GameRound.InsertChipOfPlayer(colToInsert, out row);
            ButtonsBoard[row + 2][colToInsert - 1].Text = m_GameRound.Board[row + 1, colToInsert - 1].ToString();
            if (row + 2 == 1)
            {
                (sender as Button).Enabled = false;
            }

            if (!checkIfGameEnd() && !m_GameRound.Player2.IsHuman)
            {
                row = m_GameRound.PlayComputerTurn(out int col);
                ButtonsBoard[row + 2][col - 1].Text = m_GameRound.Board[row + 1, col - 1].ToString();
                if (row + 2 == 1)
                {
                    ButtonsBoard[0][col - 1].Enabled = false;
                }

                checkIfGameEnd();
            }
        }

        private bool checkIfGameEnd()
        {
            bool endGame = false;
            string playersName = null;

            if (m_GameRound.CheckIfPlayerWon())
            {
                endGame = true;
                m_GameRound.GetPreviousPlayer().Points++;
                if (m_GameRound.GetPreviousPlayer() == m_GameRound.Player2)
                {
                    changePointsOfPlayer(m_Computer, out playersName);
                }
                else
                {
                    changePointsOfPlayer(m_Player1, out playersName);
                }
                showMessage("Win", playersName);
            }
            else if (m_GameRound.GameTie())
            {
                endGame = true;
                showMessage("Tie");
            }

            return endGame;
        }

        private void changePointsOfPlayer(Label i_Player, out string io_PlayersName)
        {
            int index = i_Player.Text.IndexOf(':');
            io_PlayersName = i_Player.Text.Remove(index);
            i_Player.Text = i_Player.Text.Remove(index + 1);
            i_Player.Text = i_Player.Text.Insert(index + 1, m_GameRound.GetPreviousPlayer().Points.ToString());
            m_GameRound.TurnCount = 0;
        }

        private void showMessage(string i_Message, string i_PlayersName = "")
        {
            if (MessageBox.Show(string.Format(@"{0} {1}!!!
Another Round?", i_PlayersName, i_Message),
                "A " + i_Message,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) != DialogResult.No)
            {
                InitializeButtons();
            }
            else
            {
                this.Close();
            }
        }

        private void InitializeButtons()
        {
            for (int row = 0; row < Rows; row++)
            {
                foreach (Button button in ButtonsBoard[row])
                {
                    if (row == 0)
                    {
                        button.Enabled = true;
                    }
                    else
                    {
                        button.Text = "";
                    }
                }
            }
        }

    }
}
