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
    public partial class BorrowBooks : Form
    {
        private project_libraryEntities DB = new project_libraryEntities();
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("please select!");
                return;

            }

            int book_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            int borrower_id = Program.id;
            Book_borrowed BbbaceR = new Book_borrowed();
            BbbaceR.BookID = book_id;
            BbbaceR.Borrower_ID = borrower_id;
            BbbaceR.brBook_date = DateTime.Now;
            BbbaceR.expected_return = DateTime.Now.AddMonths(1);
            DB.Book_borrowed.Add(BbbaceR);
            var bor= (from x in DB.Book

                      where x.BookID == book_id
                     select x).FirstOrDefault();
            bor.BookState_number = 2;
            DB.SaveChanges();
            Close(); }
        private void BorrowBooks_Load(object sender, EventArgs e)
        {

            var display = from book in DB.Book
                          where book.BookState_number == 1
                          select new { book.BookID, book.ISBN, book.title, book.author, book.edition, book.price, book.StateBook.book_state };

            dataGridView1.DataSource = display.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
