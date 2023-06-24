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
    public partial class viewbooks : Form
    {

        private project_libraryEntities DBase = new project_libraryEntities();

        public viewbooks()
        {
            InitializeComponent();
        }

        private void viewbooks_Load(object sender, EventArgs e)
        {
            var display = from book in DBase.Book
                 where book.BookState_number != 3
                 select new { book.BookID, book.ISBN, book.title, book.author, book.edition, book.price, book.StateBook.book_state };

            dataGridView1.DataSource = display.ToList();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}