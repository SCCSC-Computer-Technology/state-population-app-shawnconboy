using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sConboyLab3
{
    public partial class DetailForm : Form
    {
        private string selectedState;

        // constructor that receives the state name
        public DetailForm(string stateName)
        {
            InitializeComponent();
            selectedState = stateName;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            // load the table
            this.stateInformationTableAdapter.Fill(this.stateInformationDBDataSet.StateInformation);

            // go through each row to find the "selectedState"
            foreach (DataRow row in this.stateInformationDBDataSet.StateInformation.Rows)
            {
                // find selected state's record, and assign data to textboxes
                if (row["Name"].ToString() == selectedState)
                {
                    nameTextBox.Text = row["Name"].ToString();

                    populationTextBox.Text = Convert.ToInt32(row["Population"]).ToString("N0");

                    flag_DescriptionTextBox.Text = row["Flag_Description"].ToString();

                    flowerTextBox.Text = row["Flower"].ToString();
                    birdTextBox.Text = row["Bird"].ToString();
                    colorsTextBox.Text = row["Colors"].ToString();
                    three_Largest_CitiesTextBox.Text = row["Three_Largest_Cities"].ToString();

                    capitolTextBox.Text = row["Capitol"].ToString();

                    median_IncomeTextBox.Text = Convert.ToDecimal(row["Median_Income"]).ToString("C0");

                    percent_Tech_JobsTextBox.Text = Convert.ToDecimal(row["Percent_Tech_Jobs"]).ToString("0.0") + "%";

                    break;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
