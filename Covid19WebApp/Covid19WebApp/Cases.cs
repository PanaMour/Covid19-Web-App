using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19WebApp
{
    public class Cases
    {
        public int ID { get; set; }
        public String Fullname { get; set; }
        public String Email { get; set; }
        public String Phonenumber { get; set; }
        public String Gender { get; set; }
        public int Age { get; set; }
        public String Diseases { get; set; }
        public String Address { get; set; }
        public String Dateofcase { get; set; }

        public Cases(int id, String fullname, String email, String phonenumber, String gender, int age, String diseases, String address, String dateofcase)
        {
            ID = id;
            Fullname = fullname;
            Email = email;
            Phonenumber = phonenumber;
            Gender = gender;
            Age = age;
            Diseases = diseases;
            Address = address;
            Dateofcase = dateofcase;
        }
    }
}