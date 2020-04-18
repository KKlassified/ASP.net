using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticemakesPerfect
{
    public partial class Secondpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["ID"].ToString();
            
            {
                string connStr = "server= KING-KBK\\SQLEXPRESS2014; Database=Prog117DB; user id=PROG117_web_user; Password=abc123;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                // step 2

                SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[person] WHERE id=" + id);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                string fname = "";
                string lname = "";
                string uname = "";
                string pword = "";
                string address = "";
                string email = "";
                string pnumber = "";
                string temp = "";
                

                // step 3
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fname += reader["firstName"].ToString();
                    lname += reader["lastName"].ToString();
                    uname += reader["userName"].ToString();
                    pword += reader["password"].ToString();
                    address += reader["address"].ToString();
                    email += reader["email"].ToString();
                    pnumber += reader["phone"].ToString();
                    temp += "</br>";
                }


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

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateInfo.aspx");
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("\\index.aspx");
        }
    }
}