using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticemakesPerfect
{
    public partial class UpdatedInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["ID"].ToString();


            {
                string connStr = "server= KING-KBK\\SQLEXPRESS2014; Database=Prog117DB; user id=PROG117_web_user; Password=abc123;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                string query = "SELECT * FROM [dbo].[person] WHERE id=" + id;
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;


                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                String fname = reader["firstName"].ToString();
                String lname = reader["lastName"].ToString();
                String uname = reader["userName"].ToString();
                String pword = reader["password"].ToString();
                String address = reader["address"].ToString();
                String email = reader["email"].ToString();
                String pnumber = reader["phone"].ToString();

                conn.Close();



                lbl_fname.Text = fname;
                lbl_lname.Text = lname;
                lbl_uname.Text = uname;
                lbl_pword.Text = pword;
                lbl_address.Text = address;
                lbl_email.Text = email;
                lbl_pnumber.Text = pnumber;

            }
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("\\index.aspx");
        }
    }
}