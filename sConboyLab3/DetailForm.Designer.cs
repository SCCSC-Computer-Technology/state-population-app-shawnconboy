namespace sConboyLab3
{
    partial class DetailForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label flag_DescriptionLabel;
            System.Windows.Forms.Label flowerLabel;
            System.Windows.Forms.Label birdLabel;
            System.Windows.Forms.Label colorsLabel;
            System.Windows.Forms.Label three_Largest_CitiesLabel;
            System.Windows.Forms.Label capitolLabel;
            System.Windows.Forms.Label median_IncomeLabel;
            System.Windows.Forms.Label percent_Tech_JobsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.stateInformationDBDataSet = new sConboyLab3.StateInformationDBDataSet();
            this.stateInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInformationTableAdapter = new sConboyLab3.StateInformationDBDataSetTableAdapters.StateInformationTableAdapter();
            this.tableAdapterManager = new sConboyLab3.StateInformationDBDataSetTableAdapters.TableAdapterManager();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.Label();
            this.populationTextBox = new System.Windows.Forms.Label();
            this.flowerTextBox = new System.Windows.Forms.Label();
            this.birdTextBox = new System.Windows.Forms.Label();
            this.three_Largest_CitiesTextBox = new System.Windows.Forms.Label();
            this.capitolTextBox = new System.Windows.Forms.Label();
            this.median_IncomeTextBox = new System.Windows.Forms.Label();
            this.percent_Tech_JobsTextBox = new System.Windows.Forms.Label();
            this.flag_DescriptionTextBox = new System.Windows.Forms.Label();
            this.colorsTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            flag_DescriptionLabel = new System.Windows.Forms.Label();
            flowerLabel = new System.Windows.Forms.Label();
            birdLabel = new System.Windows.Forms.Label();
            colorsLabel = new System.Windows.Forms.Label();
            three_Largest_CitiesLabel = new System.Windows.Forms.Label();
            capitolLabel = new System.Windows.Forms.Label();
            median_IncomeLabel = new System.Windows.Forms.Label();
            percent_Tech_JobsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(46, 134);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(46, 224);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(67, 13);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population:";
            // 
            // flag_DescriptionLabel
            // 
            flag_DescriptionLabel.AutoSize = true;
            flag_DescriptionLabel.Location = new System.Drawing.Point(399, 229);
            flag_DescriptionLabel.Name = "flag_DescriptionLabel";
            flag_DescriptionLabel.Size = new System.Drawing.Size(94, 13);
            flag_DescriptionLabel.TabIndex = 7;
            flag_DescriptionLabel.Text = "Flag Description:";
            // 
            // flowerLabel
            // 
            flowerLabel.AutoSize = true;
            flowerLabel.Location = new System.Drawing.Point(401, 136);
            flowerLabel.Name = "flowerLabel";
            flowerLabel.Size = new System.Drawing.Size(45, 13);
            flowerLabel.TabIndex = 9;
            flowerLabel.Text = "Flower:";
            // 
            // birdLabel
            // 
            birdLabel.AutoSize = true;
            birdLabel.Location = new System.Drawing.Point(401, 162);
            birdLabel.Name = "birdLabel";
            birdLabel.Size = new System.Drawing.Size(31, 13);
            birdLabel.TabIndex = 11;
            birdLabel.Text = "Bird:";
            // 
            // colorsLabel
            // 
            colorsLabel.AutoSize = true;
            colorsLabel.Location = new System.Drawing.Point(399, 194);
            colorsLabel.Name = "colorsLabel";
            colorsLabel.Size = new System.Drawing.Size(68, 13);
            colorsLabel.TabIndex = 13;
            colorsLabel.Text = "Flag Colors:";
            // 
            // three_Largest_CitiesLabel
            // 
            three_Largest_CitiesLabel.AutoSize = true;
            three_Largest_CitiesLabel.Location = new System.Drawing.Point(46, 192);
            three_Largest_CitiesLabel.Name = "three_Largest_CitiesLabel";
            three_Largest_CitiesLabel.Size = new System.Drawing.Size(109, 13);
            three_Largest_CitiesLabel.TabIndex = 15;
            three_Largest_CitiesLabel.Text = "Three Largest Cities:";
            // 
            // capitolLabel
            // 
            capitolLabel.AutoSize = true;
            capitolLabel.Location = new System.Drawing.Point(46, 162);
            capitolLabel.Name = "capitolLabel";
            capitolLabel.Size = new System.Drawing.Size(47, 13);
            capitolLabel.TabIndex = 17;
            capitolLabel.Text = "Capitol:";
            // 
            // median_IncomeLabel
            // 
            median_IncomeLabel.AutoSize = true;
            median_IncomeLabel.Location = new System.Drawing.Point(46, 254);
            median_IncomeLabel.Name = "median_IncomeLabel";
            median_IncomeLabel.Size = new System.Drawing.Size(89, 13);
            median_IncomeLabel.TabIndex = 19;
            median_IncomeLabel.Text = "Median Income:";
            // 
            // percent_Tech_JobsLabel
            // 
            percent_Tech_JobsLabel.AutoSize = true;
            percent_Tech_JobsLabel.Location = new System.Drawing.Point(46, 285);
            percent_Tech_JobsLabel.Name = "percent_Tech_JobsLabel";
            percent_Tech_JobsLabel.Size = new System.Drawing.Size(99, 13);
            percent_Tech_JobsLabel.TabIndex = 21;
            percent_Tech_JobsLabel.Text = "Percent Tech Jobs:";
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
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(363, 529);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoSize = true;
            this.nameTextBox.Location = new System.Drawing.Point(177, 134);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(38, 13);
            this.nameTextBox.TabIndex = 24;
            this.nameTextBox.Text = "label1";
            // 
            // populationTextBox
            // 
            this.populationTextBox.AutoSize = true;
            this.populationTextBox.Location = new System.Drawing.Point(177, 224);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(38, 13);
            this.populationTextBox.TabIndex = 24;
            this.populationTextBox.Text = "label1";
            // 
            // flowerTextBox
            // 
            this.flowerTextBox.AutoSize = true;
            this.flowerTextBox.Location = new System.Drawing.Point(528, 136);
            this.flowerTextBox.Name = "flowerTextBox";
            this.flowerTextBox.Size = new System.Drawing.Size(38, 13);
            this.flowerTextBox.TabIndex = 24;
            this.flowerTextBox.Text = "label1";
            // 
            // birdTextBox
            // 
            this.birdTextBox.AutoSize = true;
            this.birdTextBox.Location = new System.Drawing.Point(528, 162);
            this.birdTextBox.Name = "birdTextBox";
            this.birdTextBox.Size = new System.Drawing.Size(38, 13);
            this.birdTextBox.TabIndex = 24;
            this.birdTextBox.Text = "label1";
            // 
            // three_Largest_CitiesTextBox
            // 
            this.three_Largest_CitiesTextBox.AutoSize = true;
            this.three_Largest_CitiesTextBox.Location = new System.Drawing.Point(177, 192);
            this.three_Largest_CitiesTextBox.Name = "three_Largest_CitiesTextBox";
            this.three_Largest_CitiesTextBox.Size = new System.Drawing.Size(38, 13);
            this.three_Largest_CitiesTextBox.TabIndex = 24;
            this.three_Largest_CitiesTextBox.Text = "label1";
            // 
            // capitolTextBox
            // 
            this.capitolTextBox.AutoSize = true;
            this.capitolTextBox.Location = new System.Drawing.Point(177, 162);
            this.capitolTextBox.Name = "capitolTextBox";
            this.capitolTextBox.Size = new System.Drawing.Size(38, 13);
            this.capitolTextBox.TabIndex = 24;
            this.capitolTextBox.Text = "label1";
            // 
            // median_IncomeTextBox
            // 
            this.median_IncomeTextBox.AutoSize = true;
            this.median_IncomeTextBox.Location = new System.Drawing.Point(177, 254);
            this.median_IncomeTextBox.Name = "median_IncomeTextBox";
            this.median_IncomeTextBox.Size = new System.Drawing.Size(38, 13);
            this.median_IncomeTextBox.TabIndex = 24;
            this.median_IncomeTextBox.Text = "label1";
            // 
            // percent_Tech_JobsTextBox
            // 
            this.percent_Tech_JobsTextBox.AutoSize = true;
            this.percent_Tech_JobsTextBox.Location = new System.Drawing.Point(177, 285);
            this.percent_Tech_JobsTextBox.Name = "percent_Tech_JobsTextBox";
            this.percent_Tech_JobsTextBox.Size = new System.Drawing.Size(38, 13);
            this.percent_Tech_JobsTextBox.TabIndex = 24;
            this.percent_Tech_JobsTextBox.Text = "label1";
            // 
            // flag_DescriptionTextBox
            // 
            this.flag_DescriptionTextBox.Location = new System.Drawing.Point(528, 226);
            this.flag_DescriptionTextBox.Name = "flag_DescriptionTextBox";
            this.flag_DescriptionTextBox.Size = new System.Drawing.Size(227, 247);
            this.flag_DescriptionTextBox.TabIndex = 24;
            this.flag_DescriptionTextBox.Text = "label1";
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.AutoSize = true;
            this.colorsTextBox.Location = new System.Drawing.Point(528, 194);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(38, 13);
            this.colorsTextBox.TabIndex = 24;
            this.colorsTextBox.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "State Information";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorsTextBox);
            this.Controls.Add(this.percent_Tech_JobsTextBox);
            this.Controls.Add(this.median_IncomeTextBox);
            this.Controls.Add(this.capitolTextBox);
            this.Controls.Add(this.three_Largest_CitiesTextBox);
            this.Controls.Add(this.birdTextBox);
            this.Controls.Add(this.flowerTextBox);
            this.Controls.Add(this.flag_DescriptionTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(nameLabel);
            this.Controls.Add(populationLabel);
            this.Controls.Add(flag_DescriptionLabel);
            this.Controls.Add(flowerLabel);
            this.Controls.Add(birdLabel);
            this.Controls.Add(colorsLabel);
            this.Controls.Add(three_Largest_CitiesLabel);
            this.Controls.Add(capitolLabel);
            this.Controls.Add(median_IncomeLabel);
            this.Controls.Add(percent_Tech_JobsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateInformationDBDataSet stateInformationDBDataSet;
        private System.Windows.Forms.BindingSource stateInformationBindingSource;
        private StateInformationDBDataSetTableAdapters.StateInformationTableAdapter stateInformationTableAdapter;
        private StateInformationDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nameTextBox;
        private System.Windows.Forms.Label populationTextBox;
        private System.Windows.Forms.Label flowerTextBox;
        private System.Windows.Forms.Label birdTextBox;
        private System.Windows.Forms.Label three_Largest_CitiesTextBox;
        private System.Windows.Forms.Label capitolTextBox;
        private System.Windows.Forms.Label median_IncomeTextBox;
        private System.Windows.Forms.Label percent_Tech_JobsTextBox;
        private System.Windows.Forms.Label flag_DescriptionTextBox;
        private System.Windows.Forms.Label colorsTextBox;
        private System.Windows.Forms.Label label1;
    }
}