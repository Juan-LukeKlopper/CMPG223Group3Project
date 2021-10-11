using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMPG223GroupProject
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommand comm;

        public SqlConnection Conn { get => conn; set => conn = value; }

        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vanes\source\repos\CMPG223GroupProject\Database1.mdf;Integrated Security = True";

        public void loadAll()
        {

            conn = new SqlConnection(connectionstring);
            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Member";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "Member");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Member";

            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(connectionstring);

                string delete_query = "DELETE FROM Member WHERE MEMBER_NAME ='" + textBox2.Text + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(delete_query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Record deleted");
                textBox2.Text = "";

                loadAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMemberForm addMember = new AddMemberForm();
            addMember.ShowDialog();
            loadAll();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = @"SELECT * FROM Member WHERE MEMBER_NAME LIKE '%" + searchBox.Text + "%'";

                SqlCommand comm = new SqlCommand(sql, conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "Member");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Member";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
