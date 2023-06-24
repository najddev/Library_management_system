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

    public partial class SearchBook : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();

        public SearchBook()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            var searchBook = from book in DBase.Book
                        where book.BookState_number != 3 && book.title.Contains(textBox1.Text.Trim())
                        select new { book.BookID, book.ISBN, book.title, book.author, book.edition, book.price, book.StateBook.book_state };

            dataGridView1.DataSource = searchBook.ToList();


        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            var searchBook = from book in DBase.Book
                        where book.BookState_number != 3
                        select new { book.BookID, book.ISBN, book.title, book.author, book.edition, book.price, book.StateBook.book_state };

            dataGridView1.DataSource = searchBook.ToList();


        }

        private void cancle_button_Click(object sender, EventArgs e)
        {
            var searchBook = from book in DBase.Book
                        where book.BookState_number != 3
                        select new { book.BookID, book.ISBN, book.title, book.author, book.edition, book.price, book.StateBook.book_state };

            dataGridView1.DataSource = searchBook.ToList();


        }
    }
}
