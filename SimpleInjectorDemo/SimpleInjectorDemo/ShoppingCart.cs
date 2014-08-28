namespace SimpleInjectorDemo
{
    public class ShoppingCart
    {
        private readonly IOrder _order;

        public ShoppingCart(IOrder order)
        {
            _order = order;
        }

        public void CheckOut()
        {
            _order.Process();
        }
    }
}