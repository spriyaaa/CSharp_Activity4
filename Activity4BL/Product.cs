
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Activity4BL.Category;

namespace Activity4BL
{
    public class Product
    {
        private Category category;
        private int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Description { get; set; }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public Product()
        {

        }

        static Product()
        {

        }

        public Product(string ProductName, string Description, double Price, Category Category)
        {


        }
    }
}