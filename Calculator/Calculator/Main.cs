/**
This Program was written by Dyfan Batchelor on 20-07-2020
**/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Logic;

namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Puts the digit "1" into the display
        private void btnOne_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "1";
        }

        //Puts the digit "2" into the display
        private void btnTwo_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "2";
        }

        //Puts the digit "3" into the display
        private void btnThree_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "3";
        }

        //Puts the digit "4" into the display
        private void btnFour_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "4";
        }

        //Puts the digit "5" into the display
        private void btnFive_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "5";
        }

        //Puts the digit "6" into the display
        private void btnSix_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "6";
        }

        //Puts the digit "7" into the display
        private void btnSeven_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "7";
        }

        //Puts the digit "8" into the display
        private void btnEight_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "8";
        }

        //Puts the digit "9" into the display
        private void btnNine_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "9";
        }

        //Puts the digit "0" into the display
        private void btnZero_Click(object sender, EventArgs e)
        {
            EmptyDisplay();
            txtDisplay.Text += "0";
        }

        //Saves the value in the display as an Integer, and sets the calculation to addition
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorLogic.CalcAddition = true;
            SetFirstInteger();

        }

        //Saves the value in the display as an Integer, and sets the calculation to subtraction
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            CalculatorLogic.CalcSubtraction = true;
            SetFirstInteger();
        }

        //Saves the value in the display as an Integer, and sets the calculation to multiplication
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CalculatorLogic.CalcMultiply = true;
            SetFirstInteger();
        }

        //Saves the value in the display as an Integer, and sets the calculation to division
        private void btnDivide_Click(object sender, EventArgs e)
        {
            CalculatorLogic.CalcDivide = true;
            SetFirstInteger();
        }

        //Saves the value in the display as an Integer, and sets the calculation to modulus
        private void btnModulus_Click(object sender, EventArgs e)
        {
            CalculatorLogic.CalcModulus = true;
            SetFirstInteger();
        }

        //Saves teh second integer, then executes the desired mathematical opperation, then resets the calculator for another use
        private void btnEquals_Click(object sender, EventArgs e)
        {
            SetSecondInteger();
            CalculatorLogic.Calculate();
            DisplayFinalValue();
            ResetCalculator();
        }

        //Resets the display
        private void btnClear_Click(object sender, EventArgs e)
        {
            CalculatorLogic.CalcComplete = true;
            EmptyDisplay();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            DeleteLastInput();
        }

        //Checks if the display contains a valid integer before saving, then disbales all the mathematical opperation buttons.
        private void SetFirstInteger()
        {
            int tryParse;
            if (int.TryParse(txtDisplay.Text, out tryParse))
            {
                CalculatorLogic.FirstValue = tryParse;
                btnAdd.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
                btnDivide.Enabled = false;
                btnModulus.Enabled = false;
                txtDisplay.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Checks if the display contains a valid integer before saving.
        private void SetSecondInteger()
        {
            int tryParse;
            if (int.TryParse(txtDisplay.Text, out tryParse))
            {
                CalculatorLogic.SecondValue = tryParse;
            }
            else
            {
                MessageBox.Show("Failed to read Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Send final value to txtDisplay
        private void DisplayFinalValue()
        {
            txtDisplay.Text = CalculatorLogic.FinalValue.ToString();
        }

        //Once the calculation is complete, the calculator is reset, but leaves the final value displayed in txtDisplay.
        private void ResetCalculator()
        {
            CalculatorLogic.CalcAddition = false;
            CalculatorLogic.CalcSubtraction = false;
            CalculatorLogic.CalcMultiply = false;
            CalculatorLogic.CalcDivide = false;
            CalculatorLogic.CalcModulus = false;
            CalculatorLogic.FirstValue = CalculatorLogic.ControlValue;
            CalculatorLogic.SecondValue = CalculatorLogic.ControlValue;
            btnAdd.Enabled = true;
            btnSubtract.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnModulus.Enabled = true;
            CalculatorLogic.CalcComplete = true;
        }

        //Checks to see if the display contains a value from a previous equation, if so, the display is cleared.
        private void EmptyDisplay()
        {
            if(CalculatorLogic.CalcComplete)
            {
                txtDisplay.Clear();
                CalculatorLogic.CalcComplete = false;
            }
        }

        //Deletes the last number the user entered
        private void DeleteLastInput()
        {
            string currentValue = txtDisplay.Text;
            int stringLength = currentValue.Length - 1;
            string newValue = currentValue.Substring(0, stringLength);
            txtDisplay.Text = newValue;
        }
    }
}
