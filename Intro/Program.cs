using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro;

internal class Program
{
    static void Main(string[] args)
    {
        // Ders 1

        // variables -> camelCase
        string message = "Krediler";
        int term = 12;
        double amount = 100000;
        bool isAuthenticated = false;

        Console.WriteLine(message);

        // conditions
        if(isAuthenticated ) 
        {
            Console.WriteLine("Buton->Hoşgeldin Talha");
        }
        else
        {
            Console.WriteLine("Buton->Sisteme Giris Yap");
        }

        // arrays
        string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };
        //string[] loans = new string[5];
        //loans[0] = "Kredi1";

        // for loop
        for(int i = 0; i < loans.Length; i++)
        {
            Console.WriteLine(loans[i]);
        }

        // foreach
        foreach(string loan in loans)
        {
            Console.WriteLine(loan);
        }

        // while
        int iterator = 0;
        while(iterator < loans.Length)
        {
            Console.WriteLine(loans[iterator]);
            iterator++;
        }

        iterator = 0;
        // do-while
        do
        {
            Console.WriteLine(loans[iterator]);
            iterator++;
        }
        while(iterator < loans.Length);

        // OOP
        CourseManager courseManager = new CourseManager(new CourseDal());
        List<Course> courses = courseManager.GetAll();

        for(int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine($"Kurs adı: {courses[i].Name} Kurs Fiyatı: {courses[i].Price}");
        }

        // Ders 2

        IndividualCustomer customer1 = new IndividualCustomer
        {
            Id = 1,
            NationalIdentity = "12345678910",
            FirstName = "Ali",
            LastName = "Cengiz",
            CustomerNumber = "12345"
        };

        IndividualCustomer customer2 = new IndividualCustomer
        {
            Id = 2,
            NationalIdentity = "12345678911",
            FirstName = "Mehmet",
            LastName = "Cingöz",
            CustomerNumber = "12346"
        };

        CorporateCustomer customer3 = new CorporateCustomer
        {
            Id = 3,
            Name = "ABC AŞ.",
            TaxNumber = "9876543210",
            CustomerNumber = "54321"
        };

        CorporateCustomer customer4 = new CorporateCustomer
        {
            Id = 4,
            Name = "XYZ AŞ.",
            TaxNumber = "9876543211",
            CustomerNumber = "54322"
        };

        // value type -> int, bool, double...
        int number1 = 10;
        int number2 = 20;
        number1 = number2;
        number2 = 50;
        Console.WriteLine(number1);

        // reference type -> array, class, interface
        string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
        string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

        cities2 = cities1;
        cities1[0] = "Adana";

        // Base classlar child classların referanslarını tutabilir
        BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

        // Polymorphism
        foreach(BaseCustomer customer in customers)
        { 
            if(customer is IndividualCustomer individualCustomer)
            {
                Console.WriteLine($"Müşteri Adı: {individualCustomer.FirstName}");
            }
            else if( customer is CorporateCustomer corporateCustomer) 
            {
                Console.WriteLine($"Müşteri Adı: {corporateCustomer.Name}");
            }
            // alt alta if oluşturmak şart suistimali
            // ana sınıfta müşterinin ismini getirecek bir metot döngüden çağırılmalı

            Console.WriteLine($"Müşteri Numrası: {customer.CustomerNumber}");
        }



        Console.WriteLine("Kod Bitti");
    }
}
