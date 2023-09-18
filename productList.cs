using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_PART2
{
    internal class productList
    {
        static int freeindex=-1;
        static float totalprice;
        product[] products;
        public productList()
        {
            products = new product[0];
           
        }
        public product[] Getproducts()
        {
            product[] temp = new product[products.Length];
            for (int i = 0; i < products.Length; i++)
            {
                temp[i] = products[i];//מעתיק את כל איברי המערך 
            }
            return temp;//עכשיו אני יכול לגשת למערך אבל להעתק שלו 
        }
        public bool nodata()
        {
            if (Getproducts().Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public void addproduct(product product)
        {

            bool exists = false;
            
            for (int i = 0; i < products.Length; i++)
            {
                if (products.Length==0|| products.Length==1)
                {
                    break;
                }
                if (compareproducts.Equalproducts(this.products[i], product))
                {
                    exists = true;
                  
                }
                
            }
            if (!exists)
            {
                
                product[] temp = new product[products.Length + 1];
                for (int i = 0; i < products.Length; i++)
                {
                    temp[i] = products[i];
                }
                temp[++freeindex] = product;
                products = temp;
            }

        }
        public bool removeProduct(product producttoremove)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == producttoremove)
                {
                    for (int j = i + 1; j < products.Length; j++)
                    {
                        products[j - 1] = products[j];
                    }
                    products[products.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }
        public bool samefile(product product, product product1)
        {
            if (compareproducts.Equalproducts(product, product1)==true)
            {
                return true;
            }
            return false;
        }
    }
}
