using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class RandomNumber : Form
    {
        int number;
        int counter = 0;

        public RandomNumber()
        {
            InitializeComponent();
        }
        private void RandomNumber_Load(object sender, EventArgs e) //only loading once
        {
            this.InitialPick(); //refactoring from before
        }
        private void InitialPick() //need for restart
        {
            Random random = new Random();
            number = random.Next(1, 501); //1 <= number < 501
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try //exceptions
            {
                uint guess = Convert.ToUInt32(txtGuess.Text);

                    if (guess < 1) //valid range
                    {
                        MessageBox.Show("Your guess must be a positive number between 1 and 500", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtGuess.Focus();
                    }
                    else if (guess >= 501)
                    {
                        MessageBox.Show("Your guess must be less than 500", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtGuess.Focus();
                    }


                if (guess == number)
                {
                    txtResult.Text = "Correct! It took you " + counter + " times to guess the number";
                    MessageBox.Show("Correct!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuess.Enabled = false;
                    txtGuess.Enabled = false;
                    btnRestart.Focus();
                }
                else if (guess < number)
                {
                    txtResult.Text = "Your last guess of " + "\"" + guess + "\"" + " was too low";
                    MessageBox.Show("Below The Number: Pick Again", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (guess > number && guess <= 500)
                {
                    txtResult.Text = "Your last guess of " + "\"" + guess + "\"" + " was too high";
                    MessageBox.Show("Above The Number: Pick Again", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                txtGuess.Focus();
                txtGuess.Text = "";
                              
            }

            catch (FormatException)
            {
                MessageBox.Show("Invalid Format.  Please input a whole number.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuess.Text = "";
                txtGuess.Focus();
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Please Choose a Positive Number", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuess.Text = "";
                txtGuess.Focus();
            }
            catch (Exception ex)
            {
                    MessageBox.Show(
                    ex.Message, 
                    ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.InitialPick();
            txtGuess.Text = "";
            txtResult.Text = "";
            counter = 0;
            MessageBox.Show("A new number has been randomly generated", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGuess.Enabled = true;
            txtGuess.Enabled = true;
            txtGuess.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Playing!", "Guess My Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            counter++;
        }
    }
}
