using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
    class Customer:Person
    {
        private string Address;
        
        private static List<CartItem> cart = new List<CartItem>();

        public string Address1 { get => Address; set => Address = value; }

        public Customer() { }
        public  Person ReturnCustomer()
        {
            return this;
        }
        public Customer(string name,string password,string Address):base(name,password)
        {
            this.Address1 = Address;
        }
        public  void AddToCart(CartItem product)
        {
            cart.Add(product);
        }
        public static List<CartItem> ReturnCart()
        {
            return cart;
        }
        public static  void RemoveFromCart(int idx)
        {
            cart.RemoveAt(idx);
        }
        public static  float Bill()
        {
           float bill = 0;
           foreach(CartItem cartItem in cart)
            {
                bill += cartItem.Price*cartItem.Quantity;
            }
            return bill;
        }
        public  static void DestroyCart()
        {
            cart.Clear();
        }
    }
}
