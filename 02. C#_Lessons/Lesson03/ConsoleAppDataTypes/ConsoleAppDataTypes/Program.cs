namespace ConsoleAppDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Checked Contexts
            //Console.WriteLine($"Min: {byte.MinValue}");
            //Console.WriteLine($"Max: {byte.MaxValue}");

            //byte x = 255;

            //checked
            //{
            //    x++;

            //    Console.WriteLine(x);
            //}
            #endregion

            #region Inplicit and Explicit casting

            /* int a = 10;

            double b = a; // or { double b = (double)a; } Implicit casting from int to double */

            //double a = 10.5;

            //int b = (int)a; // Explicit casting from double to int

            //Console.WriteLine(b);

            #endregion

            #region Subtracting the integer part of a decimal number

            //decimal a = 10.523m;

            //int tam = (int)a;

            ////0.12312

            //Console.WriteLine((a - tam).ToString().Substring(2));

            /* decimal a = 11.623m;

            int tam = Convert.ToInt32(a); Tam ədədə çevirəndə 11.623 12-ə yuvarlaqlaşır.

            Console.WriteLine(tam); */

            #endregion

            #region Converting to Different Number Systems

            //int a = 200;

            //Console.WriteLine(Convert.ToString(a, 2)); 2-lik say sisteminə çevirir
            //Console.WriteLine(Convert.ToString(a, 8)); 8-lik say sisteminə çevirir
            //Console.WriteLine(Convert.ToString(a, 16)); 16-lik say sisteminə çevirir

            #endregion

            #region Object Type 01

            //int a = 10;

            //object a1 = a; // Boxing

            //int b = (int)a1; // Unboxing

            //int c = (int)b; // casting

            // Console.WriteLine(b + 1);

            //var product1 = new
            //{
            //    weight = 200.0,
            //    name = "SANA",
            //    price = 6.99
            //};

            //object product2 = new
            //{
            //    weight = 500,
            //    name = "SANA",
            //    price = 12.99,
            //    lastDate = DateTime.Now.AddDays(14)
            //};

            ///* Console.WriteLine(product1.price);
            //   Console.WriteLine(product2); */

            //PrintInfo(product1);
            //Console.WriteLine("==========================");
            //PrintInfo(product2);

            #endregion

            #region Object Type 02

            //int a = 10;

            //object a1 = a; // Boxing
            //============================={
            ////int? x = (int)a1;
            ////int? x = a1 as int?;
            //============================}

            //if (a1 is int reqemInt)
            //{
            //    Console.WriteLine(reqemInt);
            //}

            //if (a1 is int)
            //{
            //    int i = (int)a1;
            //    Console.WriteLine(i);
            //}
            //=======================================
            //if (a1 is int) // pattern matching
            //{
            //    int i = (int)a1;
            //    Console.WriteLine(i);
            //}
            //else if (a1 is double)
            //{
            //    double d = (double)a1;
            //    Console.WriteLine(d);
            //}

            #endregion

            #region Verilmish 4 reqqemli ededin reqemlerinin cemini tap

        //    string income;
        //    int eded;

        //l1:
        //    Console.Write("4 reqemli eded daxil edin: ");

        //    income = Console.ReadLine();

        //    if (!int.TryParse(income, out eded))
        //    {
        //        Console.WriteLine("eded daxil edilmeyib");
        //        goto l1;
        //    }

        //    if (eded < 1000 || eded > 9999)
        //    {
        //        Console.WriteLine("4 reqemli eded daxil edilmeyib");
        //        goto l1;
        //    }

        //    Console.WriteLine(eded);

        //    int sum = 0;

        //    while (eded > 0)
        //    {
        //        int qaliq = eded % 10;
        //        sum += qaliq;
        //        eded = eded / 10;
        //    }

        //    Console.WriteLine(sum);

            #endregion

            #region Reversing a 4-digit Number

            string income;
            int eded;
            int qaliq;

        l1:
            Console.Write("4 reqemli eded daxil edin: ");

            income = Console.ReadLine();

            if (!int.TryParse(income, out eded))
            {
                Console.WriteLine("eded daxil edilmeyib");
                goto l1;
            }

            if (eded < 1000 || eded > 9999)
            {
                Console.WriteLine("4 reqemli eded daxil edilmeyib");
                goto l1;
            }

            Console.WriteLine(eded);

            int newNumber = 0;
            int temp = eded;
            while (temp > 0)
            {
                qaliq = temp % 10;
                newNumber = newNumber * 10 + qaliq;
                temp /= 10;
            }

            Console.WriteLine($"Input: {eded}");
            Console.WriteLine($"Output: {newNumber}");

            #endregion
        }

        static void PrintInfo(dynamic product)
        {
            Console.WriteLine($"Adi: {product.name}");
            Console.WriteLine($"Ceki: {product.weight}");
            Console.WriteLine($"Qiymet: {product.price}");
        }
    }
}
