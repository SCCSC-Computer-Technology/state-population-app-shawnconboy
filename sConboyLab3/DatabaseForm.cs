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
            sortByDropdown.SelectedIndex = 0;
            searchDropdown.SelectedIndex = 0;

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

    // search methods
        // these will let user search and return rows with data that matches up
        private void searchDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        // where the magic happens shawty
        private void ApplySearchFilter()
        {
            // if nothing's selected. do nothing
            if (searchDropdown.SelectedItem == null)
            {
                return;
            }

            // take what's in the textbox
            string searchText = searchTextbox.Text;

            // if textbox is empty, do nothing
            if (searchText == "")
            {
                stateInformationBindingSource.RemoveFilter();
                return;
            }

            // filtering what columns should be searched through
            string selected = searchDropdown.SelectedItem.ToString();
            string filter = "";
            
            if (selected == "All Fields")
            {
                filter = "Name LIKE '%" + searchText + "%' OR " +
                         "Capitol LIKE '%" + searchText + "%' OR " +
                         "Flower LIKE '%" + searchText + "%' OR " +
                         "Bird LIKE '%" + searchText + "%' OR " +
                         "Colors LIKE '%" + searchText + "%' OR " +
                         "Three_Largest_Cities LIKE '%" + searchText + "%' OR " +
                         "Flag_Description LIKE '%" + searchText + "%'";
            }
            else if (selected == "State Name")
            {
                filter = "Name LIKE '%" + searchText + "%'";
            }
            else if (selected == "Capitol")
            {
                filter = "Capitol LIKE '%" + searchText + "%'";
            }
            else if (selected == "Flower")
            {
                filter = "Flower LIKE '%" + searchText + "%'";
            }
            else if (selected == "Bird")
            {
                filter = "Bird LIKE '%" + searchText + "%'";
            }
            else if (selected == "Colors")
            {
                filter = "Colors LIKE '%" + searchText + "%'";
            }
            else if (selected == "Largest Cities")
            {
                filter = "Three_Largest_Cities LIKE '%" + searchText + "%'";
            }
            else if (selected == "Flag Description")
            {
                filter = "Flag_Description LIKE '%" + searchText + "%'";
            }

            // assigns the filter method in the binding source to whichever if statement
            // matched up
            stateInformationBindingSource.Filter = filter;
        }

        private void filterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterDropdown.SelectedItem == null) return;

            string choice = filterDropdown.SelectedItem.ToString();

            if (choice == "All Records")
            {
                stateInformationBindingSource.RemoveFilter();
                stateInformationBindingSource.Sort = "";
            }
            else if (choice == "Highest Population")
            {
                stateInformationBindingSource.Sort = "Population DESC";
            }
            else if (choice == "Lowest Population")
            {
                stateInformationBindingSource.Sort = "Population ASC";
            }
            else if (choice == "Highest Median Income")
            {
                stateInformationBindingSource.Sort = "Median_Income DESC";
            }
            else if (choice == "Lowest Median Income")
            {
                stateInformationBindingSource.Sort = "Median_Income ASC";
            }
            else if (choice == "Highest Tech Job Percentage")
            {
                stateInformationBindingSource.Sort = "Percent_Tech_Jobs DESC";
            }
            else if (choice == "Lowest Tech Job Percentage")
            {
                stateInformationBindingSource.Sort = "Percent_Tech_Jobs ASC";
            }
        }
    }
}
