using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class CustomerDL
    {
        public static void StoreInFileCustomer()
        {
            string path = "Customer.txt";
            StreamWriter file = new StreamWriter(path);
            foreach(Person person in PersonDL.personList)
            {
                if (person is Customer)
                {
                    Customer customer = (Customer)person;
                    file.WriteLine(person.Name + "," + person.Password + "," + customer.Address1);
                }
            }
           // Console.ReadKey();
            file.Flush();
            file.Close();
        }
        public static void ReadCustomerfromFile()
        {
            string path = "Customer.txt";

            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] records = record.Split(',');
                    string userName = records[0];
                    string password = records[1];
                    string Address = records[2];
                    Customer c1 = new Customer(userName, password, Address);
                    PersonDL.personList.Add(c1);
                    x++;
                    if (x > PersonDL.personList.Count)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
        }

    }
}
