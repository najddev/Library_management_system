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
    public partial class SubBorrower : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();
        public SubBorrower()
        {
            InitializeComponent();
        }

        private void Borrow_button_Click(object sender, EventArgs e)
        {
            BorrowBooks frm = new BorrowBooks();
           
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_button_Click(object sender, EventArgs e)
        {
           view_BorrowerdBooks frm = new view_BorrowerdBooks();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

    

        private void return_button_Click(object sender, EventArgs e)
        {
            returnBook frm = new returnBook();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SearchBook frm = new SearchBook();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
