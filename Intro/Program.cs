using Intro.Business;
using Intro.Entities;

namespace Intro;

internal class Program
{
    static void Main(string[] args)
    {
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
        CourseManager courseManager = new CourseManager();
        Course[] courses = courseManager.GetAll();

        for(int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"Kurs adı: {courses[i].Name} Kurs Fiyatı: {courses[i].Price}");
        }

        Console.WriteLine("Kod Bitti");
    }
}
