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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.filterOperatorComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingNavigator)).BeginInit();
            this.stateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateBindingNavigator
            // 
            this.stateBindingNavigator.AddNewItem = null;
            this.stateBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
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
            this.stateDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stateDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.stateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateDataGridView.DataSource = this.stateBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stateDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.stateDataGridView.Location = new System.Drawing.Point(21, 28);
            this.stateDataGridView.MultiSelect = false;
            this.stateDataGridView.Name = "stateDataGridView";
            this.stateDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stateDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.stateDataGridView.RowHeadersVisible = false;
            this.stateDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.stateDataGridView.RowTemplate.Height = 150;
            this.stateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stateDataGridView.Size = new System.Drawing.Size(891, 328);
            this.stateDataGridView.StandardTab = true;
            this.stateDataGridView.TabIndex = 0;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(108, 52);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(58, 43);
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
            this.sortOrderComboBox.Location = new System.Drawing.Point(11, 23);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortOrderComboBox.TabIndex = 0;
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
            "State Capital",
            "State Median Income",
            "State IT Jobs Percent"});
            this.sortColumnComboBox.Location = new System.Drawing.Point(138, 23);
            this.sortColumnComboBox.Name = "sortColumnComboBox";
            this.sortColumnComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortColumnComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.sortColumnComboBox, "Selects a value to sort by (i.e. name, population, bird, etc.)");
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(73, 52);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(56, 42);
            this.detailsButton.TabIndex = 2;
            this.detailsButton.Text = "&View Details";
            this.toolTip1.SetToolTip(this.detailsButton, "Opens a form to view the details of the selected state");
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 52);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 43);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "&Add State";
            this.toolTip1.SetToolTip(this.addButton, "Opens a form to enter info for a new state");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(845, 464);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(76, 43);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Exits the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sort Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 5);
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
            this.stateSelectionComboBox.Location = new System.Drawing.Point(11, 23);
            this.stateSelectionComboBox.Name = "stateSelectionComboBox";
            this.stateSelectionComboBox.Size = new System.Drawing.Size(180, 23);
            this.stateSelectionComboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.stateSelectionComboBox, "Select a state to view the details of");
            this.stateSelectionComboBox.ValueMember = "STATE_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select a State";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteButton.ForeColor = System.Drawing.Color.Maroon;
            this.deleteButton.Location = new System.Drawing.Point(135, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 43);
            this.deleteButton.TabIndex = 3;
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
            "State Capital",
            "State Median Income",
            "State IT Jobs Percent"});
            this.filterColumnComboBox.Location = new System.Drawing.Point(11, 23);
            this.filterColumnComboBox.Name = "filterColumnComboBox";
            this.filterColumnComboBox.Size = new System.Drawing.Size(121, 23);
            this.filterColumnComboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.filterColumnComboBox, "Selects a value to sort by (i.e. name, population, bird, etc.)");
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(92, 52);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 43);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "&Filter";
            this.toolTip1.SetToolTip(this.filterButton, "Filter the database to only show states that match  the criteria selected/entered" +
        "");
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Location = new System.Drawing.Point(173, 52);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(75, 42);
            this.resetFilterButton.TabIndex = 4;
            this.resetFilterButton.Text = "&Reset";
            this.toolTip1.SetToolTip(this.resetFilterButton, "Resets the filter so that every state will show");
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
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
            this.filterOperatorComboBox.Location = new System.Drawing.Point(138, 23);
            this.filterOperatorComboBox.Name = "filterOperatorComboBox";
            this.filterOperatorComboBox.Size = new System.Drawing.Size(78, 23);
            this.filterOperatorComboBox.TabIndex = 1;
            // 
            // filterTextBox
            // 
            this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterTextBox.Location = new System.Drawing.Point(222, 23);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 22);
            this.filterTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filter By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Filter Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Value";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.detailsButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.stateSelectionComboBox);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Location = new System.Drawing.Point(21, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 105);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sortOrderComboBox);
            this.panel2.Controls.Add(this.sortButton);
            this.panel2.Controls.Add(this.sortColumnComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(229, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 105);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.filterColumnComboBox);
            this.panel3.Controls.Add(this.filterButton);
            this.panel3.Controls.Add(this.filterOperatorComboBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.filterTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.resetFilterButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(505, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 105);
            this.panel3.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AcceptButton = this.detailsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stateDataGridView);
            this.Controls.Add(this.stateBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Speich-CPT-206-A01S-Lab-3: State Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingNavigator)).EndInit();
            this.stateBindingNavigator.ResumeLayout(false);
            this.stateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateBindingSource;
        //private StateDBDataSetTableAdapters.STATETableAdapter stateTableAdapter;
        //private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

