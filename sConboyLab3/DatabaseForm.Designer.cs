namespace sConboyLab3
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.stateInformationDBDataSet = new sConboyLab3.StateInformationDBDataSet();
            this.stateInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInformationTableAdapter = new sConboyLab3.StateInformationDBDataSetTableAdapters.StateInformationTableAdapter();
            this.tableAdapterManager = new sConboyLab3.StateInformationDBDataSetTableAdapters.TableAdapterManager();
            this.stateInformationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stateInformationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateInformationDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sortByDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.filterDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingNavigator)).BeginInit();
            this.stateInformationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(588, 715);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // stateInformationDBDataSet
            // 
            this.stateInformationDBDataSet.DataSetName = "StateInformationDBDataSet";
            this.stateInformationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateInformationBindingSource
            // 
            this.stateInformationBindingSource.DataMember = "StateInformation";
            this.stateInformationBindingSource.DataSource = this.stateInformationDBDataSet;
            // 
            // stateInformationTableAdapter
            // 
            this.stateInformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateInformationTableAdapter = this.stateInformationTableAdapter;
            this.tableAdapterManager.UpdateOrder = sConboyLab3.StateInformationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateInformationBindingNavigator
            // 
            this.stateInformationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stateInformationBindingNavigator.BindingSource = this.stateInformationBindingSource;
            this.stateInformationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateInformationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stateInformationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stateInformationBindingNavigatorSaveItem});
            this.stateInformationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateInformationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateInformationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateInformationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateInformationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateInformationBindingNavigator.Name = "stateInformationBindingNavigator";
            this.stateInformationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateInformationBindingNavigator.Size = new System.Drawing.Size(1250, 25);
            this.stateInformationBindingNavigator.TabIndex = 1;
            this.stateInformationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
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
            // stateInformationBindingNavigatorSaveItem
            // 
            this.stateInformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stateInformationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stateInformationBindingNavigatorSaveItem.Image")));
            this.stateInformationBindingNavigatorSaveItem.Name = "stateInformationBindingNavigatorSaveItem";
            this.stateInformationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stateInformationBindingNavigatorSaveItem.Text = "Save Data";
            this.stateInformationBindingNavigatorSaveItem.Click += new System.EventHandler(this.stateInformationBindingNavigatorSaveItem_Click);
            // 
            // stateInformationDataGridView
            // 
            this.stateInformationDataGridView.AutoGenerateColumns = false;
            this.stateInformationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stateInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateInformationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.stateInformationDataGridView.DataSource = this.stateInformationBindingSource;
            this.stateInformationDataGridView.Location = new System.Drawing.Point(24, 241);
            this.stateInformationDataGridView.Name = "stateInformationDataGridView";
            this.stateInformationDataGridView.Size = new System.Drawing.Size(1203, 451);
            this.stateInformationDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn3.HeaderText = "Population";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Flag_Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Flag_Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Flower";
            this.dataGridViewTextBoxColumn5.HeaderText = "Flower";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Bird";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bird";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Colors";
            this.dataGridViewTextBoxColumn7.HeaderText = "Colors";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Three_Largest_Cities";
            this.dataGridViewTextBoxColumn8.HeaderText = "Three_Largest_Cities";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Capitol";
            this.dataGridViewTextBoxColumn9.HeaderText = "Capitol";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Median_Income";
            this.dataGridViewTextBoxColumn10.HeaderText = "Median_Income";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Percent_Tech_Jobs";
            this.dataGridViewTextBoxColumn11.HeaderText = "Percent_Tech_Jobs";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "State Information Databse";
            // 
            // sortByDropdown
            // 
            this.sortByDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByDropdown.FormattingEnabled = true;
            this.sortByDropdown.Items.AddRange(new object[] {
            "Name",
            "Population",
            "Flower",
            "Bird",
            "Capitol",
            "Median Income",
            "Tech Job Percentage"});
            this.sortByDropdown.Location = new System.Drawing.Point(24, 125);
            this.sortByDropdown.Name = "sortByDropdown";
            this.sortByDropdown.Size = new System.Drawing.Size(121, 21);
            this.sortByDropdown.TabIndex = 4;
            this.sortByDropdown.SelectedIndexChanged += new System.EventHandler(this.sortByDropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort By";
            // 
            // searchDropdown
            // 
            this.searchDropdown.FormattingEnabled = true;
            this.searchDropdown.Items.AddRange(new object[] {
            "All Fields",
            "State Name",
            "Capitol",
            "Flower",
            "Bird",
            "Colors",
            "Largest Cities"});
            this.searchDropdown.Location = new System.Drawing.Point(198, 125);
            this.searchDropdown.Name = "searchDropdown";
            this.searchDropdown.Size = new System.Drawing.Size(121, 21);
            this.searchDropdown.TabIndex = 6;
            this.searchDropdown.SelectedIndexChanged += new System.EventHandler(this.searchDropdown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search By";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(358, 122);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(152, 22);
            this.searchTextbox.TabIndex = 8;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // filterDropdown
            // 
            this.filterDropdown.FormattingEnabled = true;
            this.filterDropdown.Items.AddRange(new object[] {
            "All Records",
            "Highest Population",
            "Lowest Population",
            "Highest Median Income",
            "Lowest Median Income",
            "Highest Tech Job Percentage",
            "Lowest Tech Job Percentage"});
            this.filterDropdown.Location = new System.Drawing.Point(573, 125);
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.Size = new System.Drawing.Size(197, 21);
            this.filterDropdown.TabIndex = 9;
            this.filterDropdown.SelectedIndexChanged += new System.EventHandler(this.filterDropdown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filter Options";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 771);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filterDropdown);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortByDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateInformationDataGridView);
            this.Controls.Add(this.stateInformationBindingNavigator);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingNavigator)).EndInit();
            this.stateInformationBindingNavigator.ResumeLayout(false);
            this.stateInformationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private StateInformationDBDataSet stateInformationDBDataSet;
        private System.Windows.Forms.BindingSource stateInformationBindingSource;
        private StateInformationDBDataSetTableAdapters.StateInformationTableAdapter stateInformationTableAdapter;
        private StateInformationDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateInformationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stateInformationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stateInformationDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortByDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox filterDropdown;
        private System.Windows.Forms.Label label4;
    }
}