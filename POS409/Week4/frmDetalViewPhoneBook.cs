using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week4
{
    public partial class frmDVPhoneBook : Form
    {
        public frmDVPhoneBook()
        {
            InitializeComponent();
        }

        private void phoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneBookDataSet);

        }

        private void frmDetalViewPhoenBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneBookDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.phoneBookDataSet.Phone);

        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            this.phoneTableAdapter.SearchByName(this.phoneBookDataSet.Phone, txtSearchName.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.phoneTableAdapter.Fill(this.phoneBookDataSet.Phone);
        }
    }
}
