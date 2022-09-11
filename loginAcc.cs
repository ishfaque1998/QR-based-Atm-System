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
   
    public partial class loginAcc : Form
    {

        public static bool flag = false;
        public static String Acc = "";
        string acc = Login.acount1;
        bool flags = false;
        /*string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UseR\Documents\Server.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;*/
        public loginAcc()
        {
            InitializeComponent();

           // con = new SqlConnection(conStr);
            SqlConnection conn = new SqlConnection();
             conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UseR\Documents\Server.mdf;Integrated Security=True;Connect Timeout=30";
            
             conn.Open();
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SELECT AccountNumber FROM [DBO].[Table] ";
             cmd.Connection = conn;
            
             SqlDataReader rd = cmd.ExecuteReader();
            List<String> ClassList = new List<String>();
            try
            {
                while (rd.Read())
                {
                    ClassList.Add(rd[0].ToString());
                }
            }
            catch { }
            finally
            {
                rd.Close();
                conn.Close();
            }
            if (ClassList.Contains(acc))
            {
                flag= true;
            }


        }

        private void otpVerifyHeading_Click(object sender, EventArgs e)
        {

        }

        private void sendOtp_Click(object sender, EventArgs e)
        {
            
            

             SqlConnection conn = new SqlConnection();
             conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UseR\Documents\Server.mdf;Integrated Security=True;Connect Timeout=30";

             conn.Open();
            /*
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = @"Select PassWord From [DBO].[Table]";
             cmd.Connection = conn;
             SqlDataReader dr = cmd.ExecuteReader();
            List<string> pas = new List<string>();
            try
            {
                while (dr.Read())
                {
                    pas.Add(dr[0].ToString());
                }
            }
            catch { }
            finally
            {
                dr.Close();
                conn.Close();
            }
            
            if (pas.Contains(passWord.ToString()))
            {
                flags = true;
            }

            if (flags)
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Pin Code");
            }
            */
            
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from [DBO].[Table] where accountNumber='" + accountNo.Text + "' and password= '" + passWord.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Pin Code doesn't match");
            }
            conn.Close();

            /*  this.Hide();
              Dashboard dashboard = new Dashboard();
              dashboard.ShowDialog();*/
            /* con.Open();
             SqlDataAdapter sda = new SqlDataAdapter("select count(*) from [DBO].[Table] where AccountNumber='" + acc + "' and password= '" + passWord.Text + "'", con);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             if (dt.Rows[0][0].ToString() == "1")
             {
                 this.Hide();
                 Dashboard dashboard = new Dashboard();
                 dashboard.ShowDialog();
                 con.Close();
             }
             else
             {
                 MessageBox.Show("Invalid account or Pin Code doesn't match");
             }
             con.Close();
            */
        }

        private void accountNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginAcc_Load(object sender, EventArgs e)
        {
            // accountNo.Text = Login.acount1;
            this.Hide();
             if (flag)
                Acc = accountNo.Text = Login.acount1;
             else
             {

                 MessageBox.Show("Invalide");
                 this.Close();
                 Login log = new Login();
                 log.ShowDialog();
             }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
