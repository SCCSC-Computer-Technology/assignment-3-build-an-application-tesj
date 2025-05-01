using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic.Core;
using T_Speich_State_Data_Class_Library;

namespace T_Speich_CPT_206_Lab_3
{
    public partial class MainForm : Form
    {
        public static StateData stateData;
        public MainForm()
        {
            InitializeComponent();

            //initialize objects and assign variable values
            stateData = new StateData();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (stateDataGridView.CurrentRow != null)
            {
                //store the selected row of the data grid view in a variable
                DataGridViewRow row = stateDataGridView.CurrentRow;

                //create state and city variables
                State state;

                try
                {
                    //find the selected state in the data context object
                    state = stateData.GetStateByID(Convert.ToInt32(row.Cells[0].Value));
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Something went wrong when retrieving state info:\n{ex.GetType()}\n{ex.Message}");
                    return;
                }


                //instantiate a details form and open it
                DetailsForm frm = new DetailsForm(state);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //update the binding source's data source
                    UpdateBindingSource();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sortColumnComboBox.SelectedIndex = 0;
            sortOrderComboBox.SelectedIndex = 0;

            stateDataGridView.AutoGenerateColumns = true; //setting this here because VS likes to reset it in MainForm.Designer.cs
            UpdateBindingSource();

            //remove the underscores from the DataGridView column headers
            for (int i = 0; i < stateDataGridView.Columns.Count; i++)
            {
                stateDataGridView.Columns[i].HeaderText = stateDataGridView.Columns[i].HeaderText.Replace('_', ' ');
            }
            stateDataGridView.Columns[0].Visible = false;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            //declare variables to store new sort values
            string newColumn = "";
            string newOrder = "";

            //check if a valid sort column is selected
            if (sortColumnComboBox.SelectedIndex != -1)
            {
                //decide which column to use
                if (sortColumnComboBox.SelectedIndex == 2)
                {
                    newColumn = "State_Flag_Description";
                }
                else if (sortColumnComboBox.SelectedIndex == 7)
                {
                    newColumn = "State_Computer_Jobs_Percent";
                }
                else
                {
                    //replaces the selected item's spaces with '-'
                    newColumn = sortColumnComboBox.SelectedItem.ToString().Replace(" ", "_");
                }
            }
            else
            {
                MessageBox.Show("Please select a column to sort by");
                return;
            }
            //check if a sort order is selected
            if (sortOrderComboBox.SelectedIndex != -1)
            {
                //set the new order to ascending or descending based off the selected index of the combo box
                //this is kind of like an if else statement to assign the value of newOrder
                //if the selected index == 0, assign "ASC" to newOrder, else assign "DESC"
                newOrder = sortOrderComboBox.SelectedIndex == 0 ? "ASC" : "DESC";
            }
            else
            {
                MessageBox.Show("Please select a sort order");
                return;
            }

            //assign the new column and order values to column and order
            stateData.SortColumn = newColumn;
            stateData.SortOrder = newOrder;

            //change the binding source's source to the datacontext STATE table ordered by the new column and order
            UpdateBindingSource();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //create a state and city object
            State state = new State();

            //create and open the Add New State form
            AddStateForm frm = new AddStateForm(state);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //refresh the binding source if changes were made
                UpdateBindingSource();
            }
        }

        private void stateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.stateDBDataSet);

        }

        private void UpdateBindingSource()
        {
            try
            {
                //set the data source to the STATE table sorted and filtered by the current selection
                stateBindingSource.DataSource = stateData.GetFilteredAndSortedStates();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong when trying to retrieve updated data\n{ex.GetType()}\n{ex.Message}");
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //check if a row is selected
            if(stateDataGridView.CurrentRow != null)
            {
                //confirm that the user wants to delete the state
                if(MessageBox.Show("Are you sure you want to delete this state?\n(This cannot be undone)",
                    "Delete State",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //get the state ID
                    int stateID = Convert.ToInt32(stateDataGridView.CurrentRow.Cells[0].Value);

                    try
                    {
                        //delete the state
                        stateData.RemoveAndSubmitState(stateID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Something went wrong when trying to delete the state\n{ex.GetType()}\n{ex.Message}");
                        return;
                    }

                    //refresh the binding source
                    UpdateBindingSource();
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            //declare variables
            string filterColumn = "";
            string filterOperator = "";
            string filterValue = "";
            int selectedColumnIndex = filterColumnComboBox.SelectedIndex;
            int selectedFilterOperatorIndex = filterOperatorComboBox.SelectedIndex;

            //make sure a column is selected
            if (selectedColumnIndex != -1)
            {
                //decide which column to use
                if (selectedColumnIndex == 2)
                {
                    filterColumn = "State_Flag_Description";
                }
                else if (selectedColumnIndex == 8)
                {
                    filterColumn = "State_Computer_Jobs_Percent";
                }
                else
                {
                    //convert the selected item's text to uppercase and replace spaces with '-'
                    filterColumn = filterColumnComboBox.SelectedItem.ToString().Replace(" ", "_");
                }

            }
            else
            {
                MessageBox.Show("Please select a column to filter by");
                return;
            }

            //make sure a filter operator is selected
            if (selectedFilterOperatorIndex != -1)
            {
                //set the operator to "!=" if the user selects "is not"
                if (selectedFilterOperatorIndex == 5)
                {
                    filterOperator = " != @0";
                }
                //set the operator to ".contains(" if the user selects "contains"
                else if (selectedFilterOperatorIndex == 6)
                {
                    filterOperator = ".contains(@0)";
                }
                else
                {
                    filterOperator =  $" {filterOperatorComboBox.SelectedItem.ToString()} @0";
                }

            }
            else
            {
                MessageBox.Show("Please select a filter operator");
                return;
            }

            //check if the user entered a value into the filter textbox
            if (!string.IsNullOrWhiteSpace(filterTextBox.Text))
            {
                //determine if the "contains" (like) operator was selected
                if (filterOperator == ".contains(@0)")
                {
                    //if the user did not select a numeric column, assign the textbox v
                    if (selectedColumnIndex != 1 && selectedColumnIndex != 7 && selectedColumnIndex != 8)
                    {
                        filterValue = filterTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show($"\"contains\" is not a valid choice for {filterColumnComboBox.SelectedItem}");
                        return;
                    }
                }
                else
                {
                    //assign the text entered into the filter textbox to the filterText
                    filterValue = filterTextBox.Text;
                }
            }
            else
            {
                MessageBox.Show("Please enter a value to filter by");
                return;
            }


            try
            {
                //set the filter based on user selections and input
                stateData.Filter = $"{filterColumn}{filterOperator}";
                stateData.FilterValue = filterValue;
                UpdateBindingSource(); //apply the filter
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong:\n{ex.GetType()}\n{ex.Message}");
            }
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            //reset the filter control values
            filterColumnComboBox.SelectedIndex = -1;
            filterOperatorComboBox.SelectedIndex = -1;
            filterTextBox.ResetText();

            //clear the filter
            stateData.Filter = "TRUE";
            UpdateBindingSource();
        }
    }
}

