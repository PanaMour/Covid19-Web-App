using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid19WebApp
{
    public partial class Statistics : System.Web.UI.Page
    {
        //Για να βρούμε που είναι η βάση δεδομένων χρησιμοποιούμε το AppDomain.CurrentDomain.BaseDirectory που βρίσκει τον κατάλογο στον οποίο βρίσκεται η ιστοσελίδα μας και προσθέτουμε το /bin/CovidDB.mb για να βρούμε που είναι η βάση μας
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory +"/bin/CovidDB.mdb";
        OleDbConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
            String query = "Select * from Cases";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            //αρχικοποιούμε όλες τις λίστες που θα χρειαστούμε για να υπολογίσουμε τα στατιστικά
            List<Cases> caseslist = new List<Cases>();
            List<Cases> malelist = new List<Cases>();
            List<Cases> femalelist = new List<Cases>();
            List<Cases> children = new List<Cases>();
            List<Cases> adults = new List<Cases>();
            List<Cases> elderly = new List<Cases>();

            String str;
            String year;
            int age;

            //διαβάζουμε από τη βάση τα κρούσματα
            while (reader.Read())
            {
                str = reader.GetString(5);
                //παίρνουμε τα τελευταία 4 ψηφία του age όπου είναι η ημερομηνία και το κάνουμε integer
                year = str.Substring(str.Length - 4);
                //αφαιρούμε από τον σημερινό χρόνο τον χρόνο γέννησης
                age = DateTime.Today.Year - Int32.Parse(year);
                Cases cases = new Cases(reader.GetInt32(0), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), age, reader.GetString(6).ToString(), reader.GetString(7).ToString(), reader.GetString(8).ToString());
                caseslist.Add(cases);
            }
            reader.Close();
            connection.Close();
            Stats stats = new Stats(caseslist);

            //άμα είναι άντρας το βάζω στο malelist άμα είναι γυναίκα το βάζω στο femalelist
            foreach (Cases element in caseslist)
            {
                if (element.Gender.Equals("Male"))
                {
                    malelist.Add(element);
                }
                else if (element.Gender.Equals("Female"))
                {
                    femalelist.Add(element);
                }
            }

            //προσθέτω τα στατιστικά στα pie charts
            Chart1.Titles.Add("Male/Female Covid Chart");
            Chart1.Series["Series1"].IsValueShownAsLabel = true;
            Chart1.Series["Series1"].Points.AddXY("Male : " + stats.CalculateMaleStat(malelist).ToString() + "%", malelist.Count);
            Chart1.Series["Series1"].Points.AddXY("Female : " + stats.CalculateFemaleStat(femalelist).ToString() + "%", femalelist.Count);
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart1.Series["Series1"].Points[0].Color = Color.Blue;
            Chart1.Series["Series1"].Points[1].Color = Color.HotPink;
            Chart1.Legends[0].Enabled = true;

            //προσθέτω το κρούσμα στην κατάλληλη λίστα ανάλογα την ηλικία
            foreach (Cases element in caseslist)
            {
                if (element.Age >= 60)
                {
                    elderly.Add(element);
                }
                else if (element.Age >= 18)
                {
                    adults.Add(element);
                }
                else
                {
                    children.Add(element);
                }
            }

            //προσθέτω τα στατιστικά στα pie charts
            Chart2.Titles.Add("Age Covid Chart");
            Chart2.Series["Series1"].IsValueShownAsLabel = true;
            Chart2.Series["Series1"].Points.AddXY("Age over 60 : " + stats.CalculateElderlyStat(elderly).ToString() + "%", elderly.Count);
            Chart2.Series["Series1"].Points.AddXY("Age between 18-60 : " + stats.CalculateAdultsStat(adults).ToString() + "%", adults.Count);
            Chart2.Series["Series1"].Points.AddXY("Age under 18 : " + stats.CalculateChildrenStat(children).ToString() + "%", children.Count);
            Chart2.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart2.Series["Series1"].Points[0].Color = Color.DimGray;
            Chart2.Series["Series1"].Points[1].Color = Color.MediumPurple;
            Chart2.Series["Series1"].Points[2].Color = Color.GreenYellow;
            Chart1.Legends[0].Enabled = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Επιστροφή στην αρχική σελίδα
            Response.Redirect("CovidCasesMainPage.aspx");
        }
    }
}