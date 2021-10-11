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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MembersForm membersForm = new MembersForm();
            membersForm.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.Show();
        }
    }
}
