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
    public partial class LibrarianLogin : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();
        public LibrarianLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            //  تشيل المسافات الي ممكن يحطها اليوزر عند التسجيل 
            if(PWLibarian.Text.Trim()!=""&&UNLibarain.Text.Trim() !="")
            {
                var Libarian = DBase.Libarian.Where(element => element.libarian_UN
                == UNLibarain.Text.Trim() 
                && element.libarian_pass == PWLibarian.Text.Trim()).FirstOrDefault();
                if(Libarian == null)

                {
                    MessageBox.Show("incorrect password or username ,Please try again.");

                }

                else
                {
                    SubLibarian F1 = new SubLibarian();
                    this.Hide();
                    F1.ShowDialog();
                    this.Show();
                 }
                 }
                  else
                 {
                MessageBox.Show("please Enter UserName and PassWord");

                  }

        }

        private void UNLibarain_TextChanged(object sender, EventArgs e)
        {

        }

        private void PWLibarian_TextChanged(object sender, EventArgs e)
        {

        }

        private void Librarian_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
