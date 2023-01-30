using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid19WebApp
{
    public partial class SearchCases : System.Web.UI.Page
    {
        //Για να βρούμε που είναι η βάση δεδομένων χρησιμοποιούμε το AppDomain.CurrentDomain.BaseDirectory που βρίσκει τον κατάλογο στον οποίο βρίσκεται η ιστοσελίδα μας και προσθέτουμε το /bin/CovidDB.mb για να βρούμε που είναι η βάση μας
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "/bin/CovidDB.mdb";
        OleDbConnection connection;
        //Αρχικοποιώ κάποια regular expression για έλεγχο κατα το search
        Regex fnregex = new Regex("^[a-zA-Z][a-zA-Z\\s]+$");
        Regex emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Ελέγχω αν οι απαντήσεις του χρήστη ταιριάζουν σύμφωνα με τα regular expression
            if (fnregex.IsMatch(TextBox10.Text) || emailregex.IsMatch(TextBox11.Text))
            {
                //επιλέγουμε από την βάση το κρούσμα ανάλογα με το fullname ή το email που μας έδωσε ο χρήστης
                String searchquery = "Select * from Cases WHERE [Full Name] = @fullname or [Email] = @email";
                OleDbCommand searchcommand = new OleDbCommand(searchquery, connection);
                searchcommand.Parameters.AddWithValue("@fullname", TextBox10.Text);
                searchcommand.Parameters.AddWithValue("@email", TextBox11.Text);
                connection.Open();
                OleDbDataReader reader = searchcommand.ExecuteReader();

                if (reader.Read())
                {
                    Label2.Text = "ID : " + reader.GetInt32(0).ToString() + "<br>Full Name : " + reader.GetString(1).ToString() + "<br>Email : " + reader.GetString(2).ToString() + "<br>Phone Number : " + reader.GetString(3).ToString() + "<br>Gender : " + reader.GetString(4).ToString() + "<br>Date of Birth : " + reader.GetString(5).ToString() + "<br>Underlying Diseases : " + reader.GetString(6).ToString() + "<br>Address : " + reader.GetString(7).ToString() + "<br>Date of Case : " + reader.GetString(8).ToString();
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "There is no case with that name or email." + "');", true);
                connection.Close();
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please fill in all the fields with the appropriate text." + "');", true);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Επιστροφή στην αρχική σελίδα
            Response.Redirect("CovidCasesMainPage.aspx");
        }
    }
}