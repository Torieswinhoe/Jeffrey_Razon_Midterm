using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Jeffrey_Razon_Midterm.Models;

namespace Jeffrey_Razon_Midterm.Controllers
{
    public class FirstController : ApiController
    {
        static List<Product> collections = new List<Product>();

        public FirstController() //ENLIST ALL PRODUCTS
        {
            if (collections.Count < 1)
            {
                Product Pen1 = new Product();
                Pen1.ProductID = 1723;
                Pen1.ProductCode = 0;
                Pen1.ProductName = "Friction Pen";
                Pen1.Description = "It is a ballpoint pen that could be erased.";
                Pen1.CategoryID = 1;
                Pen1.Color = "Black";
                Pen1.Size = 3;
                Pen1.Price = 130;
                collections.Add(Pen1);

                Product Pen2 = new Product();
                Pen2.ProductID = 1724;
                Pen2.ProductCode = 1;
                Pen2.ProductName = "Gel Pen";
                Pen2.Description = "A pen that has a ballpoint.";
                Pen2.CategoryID = 2;
                Pen2.Color = "Black";
                Pen2.Size = 1;
                Pen2.Price = 92;
                collections.Add(Pen2);

                Product Marker1 = new Product(); //Lists of products for Marker Category
                Marker1.ProductID = 1725;
                Marker1.ProductCode = 2;
                Marker1.ProductName = "Sharpie";
                Marker1.Description = "It is a marker that writes up blue ink.";
                Marker1.CategoryID = 3;
                Marker1.Color = "Blue";
                Marker1.Size = 2;
                Marker1.Price = 165;
                collections.Add(Marker1);

                Product Marker2 = new Product();
                Marker2.ProductID = 1726;
                Marker2.ProductCode = 3;
                Marker2.ProductName = "Pilot Marker";
                Marker2.Description = "It is a marker that writes up red ink.";
                Marker2.CategoryID = 4;
                Marker2.Color = "Red";
                Marker2.Size = 1;
                Marker2.Price = 130;
                collections.Add(Marker2);

            }
        }


        public List<Product> Get()//Shows List of all Products
        {
            return collections;
        }

        public Product Get(int index)//Shows specific product base on given index
        {
            return collections[index];
        }

        public Product Post(int ProductID, int ProductCode, string ProductName, string Description, int CategoryID, string Color, int Size, int Price)//Adds product to list
        {
            Product prod = new Product();
            prod.ProductID = ProductID;
            prod.ProductCode = ProductCode;
            prod.ProductName = ProductName;
            prod.Description = Description;
            prod.CategoryID = CategoryID;
            prod.Color = Color;
            prod.Size = Size;
            prod.Price = Price;
            collections.Add(prod);
            return prod;

        }
        public Product Put(int index, int ProductID, int ProductCode, string ProductName, string Description, int CategoryID, string Color, int Size, int Price)//Updates info of specific product to list
        {
            var prod = collections[index];
            prod.ProductID = ProductID;
            prod.ProductCode = ProductCode;
            prod.ProductName = ProductName;
            prod.Description = Description;
            prod.CategoryID = CategoryID;
            prod.Color = Color;
            prod.Size = Size;
            prod.Price = Price;
            collections.Add(prod);
            return prod;
        }

        public string Delete(int index)//Delete Product in List
        {
            collections.RemoveAt(index);
            return "Successfully Deleted";
        }

    }
}