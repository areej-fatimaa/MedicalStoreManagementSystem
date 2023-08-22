using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
   abstract class Product
    {
        private string iD;
        private string name;
        private int price;
        private int minQuantity;
        private int stock;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int MinQuantity { get => minQuantity; set => minQuantity = value; }
        public int Stock { get => stock; set => stock = value; }

        public Product(string ID,string name,int price,int minQuantity,int Stock)
        {
            this.iD = ID;
            this.name = name;
            this.price = price;
            this.minQuantity = minQuantity;
            this.stock = Stock;
        }
        public void SetStock(int stock)
        {
            this.Stock = stock;        }
        public abstract string ToString();
    }
}
