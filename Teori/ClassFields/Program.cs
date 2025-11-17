using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    internal class Program
    {
        class Product
        {
            //Private fields to store the product data
            private string name;
            private double price;
            private int stock;


            //Constuctor , Initializes a new instance of the product class with the specific name, price and stock
            public Product(string name, double price, int stock)
            {
                this.name = name;
                SetPrice(price);
                SetStock(stock);
            }

            //Method to set the name of the product

            public void SetName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";

            }

            //Method to get the name of the product
            public string GetName()
            {
                return name; //return the name of the product
            }

            //Method to set the Price of the poduct
            public void SetPrice(double price)
            {
                //Assign a positive or default 0 if the input is invalid
                this.price = price > 0 ? price : 0;

            }
            //Method to get the price of the product
            public double GetPrice()
            {
                return price; //return the price of the product
            }
            //Method to set the number of stock
            public void SetStock(int stock)
            {
                this.stock = stock >= 0 ? stock : 0;
            }
            //Method to get the quantity of stock
            public int GetStock()
            {
                return stock; // return stock quantity
            }
            //Method to return details of the product
            public string ReturnDetails()
            {
                return $"Name: {name} \nPrice: {price} \nStock: {stock}";
            }




        }
        static void Main(string[] args)
        {
            //Create an instance of the product
            Product product = new Product("Laptop", 999.99, 10);

            //Display product details
            Console.WriteLine(product.ReturnDetails());

            //Update product details
            product.SetName("Desktop");
            product.SetPrice(599.99);
            product.SetStock(20);

            Console.WriteLine(product.ReturnDetails());
        }
    }
}
