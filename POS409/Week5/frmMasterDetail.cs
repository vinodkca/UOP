using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week5
{
    public partial class frmMasterDetail : Form
    {
        public frmMasterDetail()
        {
            InitializeComponent();
        }

        // connection to database
        private BooksDataContext database = new BooksDataContext();

        // this class helps us display each author's first
        // and last name in the authors drop-down list
        private class AuthorBinding
        {
            public Author Author { get; set; } // contained Author object
            public string Name { get; set; } // author's full name
        }

        private void frmMasterDetail_Load(object sender, EventArgs e)
        {
            // display AuthorBinding.Name
            cmbAuthor.DisplayMember = "Name";

            // set authorComboBox's DataSource to the list of authors

            cmbAuthor.DataSource =
                                 from author in database.Authors
                                 orderby author.LastName, author.FirstName
                                 select new AuthorBinding
                                 {
                                     Author = author,
                                     Name = author.FirstName + " " + author.LastName
                                 };
            // display Title.Title1
            cmbTitle.DisplayMember = "Title1";

            // set titleComboBox's DataSource to the list of titles
            cmbTitle.DataSource =
                                        from title in database.Titles
                                        orderby title.Title1
                                        select title;
            //initially, display no "detail" data
            dgvBooksMaster.DataSource = null;

        }

        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected Author object from the ComboBox
            Author currentAuthor =
                    ((AuthorBinding)cmbAuthor.SelectedItem).Author;

            // set titleBindingSource's DataSource to the
            // list of titles written by the selected author
            // display the titles in the DataGridView
            dgvBooksMaster.Columns.Clear();
            dgvBooksMaster.AutoGenerateColumns = true;

            titleBindingSource.DataSource =
                                        from book in currentAuthor.AuthorISBNs
                                        select book.Title;

            dgvBooksMaster.DataSource = titleBindingSource;
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected Title object from the ComboBox
            Title currentTitle = (Title)cmbTitle.SelectedItem;
          
            // set authorBindingSource's DataSource to the
            // list of authors for the selected title
            authorBindingSource.DataSource =
                                        from book in currentTitle.AuthorISBNs
                                        select book.Author;

            //display the authors in the DataGridView
            dgvBooksMaster.DataSource = authorBindingSource;
        }            
    }
}
