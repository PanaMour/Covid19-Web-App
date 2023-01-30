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
    public partial class InsertCases : System.Web.UI.Page
    {
        //Για να βρούμε που είναι η βάση δεδομένων χρησιμοποιούμε το AppDomain.CurrentDomain.BaseDirectory που βρίσκει τον κατάλογο στον οποίο βρίσκεται η ιστοσελίδα μας και προσθέτουμε το /bin/CovidDB.mb για να βρούμε που είναι η βάση μας
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "/bin/CovidDB.mdb";
        OleDbConnection connection;
        //Αρχικοποιώ κάποια regular expression για έλεγχο κατα το insert
        Regex fnregex = new Regex("^[a-zA-Z][a-zA-Z\\s]+$");
        Regex emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex numberregex = new Regex(@"^\d{10}$");
        Regex dateregex = new Regex("^(0?[1-9]|[12][0-9]|3[01])[\\/\\-](0?[1-9]|1[012])[\\/\\-]\\d{4}$");
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Ελέγχω αν όλα τα textboxes έχουν συμπληρωθεί
            if (!TextBox1.Text.Equals("") && !TextBox2.Text.Equals("") && !TextBox3.Text.Equals("") && !TextBox5.Text.Equals("") && !TextBox6.Text.Equals("") && !TextBox7.Text.Equals("") && !TextBox8.Text.Equals(""))
            {
                //Ελέγχω αν οι απαντήσεις του χρήστη ταιριάζουν σύμφωνα με τα regular expression
                if (fnregex.IsMatch(TextBox1.Text) && emailregex.IsMatch(TextBox2.Text) && numberregex.IsMatch(TextBox3.Text) && dateregex.IsMatch(TextBox5.Text) && dateregex.IsMatch(TextBox8.Text))
                {
                    //Παρέχει περισσοτερη ασφάλεια σε αντίθεση με το να βάζαμε κατευθείαν τα Textbox.Text
                    String query = "INSERT INTO Cases ([Full Name],[Email],[Phone Number],[Gender],[Date of Birth],[Underlying Diseases],[Address],[Date of Case]) VALUES (@fullname,@email,@phonenumber,@gender,@dateofbirth,@underlyingdisease,@address,@dateofcase)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    //Εισάγουμε τις τιμές στην βάση
                    command.Parameters.AddWithValue("@fullname", TextBox1.Text);
                    command.Parameters.AddWithValue("@email", TextBox2.Text);
                    command.Parameters.AddWithValue("@phonenumber", TextBox3.Text);
                    command.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Text);
                    command.Parameters.AddWithValue("@dateofbirth", TextBox5.Text);
                    command.Parameters.AddWithValue("@underlyingdisease", TextBox6.Text);
                    command.Parameters.AddWithValue("@address", TextBox7.Text);
                    command.Parameters.AddWithValue("@dateofcase", TextBox8.Text);

                    connection.Open();
                    //εμφανίζουμε κατάλληλο μήνυμα στον χρήστη άμα πραγματοποιήθηκε το insert
                    if (command.ExecuteNonQuery() == 1)
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Case Inserted" + "');", true);
                    else
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Unexpected Error Case not inserted" + "');", true);
                    connection.Close();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please fill in all the fields with the appropriate text." + "');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please fill in all the fields." + "');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Επιστροφή στην αρχική σελίδα
            Response.Redirect("CovidCasesMainPage.aspx");
        }
    }
}