namespace Day2Assignment2ReferenceTypes;

internal class Program
{
    static void Main(string[] args)
    {
        // primitives - value types
        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 50;
        Console.WriteLine("Sayı1: " + sayi1);
        Console.WriteLine("Sayı2: " + sayi2);

        // array, interface class... reference types
        int[] sayilar1 = new int[] { 1, 2, 3 };
        int[] sayilar2 = new int[] { 4, 5, 6 };

        sayilar1 = sayilar2;
        sayilar2[0] = 10;

        Console.WriteLine(sayilar1[0]);

        Person person1 = new Person();
        Person person2 = new Person();
        person1.FirstName = "Ali";
        person2 = person1;
        person1.FirstName = "Mehmet";

        Console.WriteLine(person2.FirstName);

        Customer customer1 = new Customer();
        customer1.FirstName = "Halit";
        Employee employee1 = new Employee();
        employee1.FirstName = "Ferman";

        Person person3 = customer1;
        customer1.FirstName = "Cengiz";
        Console.WriteLine(((Customer)person3).CreditCardNumber);

        PersonManager personManager1 = new PersonManager();
        personManager1.Add(customer1);
        personManager1.Add(employee1);
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Added " + person.FirstName);
        }
    }
}
