namespace ObjectOrientedProgramming
{


    internal class Product
    {
       
        class ProductDetails
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public double UnitPrice {  get; set; }
            public int quantity {  get; set; }
        }
           
        static void Main(string[] args)
        {
            ProductDetails productDetails = new ProductDetails();
            Console.WriteLine("Enter the PrductId");
            productDetails.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ProductName");
            productDetails.ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Unit Price");
            productDetails.UnitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Quantity");
            productDetails.quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"ProductId:{productDetails.ProductId}");
            Console.WriteLine($"ProductName:{productDetails.ProductName}");
            Console.WriteLine($"UnitPrice:{productDetails.UnitPrice}");
            Console.WriteLine($"quantity:{productDetails.quantity}");



        }
    }
}
