using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticemakesPerfect
{
    public partial class UpdateInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string id = Session["ID"].ToString();


                
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
                    String lname = reader["lastName"].ToString(); ;
                    String uname = reader["userName"].ToString(); ;
                    String pword = reader["password"].ToString(); ;
                    String address = reader["address"].ToString(); ;
                    String email = reader["email"].ToString(); ;
                    String pnumber = reader["phone"].ToString(); ;
                    

                    conn.Close();

                    txt_fname.Text = fname;
                    txt_lname.Text = lname;
                    txt_uname.Text = uname;
                    txt_pword.Text = pword;
                    txt_address.Text = address;
                    txt_email.Text = email;
                    txt_pnumber.Text = pnumber;

                }
            
        }






        protected void submitButton_Click(object sender, EventArgs e)

        {
            string id = Session["ID"].ToString();


           //  step 2
            string fname = txt_fname.Text;
            string lname = txt_lname.Text;
            string uname = txt_uname.Text;
            string pword = txt_pword.Text;
            string address = txt_address.Text;
            string email = txt_email.Text;
            string pnumber = txt_pnumber.Text;

            string connStr = "server= KING-KBK\\SQLEXPRESS2014; Database=Prog117DB; user id=PROG117_web_user; Password=abc123;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();




            string query = "UPDATE [dbo].[person] SET"
            + "[firstName] = '" + fname + "',"
            + "[lastName] = '" + lname + "',"
            + "[userName] = '" + uname + "',"
            + "[password] = '" + pword + "',"
            + "[address] = '" + address + "',"
            + "[email] = '" + email + "',"
            + "[phone] = '" + pnumber + "'"
            + "WHERE id =" + id;


            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;


            // step 3
            cmd.ExecuteNonQuery();



            conn.Close();

            Response.Redirect("UpdatedInfo.aspx");
            }
        }
    }
