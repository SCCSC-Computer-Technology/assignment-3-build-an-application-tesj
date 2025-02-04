using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_Speich_State_Data_Class_Library;

namespace T_Speich_CPT_206_Lab_3
{
    public partial class AddStateForm : Form
    {
        private State state;
        public AddStateForm(State _state)
        {
            InitializeComponent();
            state = _state;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //begin checks for empty textboxes (ones that cause problems if empty)
            if (IsTextboxEmpty(stateNameTextBox.Text, "state name")) return;
            if (IsTextboxEmpty(stateCapitalTextBox.Text, "state capital")) return;
            if (IsTextboxEmpty(stateFlagDescTextBox.Text, "state flag description")) return;
            if (IsTextboxEmpty(stateFlowerTextBox.Text, "state flower")) return;
            if (IsTextboxEmpty(stateBirdTextBox.Text, "state bird")) return;
            if (IsTextboxEmpty(largestCitiesTextBox.Text, "largest cities")) return;
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
            if (!int.TryParse(stateMedianIncomeTextBox.Text, out int medianIncome)
                && !string.IsNullOrWhiteSpace(stateMedianIncomeTextBox.Text)
                || medianIncome < 0)
            {
                MessageBox.Show("Invalid Median Income");
                return;
            }
            //try to parse IT jobs percentage and check if it is a valid number
            //if the textbox is empty, set the IT jobs percentage to 0
            if (!double.TryParse(stateITJobPercentTextBox.Text, out double itJobsPercent)
                && !string.IsNullOrWhiteSpace(stateITJobPercentTextBox.Text)
                || itJobsPercent < 0 || itJobsPercent >= 100)
            {
                MessageBox.Show("Invalid IT Jobs Percentage");
                return;
            }

            //assign all values to the current state and state cities entity objects
            state.State_Name = stateNameTextBox.Text;
            state.State_Population = population;
            state.State_Flag_Description = stateFlagDescTextBox.Text;
            state.State_Flower = stateFlowerTextBox.Text;
            state.State_Capital = stateCapitalTextBox.Text;
            state.State_Computer_Jobs_Percent= itJobsPercent;
            state.State_Bird = stateBirdTextBox.Text;
            state.State_Colors = stateColorsTextBox.Text;
            state.State_Median_Income = medianIncome;
            state.State_Largest_Cities = largestCitiesTextBox.Text;


            try
            {
                //insert a new record into STATE
                MainForm.stateData.InsertAndSubmitState(state);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem trying to add the new state:\n{ex.GetType()}\n{ex.Message}");
                return;
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
                MessageBox.Show("Are you sure you want to close this form?\n(Any data entered will be lost)", "Close form",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //cancel the form closing
                e.Cancel = true;
            }
        }
    }
}
