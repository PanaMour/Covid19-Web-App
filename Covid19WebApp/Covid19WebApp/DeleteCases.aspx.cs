using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid19WebApp
{
    public partial class DeleteCases : System.Web.UI.Page
    {
        //Για να βρούμε που είναι η βάση δεδομένων χρησιμοποιούμε το AppDomain.CurrentDomain.BaseDirectory που βρίσκει τον κατάλογο στον οποίο βρίσκεται η ιστοσελίδα μας και προσθέτουμε το /bin/CovidDB.mb για να βρούμε που είναι η βάση μας
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "/bin/CovidDB.mdb";
        OleDbConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Ελέγχω αν το textbox έχει συμπληρωθεί
            if (!TextBox9.Equals(""))
            {
                //Διαγράφω από την βάση τα κρούσματα με το όνομα που μας έδωσε ο χρήστης
                String deletequery = "DELETE FROM Cases WHERE [Full Name] = @fullname";
                OleDbCommand delcommand = new OleDbCommand(deletequery, connection);
                delcommand.Parameters.AddWithValue("@fullname", TextBox9.Text);
                connection.Open();
                //εμφανίζουμε κατάλληλο μήνυμα στον χρήστη άμα πραγματοποιήθηκε το delete
                if (delcommand.ExecuteNonQuery() == 1)
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Deleted Case: " + TextBox9.Text + "');", true);
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "There is no case with that name." + "');", true);
                connection.Close();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please fill in all the fields." + "');", true);
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Επιστροφή στην αρχική σελίδα
            Response.Redirect("CovidCasesMainPage.aspx");
        }
    }
}