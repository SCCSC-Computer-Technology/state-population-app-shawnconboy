using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyLab3
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void stateInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInformationDBDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInformationDBDataSet.StateInformation'
            // table. You can move, or remove it, as needed.
            this.stateInformationTableAdapter.Fill(this.stateInformationDBDataSet.StateInformation);
            stateListbox.SelectedIndex = -1;
        }

        // user can press open database button to open databaseForm
        private void openDatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseForm databaseForm = new DatabaseForm();
            databaseForm.ShowDialog();
        }

        // let user select state from list
        // once state is selected, user must click confirm button
        // confirm button loads selected state's data on detailForm

        private void confirmButton_Click(object sender, EventArgs e)
        {

            if (stateListbox.SelectedItem == null)
            {
                // nothing was selected.
                MessageBox.Show("Please select a state.");
                return;
            }

            // this sets the selected item from the listbox as "stateName" variable
            string stateName = stateListbox.GetItemText(stateListbox.SelectedItem);

            // this creates the new detail form object and passes that selected 
            // state name over when it opens
            DetailForm detailForm = new DetailForm(stateName);
            detailForm.ShowDialog();
        }
    }
}
