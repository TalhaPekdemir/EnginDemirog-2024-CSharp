namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
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

            // Conditionals
            int a = 10;
            int b = 20;

            if(a > b)
            {
                Console.WriteLine("a is bigger than b");
            }
            else if(a < b)
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
                
        }
    }

    enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
