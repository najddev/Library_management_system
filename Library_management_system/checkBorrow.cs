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
    public partial class checkBorrow : Form
    {
        private project_libraryEntities DB = new project_libraryEntities();
        public checkBorrow()
        {
            InitializeComponent();
        }

        private void borrowbooks_Load(object sender, EventArgs e)
        {
            var display = from book in DB.Book
                        where book.BookState_number == 1
                        select new { book.BookID, book.ISBN, book.title, book.author, book.edition, book.price ,book.StateBook.book_state};

            dataGridView1.DataSource = display.ToList();
            

            var borrower = from un in DB.Borrower
                           select un.Br_UN;
            comboBox1.DataSource = borrower.ToList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("please select a book");
                    return;

                }
                
                int book_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                int borrower_id = Convert.ToInt32(comboBox1.SelectedValue);
                Book_borrowed bbace = new Book_borrowed();
            bbace.BookID = book_id;
            bbace.Borrower_ID = borrower_id;
            bbace.brBook_date = DateTime.Now;
            bbace.expected_return = DateTime.Now.AddMonths(1);
                DB.Book_borrowed.Add(bbace);
                var borrowed = (from b in DB.Book
                                where b.BookID == book_id
                                select b).FirstOrDefault();
                                  borrowed.BookState_number = 2;
                                      DB.SaveChanges();
                                           Close();
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}