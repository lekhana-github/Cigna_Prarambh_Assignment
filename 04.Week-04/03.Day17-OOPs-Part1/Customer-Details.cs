namespace ObjectOrientedProgramming
{


    internal class Customer Details
    {
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }

            public Customer()
            {
                Id = 1;
                Name = "Lekhana";
                City = "Channapatna";
            }
            public Customer(int id)
            {
                Id = id;
            }
            public Customer(int id,string name)
            {
                Id=id;
                Name = name;
            }
            public Customer(int id,string name,string city)
            {
                Id = id;
                Name = name;
                City = city;
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Customer Details:: Id:{Id}, Name:{Name},City:{City}");
            }

        }
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ShowDetails();
            Customer customer1 = new Customer(10256);
            customer1.ShowDetails();
            Customer customer2 = new Customer(10256,"Scott");
            customer2.ShowDetails();
            Customer customer3 = new Customer(10256,"Scott","Hyd");
            customer3.ShowDetails();


        }
    }
}
