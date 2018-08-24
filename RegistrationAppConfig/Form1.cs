using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace RegistrationAppConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

          
            string query = "INSERT INTO RegisterTable (Name,PhoneNo,EmailId,Address) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            using (SqlConnection con = new SqlConnection(con_string))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" SUBMITTED SUCCESSFULLY!!!!!");

            }

           
        }
    }
}
