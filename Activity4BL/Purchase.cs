
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Activity4BL
{
    public class Purchase
    {


        private string customer;
        private DateTime dateOfPurchase;
        private string paymentType;
        private int purchaseCounter;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;


        public string Customer { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string PaymentType { get; set; }
        public string PurchaseId { get; set; }
        public int QuantityOrdered { get; set; }
        public string ShippingAddress { get; set; }


        /* double servicetax;
         double totalprice;
         double Totalprice;
         int discountpercentage;
         double price;*/
        double discountpercentage;
        double pricesofallproducts;



        public Purchase()
        {

        }

        static Purchase()
        {

        }


        public Purchase(string customer, int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {
            this.customer = customer;
            this.quantityOrdered = quantityOrdered;
            this.shippingAddress = shippingAddress;
            this.dateOfPurchase = dateOfPurchase;
            this.paymentType = paymentType;

        }



       //public double CalculateBillAmount(params Product[] product)

        double CalculateBillAmount(params Product[] product)
        {
            /*for (int i = 0; i < product.Length; i++)
                {
                    Console.Write(product[i] + " ");
                }*/
            double totalprice = 0.0;
            foreach (Product price in product)
            {
                totalprice += Convert.ToDouble(price);
            }


            double servicetax = 0.07 * totalprice;
            double discountpercentage = CalculateDiscount();
            double totalbillamount = (totalprice + servicetax) * (1 - discountpercentage);
            return totalbillamount;


        }


        //public double CalculateBillAmount(Product product, int quantityRequired) 

        double CalculateBillAmount(Product product, int quantityRequired)
        {
            double totalprice = product.Price * quantityRequired;
            double servicetax = 0.07 * totalprice;
            double discountpercentage = CalculateDiscount();
            double totalbillamount = (totalprice + servicetax) * (1 - discountpercentage);
            return totalbillamount;


        }

        public double CalculateDiscount()
        {
            double discountpercentage = 0.05;
            return discountpercentage;
        }
    }
}