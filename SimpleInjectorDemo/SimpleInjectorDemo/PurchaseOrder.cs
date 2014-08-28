using System;

namespace SimpleInjectorDemo
{
    public class PurchaseOrder : IOrder
    {
        public void Process()
        {
            Console.WriteLine("Purchase Order processed");
        }
    }
}