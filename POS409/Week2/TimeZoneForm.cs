using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class frmTimeZone : Form
    {
        bool bSelected = false;
        public frmTimeZone()
        {
            InitializeComponent();
        }

        private void frmTimeZone_Load(object sender, EventArgs e)
        {
            //Phase1 shows use of listbox ,switch
            PopulateCities();
            //Phase 2 shows use of timezone and combo box with displayMember and Id
            //PopulateSystemtimeZone();           
        }

        private void PopulateCities()
        {           
            lstCity.Items.Add("Honolulu");
            lstCity.Items.Add("San Francisco");
            lstCity.Items.Add("Denver");
            lstCity.Items.Add("Minneapolis");
            lstCity.Items.Add("New York");
        }

        private void PopulateSystemtimeZone()
        {
            cmbTimeZone.DataSource = TimeZoneInfo.GetSystemTimeZones();
            cmbTimeZone.DisplayMember = "DisplayName";
            cmbTimeZone.ValueMember = "Id";
            bSelected = true;
            TimeZone local = TimeZone.CurrentTimeZone;
            cmbTimeZone.SelectedValue = local.StandardName;
            cmbTimeZone.Refresh();
        }

        private void cmbTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeZone.SelectedIndex > -1 && bSelected)
            {
                TimeZoneInfo selTimeZone = ((System.TimeZoneInfo)(cmbTimeZone.SelectedItem));
                lblSelTimeZone.Text = selTimeZone.Id; 
                //MessageBox.Show("You have selected: " + selTimeZone.DisplayName + " and the Id is " + selTimeZone.Id);                

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string city; // To hold the name of a city

            if (lstCity.SelectedIndex != -1)
            {
                // Get the selected item.
                city = lstCity.SelectedItem.ToString();

                // Determine the time zone.
                switch (city)
                {
                    case "Honolulu":
                        lblCityTimeZone.Text = "Hawaii Standard Time";
                        break;
                    case "San Francisco":
                        lblCityTimeZone.Text = "Pacific Standard Time";
                        break;
                    case "Denver":
                        lblCityTimeZone.Text = "Mountain Standard Time";
                        break;
                    case "Minneapolis":
                        lblCityTimeZone.Text = "Central Standard Time";
                        break;
                    case "New York":
                        lblCityTimeZone.Text = "Eastern Standard Time";
                        break;
                }
            }
            else
            {
                // No city was selected.
                MessageBox.Show("Select a city.");
            }
        }
    }
}
