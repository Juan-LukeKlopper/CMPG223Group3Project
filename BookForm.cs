using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223GroupProject
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.Items.Contains(textBoxSearchBook.Text))
            {
                labelSearchBooks.Text = textBoxSearchBook.Text + " || is on the list.";
            }
            else
            {
                MessageBox.Show("The book is not on the List");
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (this.textBoxAddBook.Text != "")
            {
                listBoxBooks.Items.Add(this.textBoxAddBook.Text);
            }
            else
            {
                MessageBox.Show("Please Enter the correct credentials");

            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (this.listBoxBooks.SelectedIndex >= 0)
            {
                listBoxBooks.Items.RemoveAt(this.listBoxBooks.SelectedIndex);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAddBook.Text = "";
            textBoxSearchBook.Text = "";
            labelSearchBooks.Text = "";
        }

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            if (listBoxBooksAvailable.Items.Contains(textBoxSearchBookStudent.Text))
            {
                LabelStudents.Text = textBoxSearchBookStudent.Text + " || is on the list.";
            }
            else
            {
                MessageBox.Show("The Book is not on the List. Please make sure you type the correct book name and reference number");
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (this.textBoxAddBookStudents.Text != "")
            {
                listBoxOrderedBooks.Items.Add(this.textBoxAddBookStudents.Text);
            }
            else
            {
                MessageBox.Show("Please Enter the correct credentials of the book. ");

            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (this.listBoxOrderedBooks.SelectedIndex >= 0)
            {
                listBoxOrderedBooks.Items.RemoveAt(this.listBoxOrderedBooks.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAddBookStudents.Text = "";
            textBoxSearchBookStudent.Text = "";
            LabelStudents.Text = "";
        }
    }
}
