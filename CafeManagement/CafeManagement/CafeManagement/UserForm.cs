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

namespace CafeManagement
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=WAYJI;Initial Catalog=Cafedb;Integrated Security=True;Pooling=False");

        void populate()
        {
            /// con.Open();
            ///SqlCommand c = new SqlCommand("exec GetDb_List", con);
            ///SqlDataAdapter sda = new SqlDataAdapter(c);
            /// var dt = new DataSet();
            ///sda.Fill(dt);
            ///UsersGV.DataSource = dt.Tables[0];
            ///con.Close();

            con.Open();
            SqlCommand c = new SqlCommand("exec GetDB_List", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            UsersGV.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemsForm item = new ItemsForm();
            item.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UsersTbl values ('" + UnameTb.Text+"' ,'" + UphoneTb.Text+"','"+UphoneTb.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully created");
            con.Close();
        }

  

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
