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

            /*--------------------Variant 4--------------------*/

            //    Console.WriteLine("Eded daxil edin:");

            //l1:
            //    string input = Console.ReadLine();

            //    if (!int.TryParse(input, out int number))
            //    {
            //        Console.WriteLine("Zehmet olmasa, eded daxil edin:");
            //        goto l1;
            //    }
            //    int length = (int)Math.Log10(number) + 1;
            //    int divisor = (int)Math.Pow(10, length - 1);

            //    int position = 1;
            //    int sum = 0;

            //    while (divisor > 0)
            //    {
            //        int digit = number / divisor;
            //        if (position % 2 == 0) // cüt yerlər
            //        {
            //            sum += digit * digit;
            //        }
            //        number %= divisor;
            //        divisor /= 10;
            //        position++;
            //    }

            //    Console.WriteLine("Cavab: " + sum);

            /*--------------------Variant 5--------------------*/

            //    Console.WriteLine("Eded daxil edin:");
            //l1:
            //    string input = Console.ReadLine();
            //    int num = 0;
            //    if (!int.TryParse(input, out num))
            //    {
            //        Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin:");
            //        goto l1;
            //    }
            //    int length = (int)Math.Log10(num) + 1;

            //    int sum = 0;

            //    for (int i = 0; i < length; i++)
            //    {
            //        if ((i+1) % 2 == 0)
            //        {
            //            int digit = (num / (int)Math.Pow(10, length - i - 1)) % 10;
            //            int power = digit * digit;

            //            sum += power;
            //        }
            //    }
            //    Console.WriteLine("Cavab: " + sum);

            /*--------------------Variant 6--------------------*/

            //Console.WriteLine("Eded daxil edin: ");

            //int number;
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin: ");
            //}
            //number = Math.Abs(number);
            //int length = number == 0 ? 1 : (int)Math.Log10(number) + 1;
            //int sum = 0;
            //for (int i = 0; i < length; i++)
            //{
            //    if ((i + 1) % 2 == 0)
            //    {
            //        int digit = (number / (int)Math.Pow(10, length - i - 1)) % 10;
            //        sum += (int)Math.Pow(digit, 2);
            //    }
            //}
            //Console.WriteLine("Cavab: " + sum);

            /*--------------------Variant 7--------------------*/

            //Console.WriteLine("Eded daxil edin: ");

            //int number;
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin: ");
            //}

            //number = Math.Abs(number);

            //int position = 1;
            //int sum = 0;

            //while (number > 0)
            //{
            //    int digit = number % 10;

            //    if (position % 2 == 0)
            //    {
            //        sum += digit * digit;
            //    }

            //    number /= 10;
            //    position++;
            //}

            //Console.WriteLine("Cavab: " + sum);

            #endregion

            #region Task02
            //2.Rəqəmlər və sıra nömrələri
            //Daxil edilən ədədin rəqəmləri və onların
            //sıra nömrələrinə olan hasilinin
            //cəmini hesablayan proqram yazın
            //Giriş:
            //2345
            //Çıxış: 40
            //Izahi: 1 * 2 + 3 * 2 + 3 * 4 + 4 * 5 = 40

            //Console.WriteLine("Eded daxil edin: ");

            //int number;

            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin: ");
            //}

            //number = Math.Abs(number);
            //int length = number == 0 ? 1 : (int)Math.Log10(number) + 1;
            //int sum = 0;

            //for (int i = 0; i < length; i++)
            //{
            //    int digit = (number / (int)Math.Pow(10, length - i - 1)) % 10;
            //    sum += (i + 1) * digit;
            //}

            //Console.WriteLine("Cavab: " + sum);
            #endregion

            #region Task03
            //3.Rəqəmlərin yoxlanilması
            //Verilmiş n ədədin rəqəmlərinin müxtəlif olduğunu yoxlayan proqram yazın
            //Giris: 12546
            //Cixis: Muxtelifreqemli

            Console.WriteLine("Eded daxil edin: ");

            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Zehmet olmasa, duzgun eded daxil edin: ");
            }
            
            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                int temp = number / 10;
                while(temp > 0)
                {
                    if (temp % 10 == digit)
                    {
                        Console.WriteLine("Muxtelifreqemli deyil");
                        return;
                    }
                    temp /= 10;
                }
                number /= 10;
            }
            Console.WriteLine("Muxtelifreqemli");

            #endregion
        }
    }
}
