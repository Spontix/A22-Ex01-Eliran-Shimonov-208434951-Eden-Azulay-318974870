using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using GameLogic;

namespace DesktopApplication
{
    public partial class FormGame : Form
    {
        private FormBoard m_FormBoard;
        private Label m_Players;
        private Label m_Player1;
        private CheckBox m_Player2;
        private TextBox m_TBPlayer2;
        private TextBox m_TBPlayer1;
        private Label m_BoardSize;
        private Label m_Rows;
        private NumericUpDown m_NUDRows;
        private Label m_Cols;
        private NumericUpDown m_NUDCols;
        private Button m_Start;

        private void initializeComponent()
        {
            this.m_Players = new Label();
            this.m_Player1 = new Label();
            this.m_Player2 = new CheckBox();
            this.m_TBPlayer2 = new TextBox();
            this.m_TBPlayer1 = new TextBox();
            this.m_BoardSize = new Label();
            this.m_Rows = new Label();
            this.m_NUDRows = new NumericUpDown();
            this.m_Cols = new Label();
            this.m_NUDCols = new NumericUpDown();
            this.m_Start = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_NUDRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NUDCols)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Players
            // 
            this.m_Players.AutoSize = true;
            this.m_Players.Location = new Point(13, 13);
            this.m_Players.Name = "m_Players";
            this.m_Players.Size = new Size(59, 17);
            this.m_Players.TabIndex = 0;
            this.m_Players.Text = "Players:";
            // 
            // m_Player1
            // 
            this.m_Player1.AutoSize = true;
            this.m_Player1.Location = new Point(32, 44);
            this.m_Player1.Name = "m_Player1";
            this.m_Player1.Size = new Size(64, 17);
            this.m_Player1.TabIndex = 1;
            this.m_Player1.Text = "Player 1:";
            // 
            // m_Player2
            // 
            this.m_Player2.AutoSize = true;
            this.m_Player2.Location = new Point(35, 78);
            this.m_Player2.Name = "m_Player2";
            this.m_Player2.Size = new Size(86, 21);
            this.m_Player2.TabIndex = 2;
            this.m_Player2.Text = "Player 2:";
            this.m_Player2.UseVisualStyleBackColor = true;
            m_Player2.Click += new EventHandler(checkBoxPlayer2_Click);
            // 
            // m_TBPlayer2
            // 
            this.m_TBPlayer2.Enabled = false;
            this.m_TBPlayer2.AutoSize = true;
            this.m_TBPlayer2.Location = new Point(128, 78);
            this.m_TBPlayer2.Name = "m_TBPlayer2";
            this.m_TBPlayer2.Size = new Size(120, 22);
            this.m_TBPlayer2.TabIndex = 3;
            this.m_TBPlayer2.Text = "[Computer]";
            // 
            // m_TBPlayer1
            // 
            this.m_TBPlayer2.AutoSize = true;
            this.m_TBPlayer1.Location = new Point(128, 44);
            this.m_TBPlayer1.Size = new Size(120, 22);
            this.m_TBPlayer1.TabIndex = 4;
            // 
            // m_BoardSize
            // 
            this.m_BoardSize.AutoSize = true;
            this.m_BoardSize.Location = new Point(16, 140);
            this.m_BoardSize.Name = "m_BoardSize";
            this.m_BoardSize.Size = new Size(77, 17);
            this.m_BoardSize.TabIndex = 5;
            this.m_BoardSize.Text = "Board Size";
            // 
            // m_Rows
            // 
            this.m_Rows.AutoSize = true;
            this.m_Rows.Location = new Point(35, 173);
            this.m_Rows.Name = "m_Rows";
            this.m_Rows.Size = new Size(46, 17);
            this.m_Rows.TabIndex = 6;
            this.m_Rows.Text = "Rows:";
            // 
            // m_NUDRows
            // 
            this.m_NUDRows.Location = new Point(88, 173);
            this.m_NUDRows.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.m_NUDRows.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            this.m_NUDRows.Name = "m_NUDRows";
            this.m_NUDRows.Size = new Size(45, 22);
            this.m_NUDRows.TabIndex = 7;
            this.m_NUDRows.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // m_Cols
            // 
            this.m_Cols.AutoSize = true;
            this.m_Cols.Location = new Point(159, 173);
            this.m_Cols.Name = "m_Cols";
            this.m_Cols.Size = new Size(39, 17);
            this.m_Cols.TabIndex = 8;
            this.m_Cols.Text = "Cols:";
            // 
            // m_NUDCols
            // 
            this.m_NUDCols.Location = new System.Drawing.Point(205, 172);
            this.m_NUDCols.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.m_NUDCols.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            this.m_NUDCols.Name = "m_NUDCols";
            this.m_NUDCols.Size = new System.Drawing.Size(43, 22);
            this.m_NUDCols.TabIndex = 9;
            this.m_NUDCols.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // m_Start
            // 
            this.m_Start.Location = new Point(19, 218);
            this.m_Start.Name = "m_Start";
            this.m_Start.Size = new Size(229, 23);
            this.m_Start.TabIndex = 10;
            this.m_Start.Text = "Start!";
            this.m_Start.UseVisualStyleBackColor = true;
            this.m_Start.Click += new EventHandler(this.buttonStart_Click);
            // 
            // FormGame
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(271, 260);
            this.Controls.Add(this.m_Start);
            this.Controls.Add(this.m_NUDCols);
            this.Controls.Add(this.m_Cols);
            this.Controls.Add(this.m_NUDRows);
            this.Controls.Add(this.m_Rows);
            this.Controls.Add(this.m_BoardSize);
            this.Controls.Add(this.m_TBPlayer1);
            this.Controls.Add(this.m_TBPlayer2);
            this.Controls.Add(this.m_Player2);
            this.Controls.Add(this.m_Player1);
            this.Controls.Add(this.m_Players);
            this.Name = "FormGame";
            this.Tag = "";
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.m_NUDRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NUDCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private bool checkTextValidity(string m_Text)
        {
            int index = 0;

            while (index < m_Text.Length && char.IsLetter(m_Text[index]))
            {
                index++;
            }

            return !(index < m_Text.Length) && (m_Text != "");
        }

        private void checkBoxPlayer2_Click(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_TBPlayer2.Enabled = true;
            }
            else
            {
                m_TBPlayer2.Enabled = false;
            }
        }

        public void RunGameSettings(string i_userName)
        {
            initializeComponent();
            m_TBPlayer1.Text = i_userName;
            this.ShowDialog();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkTextValidity(m_TBPlayer1.Text))
            {
                if ((m_Player2.Checked && checkTextValidity(m_TBPlayer2.Text)) || !(m_Player2.Checked))
                {
                    Close();
                    m_FormBoard = new FormBoard((int)m_NUDRows.Value, (int)m_NUDCols.Value, m_TBPlayer1.Text, m_TBPlayer2.Text);
                    markMessage(m_TBPlayer1.Text, m_TBPlayer2.Text);
                    m_FormBoard.RunGame();
                }
                else
                {
                    showMessage("Player's 2 name should contain only letters");
                }
            }
            else
            {
                showMessage("Player's 1 name should contain only letters");
            }

        }

        private void showMessage(string i_Message)
        {
            //Nikol: useless if statement.
            if (MessageBox.Show(i_Message,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error) == DialogResult.OK)
            {
            }
        }

        private void markMessage(string i_Player1, string i_Player2)
        {
            //Nikol: useless if statement.
            if (MessageBox.Show(String.Format(@"{0}'s Mark : X
{1}'s Mark : O", i_Player1, i_Player2),
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
            }
        }
    }
}
