using ProductDealer;
namespace AccessModifiersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            // product1.productID = 111; // not valid
            // product1.productName = "Acer Laptop";
            product1.quatityInStock = 200;
            //product1.cost = 74000; // not valid
            // product1.sellPerson = "Kate"; // not valid

        }
    }

    public class stateProduct : Product
    {
        public void Method1()
        {
            //productID = 222;  // not valid
            productName = "Apple Laptop"; // valid
            cost = 98000; // valid
            // sellPerson = "Rohan";  // not valid
            quatityInStock = 500;


        }
    }

    public class OtherClass
    {

        public void Method1()
        {
            Product product = new Product();
            // product.productID = 444; // not valid
            product.quatityInStock = 333;
            // product.cost = 89000; // not valid
            // product.productName = "Google Laptop";
            //product.sellPerson = "Mark";

        }
    }

}