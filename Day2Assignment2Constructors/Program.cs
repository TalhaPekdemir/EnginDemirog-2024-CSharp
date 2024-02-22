namespace Day2Assignment2Constructors;

internal class Program
{
    static void Main(string[] args)
    {
        // default ctor ile çalışır
        Customer customer1 = new Customer
        {
            Id = 1,
            FirstName = "TestFirst",
            LastName = "TestLast",
            City = "London"
        };

        // param kabul eden ctor ile çalışır
        Customer customer2 = new Customer(2, "test2first", "test2last", "Berlin");
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("hello from constructor");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }
    }
}
