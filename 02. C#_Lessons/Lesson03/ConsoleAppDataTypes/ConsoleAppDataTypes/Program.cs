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


        }
    }
}
