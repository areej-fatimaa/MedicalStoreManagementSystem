using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
    class Person
    {
        private string name;
        private string password;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        public Person(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public Person() { }
    }
}
