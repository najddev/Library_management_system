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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrowerLogin F1= new BorrowerLogin();
            this.Hide();
            F1.ShowDialog();
            this.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianLogin F1 = new LibrarianLogin();
            this.Hide();
            F1.ShowDialog();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
