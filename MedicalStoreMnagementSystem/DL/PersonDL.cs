using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class PersonDL
    {
        public static List<Person> personList = new List<Person>();
        public static List<Person> ReturnAdmin()
        {
            List<Person> admin = new List<Person>();
            foreach(Person person in personList)
            {
                if(person is Admin)
                {
                    admin.Add(person);
                }
            }
            return admin;
        }
        public static void RemoveCustomer(Person person)
        {
            personList.Remove(person);
        }

    }
}
