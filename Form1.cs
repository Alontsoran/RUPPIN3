using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW4_PART2
{
    public partial class Form1 : Form
    {
        static int choose;
        productList productsList= new productList();
        public Form1()
        {
            InitializeComponent();
            //while (BUDGET1.Text=="")
            //{
            //    buttontotalprice.Enabled = false;
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void addtolist_Click(object sender, EventArgs e)
        {
            bool a = false, b = false;
            string name = namebox.Text;
            string dis = disbox.Text;
            float price = float.Parse(pricebox.Text);
            product y = new product();
            if (y.Setnameofproduct(name) == false)
            {
                MessageBox.Show("please enter name without '>'  '?'  '*'  ':'  '/' ||  '|' '>'");
                namebox.Text = "";
              
            }
            else
            {
                a = true;
            }
            if (price<0)
            {
                MessageBox.Show("please enter a posative value");
                namebox.Text = "";
                b = false;
            }
            else
            {
                b = true;
            }
            if (a==true&&b==true)
            {
               
                product d = new product(name, price, dis, choose);
                productsList.addproduct(d);
                namebox.Text = "";
                namebox.Text = "";
                disbox.Text= "";
                pricebox.Text = "";
                choose = 0;
                listView1.Clear();
            }
            else
            {
                MessageBox.Show("The product didnt added");
            }
           
        }

        private void HAT1_Click_1(object sender, EventArgs e)
        {
            choose = 1;
        }

        private void GLOVES2_Click_1(object sender, EventArgs e)
        {
            choose = 2;
        }

        private void SHIRT3_Click_1(object sender, EventArgs e)
        {
            choose = 3;
        }

        private void PANTS4_Click_1(object sender, EventArgs e)
        {
            choose =4;
        }

        private void SHOES5_Click_1(object sender, EventArgs e)
        {
            choose = 5;
        }
        private void printalldata()
        {
            
            product[] arr = productsList.Getproducts();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==null)
                {
                    MessageBox.Show("NO DATA TO PRINT");
                    break;
                }
                listView1.Items.Add(arr[i].print());
            }
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            product[] arr = productsList.Getproducts();
         
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Getnameofproduct() == textBox1.Text)
                {
                    productsList.removeProduct(arr[i]);
                }
                
            }
            textBox1.Text = "";
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            printalldata();
        }
        private void removep(product a)
        {
            
            //if (buttonremove_Click())
            //{
            //    productsList.removeProduct(a);
            //}
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttontotalprice_Click(object sender, EventArgs e)
        {
            product[] arr = productsList.Getproducts();
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].GetPrice();
            }
            sum1.Text = sum.ToString();
            float budget = float.Parse(BUDGET1.Text);
            result.Text = (budget-sum).ToString();

        }

        private void result_Click(object sender, EventArgs e)
        {
            
        }
    }
}
