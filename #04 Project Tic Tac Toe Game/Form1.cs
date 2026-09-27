using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Project_Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;
        }
        enum enPlayerChoise { None, X, O }
        bool isXTurn = true;
        int isDrow = 0;
        byte CountPlayer1Win = 0;
        byte CountPlayer2Win = 0;
        byte CountDrow = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int cellSize = 200;
            int startX = 400;
            int startY = 140;
            Pen whitePen = new Pen(Color.White, 10);
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(whitePen, startX, startY + cellSize, startX + cellSize * 3, startY + cellSize);
            e.Graphics.DrawLine(whitePen, startX, startY + cellSize * 2, startX + cellSize * 3, startY + cellSize * 2);

            e.Graphics.DrawLine(whitePen, startX + cellSize, startY, startX + cellSize, startY + cellSize * 3);
            e.Graphics.DrawLine(whitePen, startX + cellSize * 2, startY, startX + cellSize * 2, startY + cellSize * 3);
        }
        void WhoIsWin()
        {
            var winner = CheckTheResult();

            if (winner == enPlayerChoise.None)
            {
                if (isDrow == 9) IsDrow();
                return;
            }

            string winnerName = "";

            if (winner == enPlayerChoise.X)
            {
                if (rbX1.Checked)
                {
                    winnerName = txtPlayer1.Text;
                    CountPlayer1Win++;
                    txtWinPlayer1.Text = CountPlayer1Win.ToString();
                    txtLossPlayer2.Text = CountPlayer1Win.ToString();
                }
                else if (rbX2.Checked)
                {
                    winnerName = txtPlayer2.Text;
                    CountPlayer2Win++;
                    txtWinPlayer2.Text = CountPlayer2Win.ToString();
                    txtLossPlayer1.Text = CountPlayer2Win.ToString();
                }
            }
            else
            {
                if (rbO1.Checked)
                {
                    winnerName = txtPlayer1.Text;
                    CountPlayer1Win++;
                    txtWinPlayer1.Text = CountPlayer1Win.ToString();
                    txtLossPlayer2.Text = CountPlayer1Win.ToString();
                }
                else if (rbO2.Checked)
                {
                    winnerName = txtPlayer2.Text;
                    CountPlayer2Win++;
                    txtWinPlayer2.Text = CountPlayer2Win.ToString();
                    txtLossPlayer1.Text = CountPlayer2Win.ToString();
                }
            }

            MessageBox.Show($"Congratulations, {winnerName} have won :-)", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRESET.Visible = true;
            ChangeButtonToEnabled(false);
            btnEndGame.Visible = true;
        }
        void IsDrow()
        {
            CountDrow++;
            txtDraw.Text = CountDrow.ToString();
            MessageBox.Show("A draw, no one won :-(", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEndGame.Visible = true;
            btnRESET.Visible = true;
            ChangeButtonToEnabled(false);
        }
        enPlayerChoise CheckTheResult()
        {
            if ((enPlayerChoise)btn1.Tag == (enPlayerChoise)btn2.Tag && (enPlayerChoise)btn1.Tag == (enPlayerChoise)btn3.Tag && (enPlayerChoise)btn1.Tag != enPlayerChoise.None)
            {
                btn1.BackColor = Color.MediumSpringGreen;
                btn2.BackColor = Color.MediumSpringGreen;
                btn3.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn1.Tag;
            }

            if ((enPlayerChoise)btn4.Tag == (enPlayerChoise)btn5.Tag && (enPlayerChoise)btn4.Tag == (enPlayerChoise)btn6.Tag && (enPlayerChoise)btn4.Tag != enPlayerChoise.None)
            {
                btn4.BackColor = Color.MediumSpringGreen;
                btn5.BackColor = Color.MediumSpringGreen;
                btn6.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn4.Tag;
            }
            if ((enPlayerChoise)btn7.Tag == (enPlayerChoise)btn8.Tag && (enPlayerChoise)btn7.Tag == (enPlayerChoise)btn9.Tag && (enPlayerChoise)btn7.Tag != enPlayerChoise.None)
            {
                btn7.BackColor = Color.MediumSpringGreen;
                btn8.BackColor = Color.MediumSpringGreen;
                btn9.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn7.Tag;
            }
            if ((enPlayerChoise)btn1.Tag == (enPlayerChoise)btn4.Tag && (enPlayerChoise)btn1.Tag == (enPlayerChoise)btn7.Tag && (enPlayerChoise)btn1.Tag != enPlayerChoise.None)
            {
                btn1.BackColor = Color.MediumSpringGreen;
                btn4.BackColor = Color.MediumSpringGreen;
                btn7.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn1.Tag;
            }
            if ((enPlayerChoise)btn2.Tag == (enPlayerChoise)btn5.Tag && (enPlayerChoise)btn2.Tag == (enPlayerChoise)btn8.Tag && (enPlayerChoise)btn2.Tag != enPlayerChoise.None)
            {
                btn2.BackColor = Color.MediumSpringGreen;
                btn5.BackColor = Color.MediumSpringGreen;
                btn8.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn2.Tag;
            }
            if ((enPlayerChoise)btn3.Tag == (enPlayerChoise)btn6.Tag && (enPlayerChoise)btn3.Tag == (enPlayerChoise)btn9.Tag && (enPlayerChoise)btn3.Tag != enPlayerChoise.None)
            {
                btn3.BackColor = Color.MediumSpringGreen;
                btn6.BackColor = Color.MediumSpringGreen;
                btn9.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn3.Tag;
            }
            if ((enPlayerChoise)btn1.Tag == (enPlayerChoise)btn5.Tag && (enPlayerChoise)btn1.Tag == (enPlayerChoise)btn9.Tag && (enPlayerChoise)btn1.Tag != enPlayerChoise.None)
            {
                btn1.BackColor = Color.MediumSpringGreen;
                btn5.BackColor = Color.MediumSpringGreen;
                btn9.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn1.Tag;
            }
            if ((enPlayerChoise)btn3.Tag == (enPlayerChoise)btn5.Tag && (enPlayerChoise)btn3.Tag == (enPlayerChoise)btn7.Tag && (enPlayerChoise)btn3.Tag != enPlayerChoise.None)
            {
                btn3.BackColor = Color.MediumSpringGreen;
                btn5.BackColor = Color.MediumSpringGreen;
                btn7.BackColor = Color.MediumSpringGreen;
                return (enPlayerChoise)btn3.Tag;
            }
            return enPlayerChoise.None;
        }
        void ChangeImageToX(object sender)
        {
            Button b = sender as Button;
            b.Image = Image.FromFile(@"C:\Images\x.png");
            b.BackgroundImageLayout = ImageLayout.Center;
        }
        void ChangeImageToO(object sender)
        {
            Button b = sender as Button;
            b.Image = Image.FromFile(@"C:\Images\o.png");
            b.BackgroundImageLayout = ImageLayout.Center;
        }
        private void GameForTowPlayer(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if ((enPlayerChoise)button.Tag == enPlayerChoise.None)
            {
                if (isXTurn)
                {
                    ChangeImageToX(button);
                    button.Tag = enPlayerChoise.X;
                    button.BackColor = Color.RoyalBlue;
                    isXTurn = false;
                }
                else
                {
                    ChangeImageToO(button);
                    button.Tag = enPlayerChoise.O;
                    button.BackColor = Color.IndianRed;
                    isXTurn = true;
                }
                WhoIsTurn();
                isDrow++;

                var winner = CheckTheResult();
                if (winner != enPlayerChoise.None)
                {
                    WhoIsWin();
                }
                else if (isDrow == 9)
                {
                    IsDrow();
                }
            }
            else
            {
                MessageBox.Show("Incorrect choice, you should select another box.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        void WhoIsTurn()
        {
            if (isXTurn)
            {
                if (rbX1.Checked && rbO2.Checked)
                {
                    labTurn.Text = txtPlayer1.Text;
                }
                else if (rbO1.Checked && rbX2.Checked)
                {
                    labTurn.Text = txtPlayer2.Text;
                }
            }
            else
            {
                if (rbX1.Checked && rbO2.Checked)
                {
                    labTurn.Text = txtPlayer2.Text;
                }
                else if (rbO1.Checked && rbX2.Checked)
                {
                    labTurn.Text = txtPlayer1.Text;
                }
            }
        }
        void ChangeButtonToEnabled(bool Enabled = true)
        {
            btn1.Enabled = Enabled;
            btn2.Enabled = Enabled;
            btn3.Enabled = Enabled;
            btn4.Enabled = Enabled;
            btn5.Enabled = Enabled;
            btn6.Enabled = Enabled;
            btn7.Enabled = Enabled;
            btn8.Enabled = Enabled;
            btn9.Enabled = Enabled;
        }
        void ChangeButtonToDefault()
        {
            btn1.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn2.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn3.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn4.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn5.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn6.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn7.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn8.Image = Image.FromFile(@"C:\Images\question-mark-96.png");
            btn9.Image = Image.FromFile(@"C:\Images\question-mark-96.png");

            btn1.Tag = enPlayerChoise.None;
            btn2.Tag = enPlayerChoise.None;
            btn3.Tag = enPlayerChoise.None;
            btn4.Tag = enPlayerChoise.None;
            btn5.Tag = enPlayerChoise.None;
            btn6.Tag = enPlayerChoise.None;
            btn7.Tag = enPlayerChoise.None;
            btn8.Tag = enPlayerChoise.None;
            btn9.Tag = enPlayerChoise.None;

            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
            btn5.BackColor = Color.Transparent;
            btn6.BackColor = Color.Transparent;
            btn7.BackColor = Color.Transparent;
            btn8.BackColor = Color.Transparent;
            btn9.BackColor = Color.Transparent;

            isDrow = 0;
        }
        private void btnSTART_Click(object sender, EventArgs e)
        {
            ChangeButtonToDefault();
            ChangeButtonToEnabled(true);
            WhoIsTurn();
            btnSTART.Visible = false;
            gbXorO.Enabled = false;
            gbSettings.Enabled = false;
            pbBox.Visible = true;
            txtTurn.Visible = true;
            labTurn.Visible = true;
        }
        private void rbX1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "" && txtPlayer2.Text != "" && (rbX1.Checked || rbO1.Checked) && (rbX2.Checked || rbO2.Checked))
            {
                btnSTART.Visible = true;
            }
            rbX2.Enabled = false;
            rbO2.Enabled = true;
            txtPlayer1.Enabled = true;
            txtPlayer2.ForeColor = Color.IndianRed;
            txtPlayer1.ForeColor = Color.RoyalBlue;
            labScorePlayer1.ForeColor = Color.RoyalBlue;
            labScorePlayer2.ForeColor = Color.IndianRed;
        }
        private void rbO1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "" && txtPlayer2.Text != "" && (rbX1.Checked || rbO1.Checked) && (rbX2.Checked || rbO2.Checked))
            {
                btnSTART.Visible = true;
            }
            rbO2.Enabled = false;
            rbX2.Enabled = true;
            txtPlayer1.Enabled = true;
            txtPlayer2.ForeColor = Color.RoyalBlue;
            txtPlayer1.ForeColor = Color.IndianRed;
            labScorePlayer2.ForeColor = Color.RoyalBlue;
            labScorePlayer1.ForeColor = Color.IndianRed;
        }
        private void rbX2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "" && txtPlayer2.Text != "" && (rbX1.Checked || rbO1.Checked) && (rbX2.Checked || rbO2.Checked))
            {
                btnSTART.Visible = true;
            }
            if (rbX2.Checked)
            {
                txtPlayer2.Enabled = true;
            }
        }
        private void rbO2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "" && txtPlayer2.Text != "" && (rbX1.Checked || rbO1.Checked) && (rbX2.Checked || rbO2.Checked))
            {
                btnSTART.Visible = true;
            }
            if (rbX2.Checked)
            {
                txtPlayer2.Enabled = true;
            }
        }
        void NewBeginningGame()
        {
            CountPlayer1Win = 0;
            CountPlayer2Win = 0;
            CountDrow = 0;
            txtWinPlayer1.Text = "";
            txtWinPlayer2.Text = "";
            txtLossPlayer1.Text = "";
            txtLossPlayer2.Text = "";
            txtDraw.Text = "";
            rbX1.Checked = false;
            rbO1.Checked = false;
            rbO2.Checked = false;
            rbX2.Checked = false;
            btnSTART.Visible = true;
            btnRESET.Visible = false;
            btnEndGame.Visible = false;
            gbXorO.Enabled = true;
            pbBox.Visible = false;
            txtTurn.Visible = false;
            labTurn.Visible = false;
            isXTurn = true;
            ChangeButtonToDefault();
            ChangeButtonToEnabled(false);
        }
        private void btnEndGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about replaying the game ? ", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                NewBeginningGame();
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            btnSTART.Visible = true;
            btnRESET.Visible = false;
            gbXorO.Enabled = false;
            ChangeButtonToDefault();
            ChangeButtonToEnabled(false);
            pbBox.Visible = true;
            txtTurn.Visible = true;
            labTurn.Text = "";
        }

        private void rbOInTheFirst_CheckedChanged_1(object sender, EventArgs e)
        {
            isXTurn = false;
            if (rbX1.Checked && rbO2.Checked)
            {
                labTurn.Text = txtPlayer2.Text;
            }
            else if (rbO1.Checked && rbX2.Checked)
            {
                labTurn.Text = txtPlayer1.Text;
            }
            gbSettings.Enabled = true;
        }

        private void rbXInTheFirst_CheckedChanged_1(object sender, EventArgs e)
        {
            isXTurn = true;
            if (rbX1.Checked && rbO2.Checked)
            {
                labTurn.Text = txtPlayer1.Text;
            }
            else if (rbO1.Checked && rbX2.Checked)
            {
                labTurn.Text = txtPlayer2.Text;
            }
            gbSettings.Enabled = true;
        }

        private void txtPlayer1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "" && txtPlayer2.Text != "" && (rbX1.Checked || rbO1.Checked) && (rbX2.Checked || rbO2.Checked))
            {
                btnSTART.Visible = true;
            }
            labScorePlayer1.Text = txtPlayer1.Text;
        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "" && txtPlayer2.Text != "" && (rbX1.Checked || rbO1.Checked) && (rbX2.Checked || rbO2.Checked))
            {
                btnSTART.Visible = true;
            }
            labScorePlayer2.Text = txtPlayer2.Text;
        }
    }
}