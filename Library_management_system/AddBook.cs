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
    public partial class AddBook : Form
    {
        private project_libraryEntities DBase = new project_libraryEntities();

        public AddBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int edition;
            double price;
                
                    if (textBox1.Text.Trim() == "") {
                        MessageBox.Show("ISBN can not be empty");
                        textBox1.Focus();
             
                    }
                    if (textBox2.Text.Trim() == "")
                    {
                        MessageBox.Show("Title can not be empty ");
                        textBox1.Focus();
                       
                    }
                    if (textBox3.Text.Trim() == "")
                    {
                        MessageBox.Show("Author Name can not be empty ");
                        textBox3.Focus();
                       
                    }
                    if (textBox4.Text.Trim() == "")
                    {
                        MessageBox.Show("Edtition Number can not be empty ");
                        textBox4.Focus();
                       
                    }
                    if (textBox5.Text.Trim() == "")
                    {
                        MessageBox.Show("Price can not be empty ");
                        textBox5.Focus();
                       
                    }
                     try
                      {
                         price = Convert.ToDouble(textBox5.Text);

                      }
                      catch (FormatException formatException)
                      {
                       MessageBox.Show("Price Must be number value");
                       textBox5.Focus();
                       return;
                       }
                     try
                    {
                        edition = Convert.ToInt32(textBox4.Text);

                    }
                    catch (Exception ex) {
                        MessageBox.Show("Edtition Must be number value(not fractioal) ");
                        textBox4.Focus();
                        return;
                    } 
                //data bindig code here 
                    
                      Book book = new Book();
                      book.ISBN=textBox1.Text.Trim();
                      book.title=textBox2.Text.Trim();
                      book.author=textBox3.Text.Trim();
                      book.edition=edition;
                      book.price=price;
                      book.BookState_number=1;
                      DBase.Book.Add(book);
                      DBase.SaveChanges();
                      textBox1.Clear();
                      textBox2.Clear();
                      textBox3.Clear();
                      textBox4.Clear();
                      textBox5.Clear();}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
