namespace T_Speich_CPT_206_Lab_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDBDataSet = new T_Speich_CPT_206_Lab_3.StateDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateTableAdapter = new T_Speich_CPT_206_Lab_3.StateDBDataSetTableAdapters.STATETableAdapter();
            this.tableAdapterManager = new T_Speich_CPT_206_Lab_3.StateDBDataSetTableAdapters.TableAdapterManager();
            this.sortButton = new System.Windows.Forms.Button();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.sortColumnComboBox = new System.Windows.Forms.ComboBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stateSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.filterColumnComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterOperatorComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingNavigator)).BeginInit();
            this.stateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stateBindingNavigator
            // 
            this.stateBindingNavigator.AddNewItem = null;
            this.stateBindingNavigator.BindingSource = this.stateBindingSource;
            this.stateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateBindingNavigator.DeleteItem = null;
            this.stateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.stateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateBindingNavigator.Name = "stateBindingNavigator";
            this.stateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateBindingNavigator.Size = new System.Drawing.Size(933, 25);
            this.stateBindingNavigator.TabIndex = 0;
            this.stateBindingNavigator.Text = "bindingNavigator1";
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataMember = "STATE";
            this.stateBindingSource.DataSource = this.stateDBDataSet;
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stateDataGridView
            // 
            this.stateDataGridView.AllowUserToAddRows = false;
            this.stateDataGridView.AllowUserToDeleteRows = false;
            this.stateDataGridView.AutoGenerateColumns = false;
            this.stateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.stateDataGridView.DataSource = this.stateBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stateDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.stateDataGridView.Location = new System.Drawing.Point(21, 28);
            this.stateDataGridView.MultiSelect = false;
            this.stateDataGridView.Name = "stateDataGridView";
            this.stateDataGridView.ReadOnly = true;
            this.stateDataGridView.RowHeadersVisible = false;
            this.stateDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.stateDataGridView.RowTemplate.Height = 150;
            this.stateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stateDataGridView.Size = new System.Drawing.Size(891, 328);
            this.stateDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STATE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "STATE_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STATE_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "State Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STATE_POPULATION";
            this.dataGridViewTextBoxColumn3.HeaderText = "State Population";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "STATE_FLAG_DESC";
            this.dataGridViewTextBoxColumn4.HeaderText = "State Flag Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "STATE_COLORS";
            this.dataGridViewTextBoxColumn5.HeaderText = "State Colors";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "STATE_BIRD";
            this.dataGridViewTextBoxColumn6.HeaderText = "State Bird";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "STATE_FLOWER";
            this.dataGridViewTextBoxColumn7.HeaderText = "State Flower";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "STATE_CAPITOL";
            this.dataGridViewTextBoxColumn8.HeaderText = "State Capitol";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "STATE_MEDIAN_INCOME";
            this.dataGridViewTextBoxColumn9.HeaderText = "State Median Income";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "STATE_IT_JOB_PERCENT";
            this.dataGridViewTextBoxColumn10.HeaderText = "State IT Jobs Percent";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // stateTableAdapter
            // 
            this.stateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.STATE_LARGEST_CITYTableAdapter = null;
            this.tableAdapterManager.STATETableAdapter = this.stateTableAdapter;
            this.tableAdapterManager.UpdateOrder = T_Speich_CPT_206_Lab_3.StateDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(303, 465);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(121, 23);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "&Sort";
            this.toolTip1.SetToolTip(this.sortButton, "Sorts the states by the selected value in the selected order");
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(303, 407);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortOrderComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.sortOrderComboBox, "Selects the order to sort by (i.e. ascending or descending)");
            // 
            // sortColumnComboBox
            // 
            this.sortColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortColumnComboBox.FormattingEnabled = true;
            this.sortColumnComboBox.Items.AddRange(new object[] {
            "State Name",
            "State Population",
            "State Flag Description",
            "State Colors",
            "State Bird",
            "State Capitol",
            "State Median Income",
            "State IT Jobs Percent"});
            this.sortColumnComboBox.Location = new System.Drawing.Point(303, 436);
            this.sortColumnComboBox.Name = "sortColumnComboBox";
            this.sortColumnComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortColumnComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.sortColumnComboBox, "Selects a value to sort by (i.e. name, population, bird, etc.)");
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(123, 407);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 42);
            this.detailsButton.TabIndex = 5;
            this.detailsButton.Text = "&View Details";
            this.toolTip1.SetToolTip(this.detailsButton, "Opens a form to view the details of the selected state");
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(42, 406);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 43);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "&Add State";
            this.toolTip1.SetToolTip(this.addButton, "Opens a form to enter info for a new state");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(123, 455);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 43);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Exits the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sort Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sort Field";
            // 
            // stateSelectionComboBox
            // 
            this.stateSelectionComboBox.DataSource = this.stateBindingSource;
            this.stateSelectionComboBox.DisplayMember = "STATE_NAME";
            this.stateSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateSelectionComboBox.FormattingEnabled = true;
            this.stateSelectionComboBox.Location = new System.Drawing.Point(59, 377);
            this.stateSelectionComboBox.Name = "stateSelectionComboBox";
            this.stateSelectionComboBox.Size = new System.Drawing.Size(121, 23);
            this.stateSelectionComboBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.stateSelectionComboBox, "Select a state to view the details of");
            this.stateSelectionComboBox.ValueMember = "STATE_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select a State";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(42, 455);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 43);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "&Delete State";
            this.toolTip1.SetToolTip(this.deleteButton, "Deletes the selected state");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // filterColumnComboBox
            // 
            this.filterColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterColumnComboBox.FormattingEnabled = true;
            this.filterColumnComboBox.Items.AddRange(new object[] {
            "State Name",
            "State Population",
            "State Flag Description",
            "State Colors",
            "State Bird",
            "State Flower",
            "State Capitol",
            "State Median Income",
            "State IT Jobs Percent"});
            this.filterColumnComboBox.Location = new System.Drawing.Point(475, 439);
            this.filterColumnComboBox.Name = "filterColumnComboBox";
            this.filterColumnComboBox.Size = new System.Drawing.Size(121, 23);
            this.filterColumnComboBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.filterColumnComboBox, "Selects a value to sort by (i.e. name, population, bird, etc.)");
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(556, 475);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Filter";
            this.toolTip1.SetToolTip(this.filterButton, "Filter the database to only show states that match  the criteria selected/entered" +
        "");
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterOperatorComboBox
            // 
            this.filterOperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterOperatorComboBox.FormattingEnabled = true;
            this.filterOperatorComboBox.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">",
            "is not",
            "contains"});
            this.filterOperatorComboBox.Location = new System.Drawing.Point(602, 439);
            this.filterOperatorComboBox.Name = "filterOperatorComboBox";
            this.filterOperatorComboBox.Size = new System.Drawing.Size(78, 23);
            this.filterOperatorComboBox.TabIndex = 15;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(686, 439);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 22);
            this.filterTextBox.TabIndex = 16;
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Location = new System.Drawing.Point(637, 475);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(75, 23);
            this.resetFilterButton.TabIndex = 17;
            this.resetFilterButton.Text = "Reset";
            this.toolTip1.SetToolTip(this.resetFilterButton, "Resets the filter so that every state will show");
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filter Field";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Operator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Criteria";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterOperatorComboBox);
            this.Controls.Add(this.filterColumnComboBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateSelectionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.sortColumnComboBox);
            this.Controls.Add(this.sortOrderComboBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.stateDataGridView);
            this.Controls.Add(this.stateBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingNavigator)).EndInit();
            this.stateBindingNavigator.ResumeLayout(false);
            this.stateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private StateDBDataSetTableAdapters.STATETableAdapter stateTableAdapter;
        private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView stateDataGridView;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.ComboBox sortColumnComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stateSelectionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox filterColumnComboBox;
        private System.Windows.Forms.ComboBox filterOperatorComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

