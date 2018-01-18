using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tessLarcadeMathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object to generate random numbers.
        Random randomizer = new Random();

        //ints for the addition problem
        int addend1;
        int addend2;

        //ints for the subtraction problem
        int minuend;
        int subtrahend;

        //ints for the multiplication problem
        int multiplicand;
        int multiplier;

        //ints for the division problem
        int dividend;
        int divisor;

        //Remaining time
        int timeLeft;

        /* Start the quiz by adding numerical values 
         * for the problems and starting the timer.
         */
        public void StartTheQuiz()
        {
            Console.WriteLine("StartTheQuiz");
            //add numerical values to the addition problem.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Convert the random numbers into strings
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // Make sure the value is zero before adding values.
            sum.Value = 0;

            // Fill in the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the miltiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividendLeftLabel.Text = dividend.ToString();
            dividendRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            return true;
            else
            return false;
        }
        public Form1()
        {
            Console.WriteLine("Form1 Constructor");
            InitializeComponent();
            StartTheQuiz();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label1_Click");
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("StartButton_Click");
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //If the answer returns true, stop the timer and show a message box.
                timer1.Stop();
                MessageBox.Show("All answers are correct!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the amount of time left by udating the TimeLeft label
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //If out of time, stop the timer, show a message box, and fill in all answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the answer in the NumericUpDown control
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
