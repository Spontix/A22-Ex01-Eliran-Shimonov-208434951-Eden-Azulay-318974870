using System;

namespace GameLogic
{
    public class FourInARow
    {
        private const int k_FourInRowFlush = 4;
        private const int k_MinimumStepsToWin = 7;
        private readonly int r_BoardWidth;
        private readonly int r_BoardHeight;
        private readonly Player r_Player1;
        private readonly Player r_Player2;
        private readonly char[,] r_Board;
        private bool m_GameOverByWin;
        private Point m_LastMark;
        private int m_TurnCount;

        public FourInARow(int i_Width, int i_Height, bool i_IsSecondPlayerHuman)
        {
            m_GameOverByWin = false;
            r_Board = new char[i_Height, i_Width];
            m_TurnCount = 0;
            r_BoardWidth = i_Width;
            r_BoardHeight = i_Height;
            ClearBoard();
            this.r_Player1 = new Player('X', true);
            this.r_Player2 = new Player('O', i_IsSecondPlayerHuman);
        }

        public void ClearBoard()
        {
            for (int i = 0; i < r_BoardHeight; i++)
            {
                for (int j = 0; j < r_BoardWidth; j++)
                {
                    r_Board[i, j] = ' ';
                }
            }
        }

        public int BoardWidth
        {
            get
            {
                return r_BoardWidth;
            }
        }

        public int BoardHeight
        {
            get
            {
                return r_BoardHeight;
            }
        }

        public char[,] Board
        {
            get
            {
                return r_Board;
            }
        }

        public bool GameOverByWin
        {
            get
            {
                return m_GameOverByWin;
            }
            set
            {
                m_GameOverByWin = value;
            }
        }

        public int TurnCount
        {
            set
            {
                m_TurnCount = value;
            }
        }

        public Player Player2
        {
            get
            {
                return r_Player2;
            }
        }

        public bool InsertChipOfPlayer(int i_XCoordinateValue, out int o_Row)
        {
            bool foundPlace = false;
            int i;

            for (i = r_BoardHeight - 1; i > (-1) && !foundPlace; i--)
            {
                if (r_Board[i, i_XCoordinateValue - 1] == ' ')
                {
                    m_LastMark.X = i_XCoordinateValue - 1;
                    m_LastMark.Y = i;
                    r_Board[i, i_XCoordinateValue - 1] = GetCurrentPlayer().Mark;
                    foundPlace = true;
                    m_TurnCount++;
                }
            }

            o_Row = i;

            return foundPlace;
        }

        public int PlayComputerTurn(out int o_Col)
        {
            Random randomCol = new Random();
            int colToPutIn = randomCol.Next(1, r_BoardWidth + 1);
            int row;

            while (!InsertChipOfPlayer(colToPutIn, out row))
            {
                colToPutIn = randomCol.Next(1, r_BoardWidth + 1);
            }

            o_Col = colToPutIn;

            return row;
        }

        public bool GameTie()
        {
            bool isTie = false;

            if (m_TurnCount == r_Board.Length)
            {
                isTie = true;
                m_TurnCount = 0;
                ClearBoard();
            }

            return isTie;
        }

        public Player GetCurrentPlayer()
        {
            return m_TurnCount % 2 == 0 ? r_Player1 : r_Player2;
        }

        public Player GetPreviousPlayer()
        {
            return m_TurnCount % 2 != 0 ? r_Player1 : r_Player2;
        }

        public bool CheckIfPlayerWon()
        {
            bool isWin = false;

            if (m_TurnCount >= k_MinimumStepsToWin) //7 steps at least to win for the first time
            {
                m_GameOverByWin = checkIfPlayerWonInRow() || checkIfPlayerWonInCol() || checkIfPlayerWonInDiagonal();
            }

            if (m_GameOverByWin)
            {
                isWin = m_GameOverByWin;
                m_GameOverByWin = false;
                ClearBoard();
            }

            return isWin;
        }

        private bool checkIfPlayerWonInCol()
        {
            bool isPlayerWonInCol = false;
            char markOfPlayer = GetPreviousPlayer().Mark;
            int markCounterFlush = 0;

            for (int i = 0; ((i < r_BoardHeight) && (!m_GameOverByWin)); i++)
            {
                if (r_Board[i, m_LastMark.X] != markOfPlayer)
                {
                    markCounterFlush = 0;
                }
                else
                {
                    markCounterFlush++;
                    if (markCounterFlush == k_FourInRowFlush)
                    {
                        isPlayerWonInCol = true;
                    }
                }
            }

            return isPlayerWonInCol;
        }

        private bool checkIfPlayerWonInRow()
        {
            bool isPlayerWonInRow = false;
            char markOfPlayer = GetPreviousPlayer().Mark;
            int markCounterFlush = 0;

            for (int i = 0; ((i < r_BoardWidth) && (!m_GameOverByWin)); i++)
            {
                if (r_Board[m_LastMark.Y, i] != markOfPlayer)
                {
                    markCounterFlush = 0;
                }
                else
                {
                    markCounterFlush++;
                    if (markCounterFlush == k_FourInRowFlush)
                    {
                        isPlayerWonInRow = true;
                        m_GameOverByWin = true;
                    }
                }
            }

            return isPlayerWonInRow;
        }

        private bool checkIfPlayerWonInDiagonal()
        {
            return check1StDiagonal() || check2NdDiagonal();
        }

        private bool check1StDiagonal()
        {
            int markCounterFlush = 0;
            int col = m_LastMark.X;
            int row = m_LastMark.Y;

            for (int i = 1; i < k_FourInRowFlush && (row != r_BoardHeight - 1 && col != 0); i++)
            {
                col--;
                row++;
            }

            while (row >= 0 && col < r_BoardWidth && markCounterFlush != k_FourInRowFlush)
            {
                markCounterFlush++;

                if (r_Board[row, col] != GetPreviousPlayer().Mark)
                {
                    markCounterFlush = 0;
                }

                col++;
                row--;
            }

            return markCounterFlush == k_FourInRowFlush;
        }

        private bool check2NdDiagonal()
        {
            int markCounterFlush = 0;
            int col = m_LastMark.X;
            int row = m_LastMark.Y;

            for (int i = 1; i < k_FourInRowFlush && (row != 0 && col != 0); i++)
            {
                col--;
                row--;
            }

            while (col < r_BoardWidth && row < r_BoardHeight && markCounterFlush != k_FourInRowFlush)
            {
                markCounterFlush++;
                if (r_Board[row, col] != GetPreviousPlayer().Mark)
                {
                    markCounterFlush = 0;

                }

                col++;
                row++;
            }

            return markCounterFlush == k_FourInRowFlush;
        }
    }


}
