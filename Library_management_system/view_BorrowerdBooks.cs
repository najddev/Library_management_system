using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class view_BorrowerdBooks : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();
        public view_BorrowerdBooks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowerdBooks_Load(object sender, EventArgs e)
        {
            var borrowerdbooks = (from books in DBase.Book_borrowed
                               where books.return_date == null && books.Borrower_ID == Program.id
                               select new
                               {
                                   books.BookID,
                                   books.Book.ISBN,
                                   books.Book.title,
                                   books.brBook_date,
                                   books.expected_return
                               }).ToList();
            dataGridView1.DataSource = borrowerdbooks;

        }
    }
}
