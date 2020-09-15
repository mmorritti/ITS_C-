using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTier_DataAccess;
using ThreeTier_DataObject;

namespace ThreeTier_Business
{
    public class Users
    {
        public List<string> GetUsefulUsers(string iniziaCon)
        {
            if (!String.IsNullOrEmpty(iniziaCon))
            {
                ThreeTier_DataAccess.Users u = new ThreeTier_DataAccess.Users();
                List<Person> persons = u.GetPersons(iniziaCon);

                List<string> users = new List<string>();
                foreach(Person p in persons)
                {
                    users.Add(
                        String.Format("{0} - {1} {2}", p.id, p.Surname, p.Name)
                        );
                }
                return users;
            }
            return new List<string>();
        }

        public List<string> GetSingleUser(string cognome)
        {
            //VALIDAZIONE
            if (!String.IsNullOrEmpty(cognome))
            {
                //ACCESSO AL DATA ACCESS LAYER
                ThreeTier_DataAccess.Users u = new ThreeTier_DataAccess.Users();
                Person p = u.GetPersonBySurname(cognome);

                //TRASFORMAZIONE DATI
                List<string> users = new List<string>();
                users.Add(
                    String.Format("{0} - {1} {2}", p.id, p.Surname, p.Name)
                    );
                return users;
            }
            return new List<string>();
        }
    }
}
