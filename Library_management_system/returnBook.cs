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
    public partial class returnBook : Form
    {
        private project_libraryEntities DB = new project_libraryEntities();
        public returnBook()
        {
            InitializeComponent();
        }
        private void returnBook_Load(object sender, EventArgs e)
        {
            var book = (from Bbo in DB.Book_borrowed
                        where Bbo.return_date == null
                        select new
                        {
                            Bbo.brBook_ID,
                            Bbo.BookID,
                            Bbo.Borrower_ID,
                            Bbo.Book.ISBN,
                            Bbo.Book.title,
                            Bbo.Book.price,
                            Bbo.brBook_date,
                            Bbo.expected_return
                        }).ToList();
            dataGridView1.DataSource = book;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Please select book!!");
                    return;
                }
            int brid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
            double price = Convert.ToDouble(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString());
            int br_bookid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            int book_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
               
                var br_1= (from br_11 in DB.Book_borrowed
                           where br_11.brBook_ID == brid
                           select br_11).FirstOrDefault();
            br_1.return_date = DateTime.Now;
                var book = (from dd in DB.Book
                            where dd.BookID == br_bookid
                            select dd).FirstOrDefault();
                if (br_1.expected_return < DateTime.Now)
                {
                    var borrower_ex = (from dBB in DB.Borrower
                                    where dBB.Borrower_ID == brid
                                    select dBB).FirstOrDefault();
                borrower_ex.date_count = borrower_ex.date_count + 1;
                    if (borrower_ex.date_count == 3)
                    {
                    borrower_ex.date_count = 0;
                    borrower_ex.block_date = DateTime.Now.AddYears(1);
                    borrower_ex.block_user = true;
                    }

                    double days = (DateTime.Now - br_1.expected_return).Value.TotalDays;
                    pay_fines fines = new pay_fines();
                    fines.delay_days = (int)days;
                    if (days <= 30)
                    {
                        fines.fines_ID = 1;
                        fines.payment = (int)days * 10;
                        book.BookState_number = 1;
                    }
                    else 
                    {
                        fines.fines_number = 2;
                        fines.payment = price * 2;
                    borrower_ex.notAllowed_user = true;
                        book.BookState_number = 3;
                    }
                    DB.pay_fines.Add(fines);
                }
                else
                {
                    book.BookState_number = 1;
                }
                DB.SaveChanges();
                MessageBox.Show("Book return Successfuly");
                Close();
            }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

