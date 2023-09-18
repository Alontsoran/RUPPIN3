using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_PART2
{
    enum filetypeExtrension { hat= 1, gloves = 2, shirt = 3, pants = 4, shoes = 5 };
    internal class product
    {
        string nameofproduct;
        float price;
        string dis;
        filetypeExtrension Type = (filetypeExtrension)1;
        static readonly Array arr2 = Enum.GetValues(typeof(filetypeExtrension));
        static int Counter=1;
        public product()
        {
            string counter = Counter.ToString();
            this.nameofproduct = "product" + Counter.ToString();
        }
        public product(string nameofproduct, float price,string dis,int type)
        {
            Setnameofproduct(nameofproduct);
            setdiscribtion( dis);
            setPrice(price);
            Set_product_type(type);
        }
        public string Getnameofproduct()
        {
            return this.nameofproduct;
        }
        public bool Setnameofproduct(string nameofproduct)
        {
            foreach (char c in nameofproduct)
            {
                if (c == '>' || c == '?' || c == '*' || c == ':' || c == '/' || c == '|' || c == '>')
                {
                    return false;
                }
            }
            this.nameofproduct = nameofproduct;
            return true;
        }
        public float GetPrice()
        {
            return this.price;
        }
        public bool setPrice(float price)
        {
            if (price>0)
            {
               this.price=price;
                return true;
            }
            else
            {
                return false;
            }
        }
        public float Getdiscribtion()
        {
            return this.price;
        }
        public bool setdiscribtion(string dis)
        {
            if (dis.Length!=0)
            {
                this.dis = dis;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Set_product_type(int typeoffile)
        {
            this.Type = (filetypeExtrension)typeoffile;
        }
        public object Get_product_type()
        {
            return this.Type;
        }
        public product(product Other)
        {
            this.nameofproduct = Other.nameofproduct;
            this.price = Other.price;
            this.price = Other.price;
            this.Type = Other.Type;
        }
        public string print()
        {
            string y;
            return y = ("name :"+this.nameofproduct + " " + "about:" + " " + this.dis + " " + "price:" +" "+ this.price.ToString() +" "+ "type:" + " " + this.Type.ToString());
        }


    }
}
