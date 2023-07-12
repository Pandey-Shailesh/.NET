namespace ProductDealer
{
    public class Product
    {
        private int productID;
        protected string productName;
        protected internal double cost;
        internal string sellPerson;
        public int quatityInStock;
    }

    // child class at the same assembly
    public class DomesticProduct : Product
    {
        public void method1()
        {
            // productID = 101; // not valid
            productName = "HP Laptop"; // valid
            cost = 85000.0; // valid
            quatityInStock = 100;
            sellPerson = "John";
        }
    }

    public class InternationalProduct
    {
        public void Method1()
        {
            Product product = new Product();
            // product.productID = 101; // not valid
            // product.productName = "Dell Moniter"; // valid
            product.cost = 75000; // valid
            product.sellPerson = "Micheal";
            product.quatityInStock = 100;

        }

    }
}