using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
    class Equipments : Product
    {
        private int warrenty;
        public int Warrenty { get => warrenty; set => warrenty = value; }

        public Equipments(string id, string name, int price, int stock, int minQuantity, int warrenty) : base(id, name, price, minQuantity, stock)
        {
            this.Warrenty = warrenty;
        }
        public override string ToString()
            {
            return ID + "\t\t" + Name + "\t\t" + Warrenty + "\t\t" + Price + "\t\t" + MinQuantity + "\t\t" + Stock;
            }
    }
}
