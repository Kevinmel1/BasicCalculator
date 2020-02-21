using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{

    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            //Focus input
            FocusInputText();
        }

        /// <summary>
        /// Deletes the first character in front of the cursor
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DELButton_Click(object sender, EventArgs e)
        {
            //Delete the value after the selected position
            DeleteTextValue();

            //Focus input
            FocusInputText();
        }

        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the Divide character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("/");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the Multiplication character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("*");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the Minus character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("-");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the Plus character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("+");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Calculates the given equation in the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //Calculate the equation
            CalculateEquation();

            //Focus input
            FocusInputText();
        }
        #endregion

        #region Number Methods
        /// <summary>
        /// Adds the . character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue(".");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 0 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("0");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 1 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("1");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 2 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("2");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 3 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("3");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 4 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("4");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 5 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("5");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 6 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("6");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 7 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("7");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 8 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("8");

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Adds the 9 character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("9");

            //Focus input
            FocusInputText();
        }
        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {


            this.CalculationsResultsText.Text = ParseOperation();

            //Focus input
            FocusInputText();
        }
        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //Get the users equation input
                var userInput = this.UserInputText.Text;

                //Remove all spaces
                userInput = userInput.Replace(" ", "");

                //Create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                for (int i = 0; i < userInput.Length; i++)
                {
                    //TODO: Handle order priority
                    // 4 + 5 * 3
                    // It should calc 5 * 3 first, 
                    
                    if ("0123456789.".Any(c => userInput[i] == c))
                    {

                    }
                    
                }



                return string.Empty;
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        #region Private Helpers
        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">Value to insert</param>
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection lenght to zero
            this.UserInputText.SelectionLength = 0;

        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection lenght to zero
            this.UserInputText.SelectionLength = 0;

        }

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            //Focuses the user input text
            this.UserInputText.Focus();
        }

        #endregion
    }
}
