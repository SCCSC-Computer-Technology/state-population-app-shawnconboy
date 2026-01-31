namespace sConboyLab3
{
    partial class IndexForm
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
            this.stateInformationDBDataSet = new sConboyLab3.StateInformationDBDataSet();
            this.stateInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInformationTableAdapter = new sConboyLab3.StateInformationDBDataSetTableAdapters.StateInformationTableAdapter();
            this.tableAdapterManager = new sConboyLab3.StateInformationDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stateListbox = new System.Windows.Forms.ListBox();
            this.openDatabaseButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "State Information Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select A State To See More Information";
            // 
            // stateListbox
            // 
            this.stateListbox.DataSource = this.stateInformationBindingSource;
            this.stateListbox.DisplayMember = "Name";
            this.stateListbox.FormattingEnabled = true;
            this.stateListbox.Location = new System.Drawing.Point(313, 176);
            this.stateListbox.Name = "stateListbox";
            this.stateListbox.Size = new System.Drawing.Size(175, 225);
            this.stateListbox.TabIndex = 3;
            // 
            // openDatabaseButton
            // 
            this.openDatabaseButton.Location = new System.Drawing.Point(633, 46);
            this.openDatabaseButton.Name = "openDatabaseButton";
            this.openDatabaseButton.Size = new System.Drawing.Size(118, 35);
            this.openDatabaseButton.TabIndex = 5;
            this.openDatabaseButton.Text = "Open Database";
            this.openDatabaseButton.UseVisualStyleBackColor = true;
            this.openDatabaseButton.Click += new System.EventHandler(this.openDatabaseButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.PaleGreen;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(363, 436);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.openDatabaseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stateListbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox stateListbox;
        private System.Windows.Forms.Button openDatabaseButton;
        private System.Windows.Forms.Button confirmButton;
    }
}

