using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new SimpleInjector.Container();
            container.Register<IOrder, PurchaseOrder>();

            var shoppingCart = container.GetInstance<ShoppingCart>();
            shoppingCart.CheckOut();

            Console.ReadLine();
        }
    }
}
