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
    public partial class frmDisplayQuery : Form
    {
        public frmDisplayQuery()
        {
            InitializeComponent();
        }

        // LINQ to SQL data context
        private BooksDataContext database = new BooksDataContext();

        private void frmDisplayQuery_Load(object sender, EventArgs e)
        {
            // write SQL to standard output stream
            database.Log = Console.Out;

            // set the ComboBox to show the default query that
            // selects all books from the Titles table
            cmbQuery.SelectedIndex = 0;
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate input fields
            titleBindingSource.EndEdit(); // indicate edits are complete
            database.SubmitChanges(); // write changes to database file
            // when saving, return to "all titles" query
            cmbQuery.SelectedIndex = 0;
        }

        private void cmbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the data displayed according to what is selected
            switch (cmbQuery.SelectedIndex)
            {

                case 0:      // all titles
                    // use LINQ to order the books by title
                    titleBindingSource.DataSource = from book in database.Titles
                                                    orderby book.Title1
                                                    select book;
                    break;
                case 1:      // titles with 2008 copyright
                    // use LINQ to get titles with 2008
                    // copyright and sort them by title
                    titleBindingSource.DataSource = from book in database.Titles
                                                    where book.Copyright == "2008"
                                                    orderby book.Title1
                                                    select book;
                    break;
                case 2:    // titles ending with "How to Program"
                    // use LINQ to get titles ending with
                    // "How to Program" and sort them by title
                    titleBindingSource.DataSource = from book in database.Titles
                                                    where book.Title1.EndsWith("How to Program")
                                                    orderby book.Title1
                                                    select book;

                    // get authors and ISBNs of each book they co-authored
                    //titleBindingSource.DataSource =  from author in database.Authors
                    //                                from book in author.AuthorISBNs
                    //                                orderby author.LastName, author.FirstName
                    //                                select new { author.FirstName, author.LastName, book.ISBN };

                    //EXAMPLE OF JOINS AND YOU CAN CUSTOMIZE YOUR COLUMN NAMES
                    /*
                    titleBindingSource.DataSource = from author in database.Authors
                                                    join authorisbn in database.AuthorISBNs on author.AuthorID equals authorisbn.AuthorID
                                                    join title in database.Titles on authorisbn.ISBN equals title.ISBN
                                                    orderby author.FirstName, author.LastName
                                                    select new {
                                                                 Name = author.FirstName + " " + author.LastName,
                                                                 authorisbn.ISBN,
                                                                 Title  = title.Title1,
                                                                 title.EditionNumber,
                                                                 title.Copyright
                                                    };

                    //SHOWS HOW TO AUTO GENERATE COLUMNS BASED ON DATASET
                    dgvTitle.Columns.Clear();
                    dgvTitle.AutoGenerateColumns = true;
                    dgvTitle.DataSource = titleBindingSource.DataSource;
                    */
                    break;

            }
        }
    }
}
