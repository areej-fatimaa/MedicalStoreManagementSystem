using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class Validations
    {
        public static bool CheckName(string name)
        {
            bool flag = false;
            flag = PersonDL.personList.Any(obj => obj.Name == name);
            if (flag)
            {
                flag = true;
            }
            return flag;
        }
        public static Person CheckPersonInList(string name,string password)
        {
            foreach(Person person in PersonDL.personList)
            {
                if(person.Name==name&&person.Password==password)
                {
                    return person;
                }
            }
            return null;
        }
        public static bool CheckPassword(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            if (password.Length > 8 && password.Length < 15 && hasUpperCase && hasLowerCase && hasDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
