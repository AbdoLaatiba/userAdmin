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
    public partial class User : System.Web.UI.Page
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
            fillRegistedFormation();
            if (!IsPostBack)
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    cmd = new SqlCommand("select * from Formation", cn);
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dropformationList.DataSource = dt;
                    dropformationList.DataTextField = "name";
                    dropformationList.DataValueField = "id";
                    dropformationList.DataBind();
                    fillFormation();
                    
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void fillRegistedFormation()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cmd = new SqlCommand("select * from RegisterFormation where userId = @id", cn);
                cmd.Parameters.AddWithValue("@id", Session["userId"]);
                dr = cmd.ExecuteReader();
                RegisteredFormation.DataSource = dr;
                RegisteredFormation.DataBind();
            }
            finally
            {
                cn.Close();
            }
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
                gvFormationList.DataSource = dr;
                gvFormationList.DataBind();
            }
            finally
            {
                cn.Close();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cmd = new SqlCommand("insert into RegisterFormation values(@user, @formation)", cn);
                cmd.Parameters.AddWithValue("@user", Session["userId"]);
                cmd.Parameters.AddWithValue("@formation", dropformationList.SelectedValue);
                cmd.ExecuteNonQuery();
                fillRegistedFormation();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}