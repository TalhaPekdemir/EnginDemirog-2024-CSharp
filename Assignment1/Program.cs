namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypesAndVariables();
            //Conditionals();
            //Methods();
            //Arrays();
            //Loops();
            //StringsAndOperations();

            CustomerManager customerManager = new CustomerManager(new SqlServerCustomerDal());
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ali";
            customer1.LastName = "Cengiz";
            customer1.City = "Bursa";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Mehmet",
                LastName = "Cambaz",
                City = "Kayseri"
            };

            Student student1 = new Student
            {
                Id = 1,
                FirstName = "Halit",
                LastName = "Halis",
                Department = "Machine Engineering"
            };

            // Interface
            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);
            personManager.Add(student1);

            //InterfaceSegregation();

            // Inheritance
            // gerektiğinde abstract class ve interface arasında
            // gereksinimlere göer karar verilir.
            ParentClass[] persons = new ParentClass[]
            {
                new Customer(),
                new Student()
            };
        }

        private static void InterfaceSegregation()
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
                        {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()
                        };

            foreach (var customerdal in customerDals)
            {
                customerdal.Add();
            }

            // Interface segregation
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            foreach (var work in workers)
            {
                work.Work();
            }

            foreach (var salary in salaries)
            {
                salary.Salary();
            }
        }

        private static void TypesAndVariables()
        {
            // Types and variables
            // Value types
            bool condition = false;
            byte oneByte = 255;
            short shortNumber = -32768;
            int intNumber = -2147483648;
            long longerNumber = -2147483649;

            char character = 'a';

            double doubleNumber = 3.14;
            decimal decimalNumber = 9.99M;

            var number = 10;
            number = 'F';

            Console.WriteLine("Condition is: {0}", condition);
            Console.WriteLine("Byte Number is: {0}", oneByte);
            Console.WriteLine("Short Number is: {0}", shortNumber);
            Console.WriteLine("Integer Number is: {0}", intNumber);
            Console.WriteLine("Long Number is: {0}", longerNumber);

            Console.WriteLine((int)character);

            Console.WriteLine("Double Number is: {0}", doubleNumber);
            Console.WriteLine("Decimal Number is: {0}", decimalNumber);

            Console.WriteLine(Days.Monday);

            Console.WriteLine(number);
        }

        private static void Conditionals()
        {
            // Conditionals
            int a = 10;
            int b = 20;

            if (a > b)
            {
                Console.WriteLine("a is bigger than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is smaller than b");

            }
            else
            {
                Console.WriteLine("numbers are  equal");
            }

            // single line if
            Console.WriteLine(a == b ? "numbers a re equal" : "numbers are not equal");
            // single line(ish) if-else
            Console.WriteLine(a > b ? "a is bigger than b" :
                a < b ? "a is smaller than b" : "numbers are equal");

            // switch
            switch (a)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 10");
                    break;
                deafult:
                    Console.WriteLine("Number is something else");
                    break;
            }

            if (a >= 0 && a < 100)
            {
                Console.WriteLine("Number between 0 and 100");

            }
            else if (a >= 100 && a < 200)
            {
                Console.WriteLine("Number between 100 and 200");
            }
            else if (a > 200 || a < 0)
            {
                Console.WriteLine("Number less than 0 or greater than 200");
            }

            //if (condition1)
            //{
            //    if (condition2)
            //    {
            //          ...
            //    }
            //    else
            //    {
            //          ...
            //    }
            //}
        }

        private static void Methods()
        {
            Console.WriteLine(Add());
            Console.WriteLine(Add(50));
            Console.WriteLine(Add(50, 70));

            // ref ile gönderildiğinde mutlaka ilk ataması yapılmış olmalı
            int refInt = 5;
            Console.WriteLine(AddWithRef(ref refInt, 70));

            // out ile ilk ataması yapılmadan metoda gönderilebilir
            // ancak kullanılacağı metotta ataması yapımalıdır
            int outInt;
            Console.WriteLine(AddWithOut(out outInt, 70));

            Console.WriteLine(Add("text", 1, 2, 3, 4, 5, 6, 7));
        }

        private static void Arrays()
        {
            // arrays
            string[] students = { "Ahmet", "Mehmet", "Can" };
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }

            // multidimensional arrays
            string[,] mostCrowdedEachRegion = new string[7, 2]
            {
                {"Marmara", "İstanbul"},
                {"İç Anadolu", "Ankara"},
                {"Ege", "İzmir"},
                {"Akdeniz", "Antalya"},
                {"Güneydoğu Anadolu", "Şanlıurfa"},
                {"Karadeniz", "Samsun"},
                {"Doğu Anadolu", "Van"},
            };

            for (int i = 0; i < mostCrowdedEachRegion.GetUpperBound(0); i++)
            {
                for (int j = 0; j < mostCrowdedEachRegion.GetUpperBound(1); j++)
                {
                    Console.WriteLine($"En kalabalık il: {mostCrowdedEachRegion[i, 1]} Bölge: {mostCrowdedEachRegion[i, 0]}");
                }
            }
        }

        private static void Loops()
        {
            // loops
            string[] students = { "Ahmet", "Mehmet", "Can" };

            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of (1-100)= {sum}");

            sum = 0;
            int iter = 0;
            while (iter < 100)
            {
                sum += iter;
                iter++;
            }

            Console.WriteLine($"Sum of (1-100)= {sum}");

            do
            {
                Console.WriteLine("Execute at least once");
                sum += iter;
                iter++;
            } while (sum == -1);

            foreach (string s in students)
            {
                //s = "new string"; // foreach readonly
                Console.WriteLine(s);
            }

            for (int i = -1; i < 15; i++)
            {
                Console.WriteLine($"{i}: {IsPrimeNum(i)}");
            }
        }

        private static void StringsAndOperations()
        {
            // strings and string methods
            string city1 = "Ankara";
            string city2 = "İstanbul";

            Console.WriteLine(city1 + city2);

            foreach (char c in city1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(String.Format("{0} {1}", city1, city2));

            string message = "Hello world";
            var message2 = message.Clone();
            message = "Hello world!";
            Console.WriteLine(message2);
            Console.WriteLine(message.EndsWith("!"));
            Console.WriteLine(message.StartsWith("H"));
            Console.WriteLine(message.IndexOf("l"));
            Console.WriteLine(message.LastIndexOf("l"));
            Console.WriteLine(message.Substring(0, 6) + "from the other side!");
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.Replace(" ", "|"));
            Console.WriteLine(message.Remove(9));
        }

        public static int Add(int num1 = 10, int num2 = 20)
        {
            return num1 + num2;
        }
        
        public static int AddWithRef(ref int num1, int num2 = 20)
        {
            num1 = 100;
            return num1 + num2;
        }
        
        public static int AddWithOut(out int num1, int num2 = 20)
        {
            num1 = 100;
            return num1 + num2;
        }

        // parameter overloading
        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // param mutlaka en sonda bulunmalıdır
        // ancak öncesine hernagi başka bir parametre alabilir
        public static int Add(string s, params int[] numbers)
        {
            return numbers.Sum();
        }

        public static bool IsPrimeNum(int num)
        {
            // asal sayı kuralları:
            // 1) tamsayı (0 ve 1 hariç) demek ki-> 2 den küçükse direkt false
            // 2) 2 sayısı istisna
            // 3) yalnızca 1e ve kendine bölünebilir
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            bool isPrime = true;
            for(int i = 2; i <= num - 1; i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }

    enum Days
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    
}
