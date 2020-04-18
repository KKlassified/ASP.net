using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticemakesPerfect
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string uname = txt_uname.Text;
            string pass = txt_pword.Text;

            //step 1:
            string connStr = "server= SQLEXPRESS2014; Database=Prog117DB; user id=PROG117_web_user; Password=PASSWORD;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //step 2:
            string query = "SELECT [firstName] ,[ID] FROM [dbo].[person] WHERE userName= '" + uname + "' AND password = '"+pass+"'" ;
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            //step 3:
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                String strfname = reader["firstName"].ToString();
                String strID = reader["ID"].ToString(); ;

                Session["ID"] = strID;
                Session["userFirstName"] = strfname;

                lbl_fname.Text = "Welcome:" + "&nbsp;" + strfname; 
            }
            else
            {
                txt_uname.Text = "Login Failed";
                txt_pword.Text = "Try Again";
            }

            conn.Close();

        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("userManagement/setUser.aspx");
        }
    }
}