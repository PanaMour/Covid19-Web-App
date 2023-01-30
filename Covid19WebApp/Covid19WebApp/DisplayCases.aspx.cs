using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid19WebApp
{
    public partial class DisplayCases : System.Web.UI.Page
    {
        //Για να βρούμε που είναι η βάση δεδομένων χρησιμοποιούμε το AppDomain.CurrentDomain.BaseDirectory που βρίσκει τον κατάλογο στον οποίο βρίσκεται η ιστοσελίδα μας και προσθέτουμε το /bin/CovidDB.mb για να βρούμε που είναι η βάση μας
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "/bin/CovidDB.mdb";
        OleDbConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
            //Επιλέγουμε όλα τα δεδομένα της βάσης
            String query = "Select * from Cases";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            connection.Open();
            //μέσω του reader διαβάζουμε τα δεδομένα από την βάση
            OleDbDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            //βάζουμε τα δεδομένα μέσα στο GridView ώστε να εμφανίζονται στον χρήστη
            GridView1.DataBind();
            reader.Close();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CovidCasesMainPage.aspx");
        }
    }
}