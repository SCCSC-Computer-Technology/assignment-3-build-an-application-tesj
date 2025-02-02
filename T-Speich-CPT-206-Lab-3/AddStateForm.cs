using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace T_Speich_CPT_206_Lab_3
{
    public partial class AddStateForm : Form
    {
        private STATE state;
        private STATE_LARGEST_CITY city;
        public AddStateForm(STATE _state, STATE_LARGEST_CITY _city)
        {
            InitializeComponent();
            state = _state;
            city = _city;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //begin checks for empty textboxes (ones that cause problems if empty)
            if (IsTextboxEmpty(stateNameTextBox.Text, "state name")) return;
            if (IsTextboxEmpty(stateCapitolTextBox.Text, "state capitol")) return;
            if (IsTextboxEmpty(stateFlagDescTextBox.Text, "state flag description")) return;
            if (IsTextboxEmpty(stateColorsTextBox.Text, "state colors")) return;
            //end checks for empty textboxes

            //try to parse population
            if (!int.TryParse(statePopulationTextBox.Text, out int population)
                || population < 0)
            {
                MessageBox.Show("Invalid Population");
                return;
            }
            //try to parse median income and check if it is a valid number
            //if the textbox is empty, set the median income to 0
            if (!decimal.TryParse(stateMedianIncomeTextBox.Text, out decimal medianIncome)
                && !string.IsNullOrWhiteSpace(stateMedianIncomeTextBox.Text)
                || medianIncome < 0)
            {
                MessageBox.Show("Invalid Median Income");
                return;
            }
            //try to parse IT jobs percentage and check if it is a valid number
            //if the textbox is empty, set the IT jobs percentage to 0
            if (!decimal.TryParse(stateITJobPercentTextBox.Text, out decimal itJobsPercent)
                && !string.IsNullOrWhiteSpace(stateITJobPercentTextBox.Text)
                || itJobsPercent < 0 || itJobsPercent >= 100)
            {
                MessageBox.Show("Invalid IT Jobs Percentage");
                return;
            }

            //assign all values to the current state and state cities entity objects
            state.STATE_NAME = stateNameTextBox.Text;
            state.STATE_POPULATION = population;
            state.STATE_FLAG_DESC = stateFlagDescTextBox.Text;
            state.STATE_FLOWER = stateFlowerTextBox.Text;
            state.STATE_CAPITOL = stateCapitolTextBox.Text;
            state.STATE_IT_JOB_PERCENT = itJobsPercent;
            state.STATE_BIRD = stateBirdTextBox.Text;
            state.STATE_COLORS = stateColorsTextBox.Text;
            state.STATE_MEDIAN_INCOME = medianIncome;
            city.LARGEST_CITY = largestCityTextBox.Text;
            city.SECOND_LARGEST_CITY = secondLargestCityTextBox.Text;
            city.THIRD_LARGEST_CITY = thirdLargestCityTextBox.Text;

            try
            {
                //insert a new record into STATE
                MainForm.db.STATEs.InsertOnSubmit(state);
                MainForm.db.SubmitChanges();

                //set the city's state ID to the ID of the state just inserted into STATE
                city.STATE_ID = state.STATE_ID;

                //submit a new record into STATE_LARGEST_CITY
                MainForm.db.STATE_LARGEST_CITies.InsertOnSubmit(city);
                MainForm.db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem trying to add the new state:\n{ex.GetType()}\n{ex.Message}");
            }

            //tell the user that the insert was successful and close this form
            MessageBox.Show("State Added Successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool IsTextboxEmpty(string text, string textboxName)
        {
            //check if the text of the textbox is null or contains only whitespace chars
            if (string.IsNullOrWhiteSpace(text))
            {
                //inform the user that the textbox must contain a value
                MessageBox.Show($"The {textboxName}  textbox must contain a value");
                return true;
            }
            return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ask the user if they really want to close the form
            if(this.DialogResult != DialogResult.OK &&
                MessageBox.Show("Are you sure you want to close this form?\n(Any changes made will be lost)", "Close form",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //cancel the form closing
                e.Cancel = true;
            }
        }
    }
}
