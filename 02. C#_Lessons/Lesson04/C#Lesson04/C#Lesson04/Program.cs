namespace C_Lesson04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             input: 423156789
             output: 2168
             */
            #region 1-ci variant
            //    int a, qaliq;
            //l1:
            //    Console.Write("eded: ");

            //    if (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        goto l1;
            //    }

            //    int newNum = 0;
            //    while (a > 0)
            //    {
            //        qaliq = a % 10;
            //        a /= 10;

            //        newNum = newNum * 10 + qaliq;
            //    }

            //    a = newNum;
            //    newNum = 0;
            //    bool next = true;
            //    while (a > 0)
            //    {

            //        qaliq = a % 10;
            //        a /= 10;

            //        if (next == true)
            //        {
            //            next = !next;
            //            continue;
            //        }

            //        next = !next;
            //        newNum = newNum * 10 + qaliq;
            //    }

            //    Console.WriteLine(newNum);

            #endregion

            #region 2-ci variant
            //    int a, qaliq;
            //l1:
            //    Console.Write("eded: ");

            //    if (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        goto l1;
            //    }

            //    int newNum = 0;
            //    while (a > 0)
            //    {
            //        qaliq = a % 10;
            //        a /= 10;

            //        newNum = newNum * 10 + qaliq;
            //    }

            //    a = newNum;
            //    newNum = 0;

            //    int counter = 0;

            //    while (a > 0)
            //    {

            //        qaliq = a % 10;
            //        a /= 10;

            //        if (counter % 2 == 0)
            //        {
            //            counter++;
            //            continue;
            //        }

            //        counter++;
            //        newNum = newNum * 10 + qaliq;
            //    }

            //    Console.WriteLine(newNum);
            #endregion

            #region Math

            //Console.WriteLine( Math.PI);
            //Console.WriteLine( (int)Math.PI);
            //Console.WriteLine( Math.E);
            //Console.WriteLine( (int)Math.E);

            //Console.WriteLine("===============");

            //double a = -45.5546;

            //Console.WriteLine(Math.Round(a));
            //Console.WriteLine(Math.Round(a, 2));
            //Console.WriteLine(Math.Round(a, 3));
            //Console.WriteLine(Math.Round(a, 1));

            //Console.WriteLine(Math.Floor(a)); // 45 - asagi yuvarla
            //Console.WriteLine(Math.Ceiling(a)); // 46 - yuxari yuvarla

            //Console.WriteLine(Math.Abs(a)); // modul almaq

            //int ancle = 30;

            //double rad = ancle * (Math.PI / 180);

            //Console.WriteLine(Math.Sin(rad));

            #endregion

        }
    }
}
