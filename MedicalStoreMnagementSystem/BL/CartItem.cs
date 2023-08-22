using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessApplication.BL
{
    class CartItem
    {
        private string id;
        private string name;
        private int quantity;
        private int price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }

        public CartItem(string id,string name,int price,int quantity)
        {
            this.id = id;
            this.quantity = quantity;
            this.name = name;
            this.Price = price;
        }
    }
}
