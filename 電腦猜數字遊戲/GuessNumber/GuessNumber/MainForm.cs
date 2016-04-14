using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class MainForm : Form
    {
        private Guesser guesser;
        private int guessedNumber;
        private int targetNumber;
        private Random random;

        public MainForm()
        {
            InitializeComponent();
            guesser = new Guesser();
            random = new Random();
        }

        private void RefreshManual()
        {
            ALabel.Visible = false;
            BLabel.Visible = false;
            ATextBox.Visible = false;
            BTextBox.Visible = false;
            manualButton.Text = "人工出題";
        }

        private void GenerateTargetNumber()
        {
            guesser.InitAnswers();
            targetNumber = guesser.GuessNumber();
            targetLabel.Text = string.Format("{0:d4}", targetNumber);
            targetLabel.Visible = true;
            guesser.InitAnswers();
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            RefreshManual();
            GenerateTargetNumber();
            this.resultTextBox.Text = string.Empty;

            while (guesser.A < 4)
            {
                guessedNumber = guesser.GuessNumber();
                resultTextBox.Text += string.Format("({0}) guessedNumber = {1:d4}\n", guesser.Remains, guessedNumber);
                guesser.CompareNumber(guessedNumber, targetNumber);
                resultTextBox.Text += string.Format("{0} A {1} B\n", guesser.A, guesser.B);

                if (guesser.Remains == 0)
                {
                    MessageBox.Show("It's impossible.");
                    break;
                }
            }
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            if (!ALabel.Visible)
            {
                ALabel.Visible = true;
                BLabel.Visible = true;
                ATextBox.Visible = true;
                BTextBox.Visible = true;
                ATextBox.Text = "";
                BTextBox.Text = "";
                manualButton.Text = "輸  入";
                targetLabel.Visible = false;
                resultTextBox.Text = string.Empty;
                guesser.InitAnswers();
            }
            else
            {
                int a, b;

                if (!int.TryParse(ATextBox.Text, out a) || !int.TryParse(BTextBox.Text, out b))
                {
                    MessageBox.Show("輸入錯誤, 請重新輸入");
                    return;
                }
                else
                {
                    if (a < 0 || a > 4 || b < 0 || b > 4)
                    {
                        MessageBox.Show("輸入錯誤, 請重新輸入");
                        return;
                    }
                    else
                    {
                        if (a == 4)
                        {
                            MessageBox.Show("已猜中!");
                            RefreshManual();
                            return;
                        }

                        guesser.A = a;
                        guesser.B = b;
                        resultTextBox.Text += string.Format("{0} A {1} B\n", guesser.A, guesser.B);
                    }
                }
            }

            guessedNumber = guesser.GuessNumber();
            resultTextBox.Text += string.Format("({0}) guessedNumber = {1:d4}\n", guesser.Remains, guessedNumber);

            if (guesser.Remains == 0)
            {
                MessageBox.Show("It's impossible.");
                RefreshManual();
            }
        }
    }
}