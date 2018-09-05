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
    public partial class addteacher : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
        SqlCommand cmd;
        string query;

        public addteacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dob =txt_dob.Text ;
            string gender;
            if (rb_male.Checked == true)
            {
                gender = rb_male.Text;
            }
            else
            {
                gender = rb_female.Text;
    }
    query = "Insert into Teacher(TeacherName, FatherName, mothername,Dateofbirth,TotalExprience,Gender,Subject,Previousschool) values('" + txt_teachername.Text + "', '" + txt_fathername.Text + "', '" + txt_mothername.Text + "','" + txt_dob.Text + "','" + txt_totexp.Text + "','" + gender + "', '" + txt_subject.Text + "', '" + txt_previous_schoolname .Text + "')";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("teacher created successfully");


        }
    }
}
