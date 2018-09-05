using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace School
{
    public partial class studentfees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
        SqlCommand cmd;
        string query;
        public studentfees()
        {
            InitializeComponent();
        }

      

private void button1_Click(object sender, EventArgs e)
        {

            query = "Insert into studentfees(paymentid, date,class,studentname,paymentmode,amount) values('" + txt_paymentid.Text + "', '" + txt_date.Text + "', '" + txt_class.Text + "','" + txt_studentname.Text + "','" + txt_paymentmodee.Text + "','" + txt_amount.Text + "')";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("students fees created successfully");
        }
    }
}
