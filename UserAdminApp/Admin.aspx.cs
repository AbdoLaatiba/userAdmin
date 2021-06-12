using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace UserAdminApp
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
                cn = new SqlConnection(@"Data Source=LAATIBA\SQLEXPRESS;Initial Catalog=UserAdmin;Integrated Security=True");
            fillFormation();
            fillUsers();
        }
        private void fillFormation()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cmd = new SqlCommand("select * from Formation", cn);
                dr = cmd.ExecuteReader();
                dgvFormation.DataSource = dr;
                dgvFormation.DataBind();
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void fillUsers()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cmd = new SqlCommand("select * from Users", cn);
                dr = cmd.ExecuteReader();
                dgvUsers.DataSource = dr;
                dgvUsers.DataBind();
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

       

        protected void btnAddFormation_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cmd = new SqlCommand("insert into Formation values(@name, @prix)", cn);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@prix", txtPrix.Text.Trim());
                cmd.ExecuteNonQuery();
                fillFormation();
                cn.Close();
                txtName.Text = txtPrix.Text = "";
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cmd = new SqlCommand("insert into Users values(@name, @email, @role, @pass)", cn);
                cmd.Parameters.AddWithValue("@name", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtUserEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtUserPass.Text.Trim());
                cmd.Parameters.AddWithValue("@role", RadioButtonList1.SelectedValue);

                cmd.ExecuteNonQuery();
                fillUsers();
                cn.Close();
                txtUserName.Text = txtUserEmail.Text = txtUserPass.Text = "";
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}