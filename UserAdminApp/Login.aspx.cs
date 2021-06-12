using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace UserAdminApp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(@"Data Source=LAATIBA\SQLEXPRESS;Initial Catalog=UserAdmin;Integrated Security=True");
               txtError.Visible = false;
                txtRegisterError.Visible = false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    cmd = new SqlCommand("select * from Users where email = @email and password=@pass", cn);
                    cmd.Parameters.AddWithValue("@email", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (int.Parse(dr["roleId"].ToString()) == 1)
                            {
                                Session["userId"] = dr["id"];
                                Response.Redirect("Admin.aspx");
                            }else if (int.Parse(dr["roleId"].ToString()) == 2)
                            {
                                Session["userId"] = dr["id"];
                                Response.Redirect("User.aspx");
                            }
                        }
                    }
                    else
                    {
                        txtError.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                if (txtName.Text != "" && txtRegisterEmail.Text != "" && txtRegisterPass.Text != "")
                {
                    cmd = new SqlCommand("insert into Users values(@name, @email, @role, @pass)", cn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtRegisterEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtRegisterPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", 2);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    txtRegisterError.Visible = true;
                }
                
               
                cn.Close();
                txtName.Text = txtRegisterEmail.Text = txtRegisterPass.Text = "";
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}