using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.FacadeDP
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");

            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.Sendinvoice();

            Console.WriteLine("Order Placed Successfully");
        }
    }
}
