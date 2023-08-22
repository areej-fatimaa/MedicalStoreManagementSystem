using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class ProductValidation
    {
        public static bool IsValidQuantity(int quantity)
        {
            try
            {
                if (quantity >= 0 && quantity <= 100)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("Quantity must be between 0 and 10.");
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool IsValidMinQuantity(int quantity)
        {
            try
            {
                if (quantity >= 0 && quantity <= 10)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("Quantity must be between 0 and 10.");
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool CheckDosageForm(string str)
        {
            if(str=="tablet"||str=="syrup")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckProduct(string ID)
        {
            foreach(Product product in ProductDL.productList)
            {
                if(product.ID==ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
