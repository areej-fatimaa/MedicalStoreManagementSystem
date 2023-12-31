﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class AdminDL
    {
        public static void StoreInFileAdmin()
        {
            string path = "Admin.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Person person in PersonDL.personList)
            {
                if (person is Admin)
                {
                    // Medicine medicine = (Medicine)product;
                    file.WriteLine(person.Name + "," + person.Password);
                }
            }
            file.Flush();
            file.Close();
        }
        public static void ReadAdminfromFile()
        {
            string path = "Admin.txt";

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
                    Admin s1 = new Admin(userName, password);
                    PersonDL. personList.Add(s1);
                    x++;
                    if (x > PersonDL. personList.Count)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
        }
        public static void LoadTransactionsFromFile()
        {
            string path = "transactionHistory.txt";

                StreamReader reader = new StreamReader(path);
                {
                    string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Parse the customer information
                    string[] AllData = line.Split(':');
                    string AllcustomerData = AllData[0];
                    string AllcartData = AllData[1];
                    string[] customerData = AllcustomerData.Split(',');
                    string customerName = customerData[0];
                    string customerAddress = customerData[1];
                    string[] cartData = AllcartData.Split(',');
                    string id = cartData[0];
                    string productName = cartData[1];
                    int quantity = int.Parse(cartData[2]);
                    int price = int.Parse(cartData[3]);
                        Console.WriteLine("Customer Name\t\tAddress\t\tID\t\tName\t\tQuantity\t\tPrice");
                                Console.WriteLine(customerName+"\t\t\t"+customerAddress+"\t\t"+id+"\t\t"+productName+"\t\t"+quantity+"\t\t\t"+price);
                    Console.ReadKey();
                    }
                reader.Close();
                }
        }
        public static void SaveTransactionsToFile(Person customer, List<CartItem> cart, float bill)
        {
            string Path = "transactionHistory.txt";
            StreamWriter writer = new StreamWriter(Path, true);
            Customer customer1 = (Customer)customer;
                writer.Write($"{customer. Name},{customer1.Address1},:");
            foreach (CartItem cartItem in cart)
            {
                writer.WriteLine($"{cartItem.Id},{cartItem.Name},{cartItem.Quantity},{cartItem.Price}");
            }
            writer.Write(bill);
            writer.Flush();
            writer.Close();
        }
    }
}
