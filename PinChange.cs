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

namespace ATM
{
    public partial class PinChange : Form
    {
        string pass;
        SqlConnection conn = new SqlConnection();
        public PinChange()
        {
            InitializeComponent();
        }

        private void withDraw_TextChanged(object sender, EventArgs e)
        {
            pass = pinCode.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cnfrm_Click(object sender, EventArgs e)
        {
            if (pass == cnfrmPincode.Text)
            {
                string account = Login.acount1;
                //Setting PIN

                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UseR\Documents\Server.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " update [dbo].[table] set PassWord= '" + pinCode.Text + "' where AccountNumber='" + account + "'";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Successfully PIN Set");


                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }


            else
            {
                MessageBox.Show("Pin Not Matched");
            }
        }
    }
}
