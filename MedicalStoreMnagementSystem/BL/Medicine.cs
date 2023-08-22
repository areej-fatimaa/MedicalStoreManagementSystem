using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
    class Medicine:Product
    {
        private string Strength;
        private string DosageForm;
        private DateTime manufacture;
        private DateTime Expiry;

        public string Strength1 { get => Strength; set => Strength = value; }
        public string DosageForm1 { get => DosageForm; set => DosageForm = value; }
        public DateTime Manufacture { get => manufacture; set => manufacture = value; }
        public DateTime Expiry1 { get => Expiry; set => Expiry = value; }

        public Medicine(string name, string id, string strength, string dosageform, int price, int stock, int minQuantity, DateTime manufacture
           , DateTime expiry) : base(id, name, price, minQuantity, stock)
        {
            this.Strength=strength;
            this.DosageForm=dosageform;
            this.manufacture=manufacture;
            this.Expiry=expiry;
        }
        public override string ToString()
        {
            return ID + "\t\t" + Name + "\t\t" + DosageForm1 + "\t\t" + Strength1 + "\t\t" + Manufacture + "\t\t" + Expiry1 + "\t\t" + Price + "\t\t" + MinQuantity + "\t\t" + Stock;
        }
    }
}
