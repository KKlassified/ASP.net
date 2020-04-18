using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticemakesPerfect
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
           

            {
                string connStr = "server= KING-KBK\\SQLEXPRESS2014; Database=Prog117DB; user id=PROG117_web_user; Password=abc123;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                // step 2
                string fname = txt_fname.Text;
                string lname = txt_lname.Text;
                string uname = txt_uname.Text;
                string pword = txt_pword.Text;
                string address = txt_address.Text;
                string email = txt_email.Text;
                string pnumber = txt_pnumber.Text;

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[person]([firstName],[lastName],[userName],[password],[address],[email],[phone])" +
                "VALUES( '" + fname + "' , '" + lname + "',  '" + uname + "',  '" + pword + "',  '" + address + "',  '" + email + "',  '" + pnumber + "') SELECT SCOPE_IDENTITY() as id;");
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;


                // step 3
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();


                string id = reader[0].ToString();

                

                conn.Close();
                Session["ID"] = id;
            }

            Response.Redirect("confirmUser.aspx");
        }
    }
}