using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace tp3.Models
{
    public class Personal_info
    {
       
        
        public List<Person> GetallPerson() {
            List<Person> list = new List<Person>();
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\ad\\Desktop\\GL3\\Framework\\2022 GL3 .NET Framework TP3 - SQLite database.db;"))
                {
                    sqlcon.Open();
                    Debug.WriteLine("Conection opened ");

                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info ", sqlcon);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        Debug.WriteLine("Data reader  returned " + reader.FieldCount + " Colums");
                         if (reader.HasRows)
                         {
                        while (reader.Read())
                        {
                            list.Add(new Person((int)reader["id"], (string)reader["first_name"], (string)reader["last_name"], (string)reader["email"], (string)reader["image"], (string)reader["country"]));
                        }

                        }
               
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erreur :" + e.Message);
            }
            return list;

        }
        public Person GetPerson(int id) {
            /* try
           {
              using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\ad\\Desktop\\GL3\\Framework\\2022 GL3 .NET Framework TP3 - SQLite database.db;"))
               {
                   sqlcon.Open();
                   Debug.WriteLine("Conection opened ");

                   SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info WHERE id="+id, sqlcon) ;
                   using (SQLiteDataReader reader = command.ExecuteReader())
                   {
                       Debug.WriteLine("Data reader  returned " + reader.FieldCount + " Colums");
                       if (reader.HasRows)
                       {
                      return new Person((int)reader["id"], (string)reader["first_name"], (string)reader["last_name"], (string)reader["email"], (string)reader["image"], (string)reader["country"]);

                       }

                   }
               }
           }
           catch (Exception e)
           {
               Debug.WriteLine("Erreur :" + e.Message);
           }

           return null; */
            List<Person> list = GetallPerson();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    return list[i];
                }
            }
            return null;

        

    }

    }
}