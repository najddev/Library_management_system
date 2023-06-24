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
    public partial class BorrowerLogin : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();
        public BorrowerLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)

        { if (PWBorrower.Text.Trim() != "" && UNBorrower.Text.Trim() != "")
            {
                var Borrower = DBase.Borrower.Where(element => element.Br_UN
                == UNBorrower.Text.Trim()
                && element.Br_pass == PWBorrower.Text.Trim()).FirstOrDefault();
                if (Borrower == null)
                {
                    UNBorrower.Text = PWBorrower.Text = " ";
                    MessageBox.Show("incorrect password or username ,Please try again.");

                }

                else if (Borrower.notAllowed_user == true)
                {
                    MessageBox.Show("this account is not allowed to enter.");
                }

                else if (Borrower.block_user == true && Borrower.block_date > DateTime.Now)
                {
                    MessageBox.Show("this account is blocked for date." + (Borrower.block_date));
                }
                
                else { 
                    Program.id = Borrower.Borrower_ID;
                     SubBorrower frm = new SubBorrower();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                } 
            }  else
            {
                MessageBox.Show("please Enter UserName and PassWord");
            }


        }

        private void UNBorrower_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BorrowerF_Load(object sender, EventArgs e)
        {

        }

        private void PWBorrower_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
