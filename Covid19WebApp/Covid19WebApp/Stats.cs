using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19WebApp
{
    public class Stats
    {
        List<Cases> caseslist = new List<Cases>();
        double malestat;
        double femalestat;
        double elderlystats;
        double adultsstats;
        double childrenstats;

        public Stats(List<Cases> caseslist)
        {
            //αποθηκεύουμε την λίστα που περιέχει μέσα όλα τα κρούσματα
            this.caseslist = caseslist;
        }

       //Συνάρτηση υπολογισμού στατιστικού αντρικού πληθυσμού
        public double CalculateMaleStat(List<Cases> malelist)
        {
            malestat = ((double)malelist.Count / (double)caseslist.Count) * 100;
            return malestat;
        }
        //Συνάρτηση υπολογισμού στατιστικού γυναικείου πληθυσμού
        public double CalculateFemaleStat(List<Cases> femalelist)
        {
            femalestat = ((double)femalelist.Count / (double)caseslist.Count) * 100;
            return femalestat;
        }
        //Συνάρτηση υπολογισμού στατιστικού ηλικιωμένου πληθυσμού
        public double CalculateElderlyStat(List<Cases> elderlylist)
        {
            elderlystats = ((double)elderlylist.Count / (double)caseslist.Count) * 100;
            return elderlystats;
        }
        //Συνάρτηση υπολογισμού στατιστικού ενήλικου πληθυσμού
        public double CalculateAdultsStat(List<Cases> adultslist)
        {
            adultsstats = ((double)adultslist.Count / (double)caseslist.Count) * 100;
            return adultsstats;
        }
        //Συνάρτηση υπολογισμού στατιστικού ανήλικου πληθυσμού
        public double CalculateChildrenStat(List<Cases> childrenlist)
        {
            childrenstats = ((double)childrenlist.Count / (double)caseslist.Count) * 100;
            return childrenstats;
        }
    }
}