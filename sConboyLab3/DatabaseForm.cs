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
    public partial class DatabaseForm : Form
    {
    // built in method
        public DatabaseForm()
        {
            InitializeComponent();
        }
    // built in method "close db form"
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    // built in method "save on click"
        private void stateInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInformationDBDataSet);

        }
    // built in method "fill db on form load"
        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInformationDBDataSet.StateInformation' table. You can move, or remove it, as needed.
            this.stateInformationTableAdapter.Fill(this.stateInformationDBDataSet.StateInformation);

        }

    // sort dropdown menu
        // this method selects an option for sorting the database using Binding Source
        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            String userSelection = sortByDropdown.SelectedItem.ToString();

            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (userSelection == "Name")
            {
                stateInformationBindingSource.Sort = "Name ASC";
            }
            else if (userSelection == "Population")
            {
                stateInformationBindingSource.Sort = "Population DESC";
            }
            else if (userSelection == "Flower")
            {
                stateInformationBindingSource.Sort = "Flower ASC";
            }
            else if (userSelection == "Bird")
            {
                stateInformationBindingSource.Sort = "Bird ASC";
            }
            else if (userSelection == "Capitol")
            {
                stateInformationBindingSource.Sort = "Capitol DESC";
            }
            else if (userSelection == "Median Income")
            {
                stateInformationBindingSource.Sort = "Median_Income DESC";
            }
            else if (userSelection == "Tech Job Percentage")
            {
                stateInformationBindingSource.Sort = "Percent_Tech_Jobs DESC";
            }
        }
    }
}
