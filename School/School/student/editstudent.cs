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

namespace StudentEdit
{
    public partial class editstudent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
        SqlDataAdapter da;
        DataSet ds = new System.Data.DataSet();
        string query;

        public editstudent()
        {
            InitializeComponent();
        }

        private void editstudent_Load(object sender, EventArgs e)
        {
            txtfathername.Enabled = false;
            txtmothername.Enabled = false;
            cb_date.Enabled = false;
            cb_month.Enabled = false;
            cb_year.Enabled = false;
            rb_male.Enabled = false;
            rb_female.Enabled = false;
            //cb_class.Enabled = false;
            txtcontactno.Enabled = false;
            txthno.Enabled = false;
            txtcity.Enabled = false;
            txtaddress1.Enabled = false;
            txtaddress2.Enabled = false;
            txtstate.Enabled = false;
            txtpincode.Enabled = false;
            btn_update.Visible = false;
            btn_close.Visible = false;
            btn_reset.Visible = false;
            btn_Edit.Visible = false;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_get_details_Click(object sender, EventArgs e)
        {
            query = "Select * from student where studname='" + txtname.Text + "' and rollno='" + txtrollno.Text + "' and class='" + cb_class.Text + "'";
            da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtfathername.Text = ds.Tables[0].Rows[0]["fathername"].ToString();
                txtmothername.Text = ds.Tables[0].Rows[0]["mothername"].ToString();
                cb_date.Visible = false;
                cb_month.Visible = false;
                cb_year.Visible = false;
                lbl_dob.Text = ds.Tables[0].Rows[0]["dob"].ToString();
                txtcontactno.Text= ds.Tables[0].Rows[0]["contact"].ToString();
                txthno.Text = ds.Tables[0].Rows[0]["hno"].ToString();
                txtcity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                txtaddress1.Text = ds.Tables[0].Rows[0]["address1"].ToString();
                txtaddress2.Text = ds.Tables[0].Rows[0]["address2"].ToString();
                txtstate.Text = ds.Tables[0].Rows[0]["state"].ToString();
                txtpincode.Text = ds.Tables[0].Rows[0]["pincode"].ToString();
                btn_get_details.Visible = false;
                btn_update.Visible = false;
                btn_Edit.Visible = true;
                btn_reset.Visible = true;
                btn_close.Visible = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            btn_get_details.Visible = false;
            btn_update.Visible = true;
            btn_Edit.Visible = false;
            btn_reset.Visible = true;
            btn_close.Visible = true;
            lbl_dob.Visible = false;
            cb_date.Visible = true;
            cb_month.Visible = true;
            cb_year.Visible = true;

            txtfathername.Enabled = true;
            txtmothername.Enabled = true;
            cb_date.Enabled = true;
            cb_month.Enabled = true;
            cb_year.Enabled = true;
            rb_male.Enabled = true;
            rb_female.Enabled = true;
            //cb_class.Enabled = false;
            txtcontactno.Enabled = true;
            txthno.Enabled = true;
            txtcity.Enabled = true;
            txtaddress1.Enabled = true;
            txtaddress2.Enabled = true;
            txtstate.Enabled = true;
            txtpincode.Enabled = true;
            btn_update.Visible = true;
            btn_close.Visible = true;
            btn_reset.Visible = true;
            btn_Edit.Visible = true;
        }

    }
}
