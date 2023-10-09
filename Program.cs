using System;

namespace Numbers
{

    class Program

    {
        static void Main(string[] args)

        {
            //ExploringNumbers();
            //ReferenceTypeExample();
            //Example4();
            //CastIntAndDouble();
            //ConvertToString();
            ParseToNumbersAndDates();

        }

        private static void ParseToNumbersAndDates()
        {
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");
        }

        private static void ConvertToString()
        {
            int number = 12;
            Console.WriteLine(number.ToString());
            
            bool boolean = true;
            Console.WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            object me = new object();
            Console.WriteLine(me.ToString());
        }

        static void CastIntAndDouble()
        {
            // Cast an int variable into a double variable

            int a = 10;
            double b = a;
            Console.WriteLine(b);  //an int can be stored in a double
            
            double c = 9.8;
            // cast a double variable into an int variable
            int d = (int)c; 

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");

            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");
        }

        static void Example4()
        {
            unsafe
            {
                // declare variable
                int n = 10;

                // store variable n address location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }

            static void ReferenceTypeExample()
        {
            // declaring string
            string a = "Salam";

            //append in a
            a += "for";
            a = a + "All";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object using GetType()
            Console.WriteLine(obj.GetType());
        }

        private static void AssignLocalvariables()

        {

            int population = 66_000_000;
            double weight = 1.88;
            decimal price = 4.99M; 
            string fruit = "Apples"; 
            char letter = 'Z'; 
            bool happy = true; 
        }
            private static void ExploringNumbers()

        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range:\n\n" +
            $"{ int.MinValue:N0} to { int.MaxValue:N0}.\n");

            Console.WriteLine("-----------------------");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range:\n\n" +
            $"{ double.MinValue:N0} \n\n to \n\n { double.MaxValue:N0}.\n");

            Console.WriteLine("---------------------------");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range:\n\n " +
            $"{ decimal.MinValue:N0} \n\n to \n\n { decimal.MaxValue:N0}.\n");
        }
    }
}
