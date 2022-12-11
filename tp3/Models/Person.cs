using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp3.Models
{
    public class Person
    {
        public int id { get; set;}
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
      //  public string date_of_birth { get; set; }
        public string image { get; set; }
        public string country { get; set; }

        public Person(int id, string first_name, string last_name, string email, string image, string country)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
       //     this.date_of_birth = date_of_birth;
            this.image = image;
            this.country = country;
        }
    }
}