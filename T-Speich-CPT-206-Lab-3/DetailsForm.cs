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
    public partial class DetailsForm : Form
    {
        private STATE state;
        private STATE_LARGEST_CITY city;
        public DetailsForm(STATE _state, STATE_LARGEST_CITY _city)
        {
            InitializeComponent();
            state = _state;
            city = _city;
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
                //try to submit changes to the datacontext
                MainForm.db.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Something went wrong:\n{ex.GetType()}\n{ex.Message}");
                return;
            }

            
            //inform the user that their changes were saved successfully and close the form
            MessageBox.Show("Changes saved!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

            //populate textboxes
            stateNameTextBox.Text = state.STATE_NAME;
            statePopulationTextBox.Text = state.STATE_POPULATION.ToString();
            stateCapitolTextBox.Text = state.STATE_CAPITOL;
            stateBirdTextBox.Text = state.STATE_BIRD;
            stateColorsTextBox.Text = state.STATE_COLORS;
            stateFlagDescTextBox.Text = state.STATE_FLAG_DESC;
            stateFlowerTextBox.Text = state.STATE_FLOWER;
            stateMedianIncomeTextBox.Text = state.STATE_MEDIAN_INCOME.ToString();
            stateITJobPercentTextBox.Text = state.STATE_IT_JOB_PERCENT.ToString();
            largestCityTextBox.Text = city.LARGEST_CITY;
            secondLargestCityTextBox.Text = city.SECOND_LARGEST_CITY;
            thirdLargestCityTextBox.Text = city.THIRD_LARGEST_CITY;
        }

        private void DetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ask the user if they really want to close the form 
            if (this.DialogResult != DialogResult.OK && 
                MessageBox.Show("Are you sure you want to close this form?\n(Any changes made will be lost)", "Close form",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //cancel the form closing
                e.Cancel = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
