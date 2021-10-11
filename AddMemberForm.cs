using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMPG223GroupProject
{
    public partial class AddMemberForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adap;

        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vanes\source\repos\CMPG223GroupProject\Database1.mdf;Integrated Security = True";
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionstring);
                conn.Open();

                SqlCommand comm = new SqlCommand($"INSERT INTO Member(MEMBER_NAME,DATE_OF_MEMBERSHIP,NR_OF_BOOKS_BORROWED,BOOK_LIMIT) VALUES('{nameTxtbox.Text + " " + surnameTxtbox.Text}','{dateOfMembershipTxtbox.Text}','{booksBorrowedTxtbox.Text}','{bookLimitTxtbox.Text}')", conn);
                adap = new SqlDataAdapter();

                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record added");

                nameTxtbox.Clear();
                surnameTxtbox.Clear();
                dateOfMembershipTxtbox.Clear();
                booksBorrowedTxtbox.Clear();
                bookLimitTxtbox.Clear();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
