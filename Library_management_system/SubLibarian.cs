﻿using System;
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
    public partial class SubLibarian : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();
        public SubLibarian()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddBook F2 = new AddBook();
            this.Hide();
            F2.ShowDialog();
            this.Show();
        }

        private void SubLibarian_Load(object sender, EventArgs e)
        {

        }

        private void view_button_Click(object sender, EventArgs e)
        {
            viewbooks F2 = new viewbooks();
            this.Hide();
            F2.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBorrow F2 = new checkBorrow();
            this.Hide();
            F2.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnBook F2 = new returnBook();
            this.Hide();
            F2.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
