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
    class ProductDL
    {
        public static List<Product> productList = new List<Product>();
        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public static void DeleteProduct(int i)
        {
            productList.RemoveAt(i);
        }
        public static List<Product> ReturnMedicines()
        {
            List<Product> MedicineList = new List<Product>();
            foreach(Product product in productList)
            {
                if(product is Medicine)
                {
                    MedicineList.Add(product);
                }
            }
            return MedicineList;
        }
        public static List<Product> ReturnEquipments()
        {
            List<Product> equipment = new List<Product>();
            foreach (Product product in productList)
            {
                if (product is Equipments)
                {
                    equipment.Add(product);
                }
            }
            return equipment;
        }
        public static void RemoveExpireProducs()
        {
            foreach (Product product in productList)
            {
                Medicine medicine = (Medicine)product;
                if ( medicine.Expiry1 <= DateTime.Now)
                {
                    productList.Remove(product);
                }
            }
        }
        
        public static List<Product> ProductToBeOrdered()
        {
            List<Product> productToOrder = new List<Product>();
            foreach (Product product in productList)
            {
                Medicine medicine = (Medicine)product;
                if (product.Stock < product.MinQuantity||medicine.Expiry1<=DateTime.Now)
                {
                    productToOrder.Add(product);
                }
            }
            return productToOrder;
        }
        public static List<Product> ExpireProducts()
        {
            List<Product> ExpireProducts = new List<Product>();
            foreach (Product product in productList)
            {
                Medicine medicine = (Medicine)product;
                if (medicine.Expiry1 <= DateTime.Now)
                {
                    ExpireProducts.Add(product);
                }
            }
            return ExpireProducts;
        }
        public static void MinimizeStock(List<CartItem> cart)
        {
            int i= 0;
            foreach (CartItem cartItem in cart)
            {
                if(cartItem.Id==productList[i].ID)
                {
                     int newstock  = productList[i].Stock - cartItem.Quantity;
                    productList[i].SetStock(newstock);
                }
                i++;
            }
        }
    }
}
