using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week3
{
    public partial class frmPhoneBook : Form
    {
        public frmPhoneBook()
        {
            InitializeComponent();
        }
    
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtPhone.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsEmpty(txtName) || IsEmpty(txtAddress) || IsEmpty(txtCity) || IsEmpty(txtState) || txtPhone.TextLength != 14)
            {
                MessageBox.Show("Enter data in all fields");
            }
            else
            {
                dgvPhoneBook.Rows.Add(txtName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtPhone.Text);
                int iSelIndex = dgvPhoneBook.Rows.Count - 1;
                dgvPhoneBook.CurrentCell = dgvPhoneBook.Rows[iSelIndex].Cells[0];
            }
        }

        private bool IsEmpty(TextBox tb)
        {
            return tb.TextLength == 0 ? true : false;
        }

        private void dgvPhoneBook_DoubleClick(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you really want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                dgvPhoneBook.Rows.RemoveAt(dgvPhoneBook.SelectedRows[0].Index);
            }
        }

  
        private void dgvPhoneBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhoneBook.SelectedRows.Count > 0)
            {
                txtName.Text = dgvPhoneBook.SelectedRows[0].Cells[0].Value.ToString();
                txtAddress.Text = dgvPhoneBook.SelectedRows[0].Cells[1].Value.ToString();
                txtCity.Text = dgvPhoneBook.SelectedRows[0].Cells[2].Value.ToString();
                txtState.Text = dgvPhoneBook.SelectedRows[0].Cells[3].Value.ToString();
                txtPhone.Text = dgvPhoneBook.SelectedRows[0].Cells[4].Value.ToString();               
            }
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.SelectionStart = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int iSelIndex = dgvPhoneBook.SelectedRows[0].Index;

            dgvPhoneBook.Rows.RemoveAt(iSelIndex);
            dgvPhoneBook.Rows.Insert(iSelIndex, txtName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtPhone.Text);
            dgvPhoneBook.CurrentCell = dgvPhoneBook.Rows[iSelIndex].Cells[0];
        }     
    }
}
