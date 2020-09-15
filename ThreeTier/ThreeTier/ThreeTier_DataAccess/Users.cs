using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTier_DataObject;

namespace ThreeTier_DataAccess
{
    public class Users
    {
        private string connectionString = string.Empty;

        public Users()
        {
            this.connectionString = @"Server=localhost\sqlexpress;Database=AdventureWorks2017;User Id=sa;Password=welol2020!;";
        }

        public List<Person> GetPersons(string startsWith)
        {
            List<Person> persons = new List<Person>();
            using(SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = this.connectionString;
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from person.person where LastName like '%" + startsWith + "'";
                cmd.Connection = cn;

                using(SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Person p = new Person()
                        {
                            id = (int) rdr["BusinessEntityID"],
                            Name = rdr["FirstName"].ToString(),
                            Surname = rdr["LastName"].ToString()
                        };
                        persons.Add(p);
                    }
                }
            }
            return persons;
        }

        public Person GetPersonBySurname(string surname)
        {
            Person p = new Person();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = this.connectionString;
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from person.person where LastName = '" + surname + "'";
                cmd.Connection = cn;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        p.id = (int)rdr["BusinessEntityID"];
                        p.Name = rdr["FirstName"].ToString();
                        p.Surname = rdr["LastName"].ToString();
                    }
                }
            }
            return p;
        }
    }
}
