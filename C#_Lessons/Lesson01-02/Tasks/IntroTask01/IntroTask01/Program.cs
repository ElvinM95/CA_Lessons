namespace IntroTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            // 1. Cüt yerdə duran rəqəmlər
            // Verilmiş ədədin cüt yerdə duran rəqəmlərinin kvadratını  hesablayan proqramı yazın.
            // Giris: 123046
            // Cixis: 40
            // Izahi: 2 * 2 + 0 * 0 + 6 * 6 = 40

            /*--------------------Variant 1--------------------*/
            //    Console.WriteLine("Eded daxil edin:");
            //l1:
            //    string input = Console.ReadLine();

            //    if (!int.TryParse(input, out int num))
            //    {
            //        Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin:");
            //        goto l1;
            //    }
            //    int sum = 0;
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            int digit = input[i] - '0';
            //            int power = digit * digit;
            //            Console.WriteLine(power);

            //            sum += power;
            //        }
            //    }
            //    Console.WriteLine("Cavab: " + sum);

            /*--------------------Variant 2--------------------*/
            //Console.WriteLine("Eded daxil edin:");

            //string input;

            //while (true)
            //{
            //    input = Console.ReadLine();

            //    if (int.TryParse(input, out _))
            //        break;

            //    Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin:");
            //}

            //int sum = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    // (i + 1) → mövqe (1-dən başlasın deyə)
            //    if ((i + 1) % 2 == 0) // cüt yerlər
            //    {
            //        int digit = input[i] - '0';
            //        sum += digit * digit;
            //    }
            //}

            //Console.WriteLine("Cavab: " + sum);

            /*--------------------Variant 3--------------------*/
            //Console.WriteLine("Eded daxil edin:");

            //int num;

            //while (!int.TryParse(Console.ReadLine(), out num))
            //{
            //    Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin:");
            //}

            //// rəqəm sayını tapırıq
            //int temp = num;
            //int length = 0;

            //while (temp > 0)
            //{
            //    length++;
            //    temp /= 10;
            //}

            //int sum = 0;
            //int indexFromRight = 0;

            //while (num > 0)
            //{
            //    int digit = num % 10;

            //    // soldakı mövqe = length - indexFromRight
            //    int positionFromLeft = length - indexFromRight;

            //    if (positionFromLeft % 2 == 0) // cüt yerlər
            //    {
            //        sum += digit * digit;
            //    }

            //    num /= 10;
            //    indexFromRight++;
            //}

            //Console.WriteLine("Cavab: " + sum);
            #endregion
        }
    }
}
