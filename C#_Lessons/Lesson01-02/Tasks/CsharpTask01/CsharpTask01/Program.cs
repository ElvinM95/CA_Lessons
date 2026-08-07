using Microsoft.VisualBasic;

namespace CsharpTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            #region Task 1

            /* 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 3333= 733338 */

            //Variant01
            //Start:
            //    Console.Write("4 reqemli ededi daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out int number) || (number < 1000 || number > 9999))
            //    {
            //        Console.WriteLine("Daxil edilen eded duzgun deyil.");
            //        goto Start;
            //    }

            //    int result = int.Parse("7" + number + "8");

            //    Console.WriteLine("Nəticə: " + result);

            //Variant02

            //Start:
            //    Console.Write("4 reqemli ededi daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out int number) || (number < 1000 || number > 9999))
            //    {
            //        Console.WriteLine("Daxil edilen eded duzgun deyil.");
            //        goto Start;
            //    }

            //    int firstDigit = 7;
            //    int lastDigit = 8;

            //    int result = firstDigit * 100000 + number * 10 + lastDigit;

            //    Console.WriteLine(result);

            #endregion

            #region Task 2

            /* 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example:
                333= 333333; */
            //Variant01
            //int number;
            //while (true)
            //{
            //    Console.Write("3 reqemli ededi daxil edin: ");
            //    if (!int.TryParse(Console.ReadLine(), out number) || (number < 100 || number > 999))
            //    {
            //        Console.WriteLine("Daxil edilen eded duzgun deyil.");
            //        continue;
            //    }
            //    break;
            //}

            //int result = number * 1000 + number;
            //Console.WriteLine("Nəticə: " + result);

            //Variant02
            //int number;
            //while (true)
            //{
            //    Console.Write("3 reqemli ededi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number) && (number >= 100 && number <= 999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilen eded duzgun deyil.");
            //}

            //int result = number * 1000 + number;
            //Console.WriteLine("Nəticə: " + result);

            #endregion

            #region Task 3

            /* 5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap. */

            //int number;
            //while (true)
            //{
            //    Console.Write("5 rəqəmli ədədi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number) && (number >= 10000 && number <= 99999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //}

            //int eighteenPercent = (int)(number * 0.18);
            //int threePercent = (int)(eighteenPercent * 0.03);

            //Console.WriteLine("18%: " + eighteenPercent);
            //Console.WriteLine("3%: " + threePercent);

            #endregion

            #region Task 4

            /* 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap */

            //int number;
            //while (true)
            //{
            //    Console.Write("3 rəqəmli ədədi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number) && (number >= 100 && number <= 999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //}

            //int result = number * 10 + 7;
            //double sevenPercent = result * 0.07;
            //Console.WriteLine("Nəticə: " + result);
            //Console.WriteLine("7%: " + sevenPercent);

            #endregion

            #region Task 5

            /* 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap. */

            //int number;
            //while (true)
            //{
            //    Console.Write("4 rəqəmli ədədi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number) && (number >= 1000 && number <= 9999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //}

            //int result = (40000 + number) * 100 + 44;
            //double fortyFourPercent = result * 0.44;
            //Console.WriteLine("Nəticə: " + result);
            //Console.WriteLine("44%: " + fortyFourPercent);

            #endregion

            #region Task 6

            /* 4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap. */

            //int number;
            //while (true)
            //{
            //    Console.Write("4 rəqəmli ədədi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number) && (number >= 1000 && number <= 9999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //}

            //int twentyPercent = (int)(number * 0.20);
            //int tenPercent = (int)(twentyPercent * 0.10);
            //int square = tenPercent * tenPercent;
            //Console.WriteLine("20%: " + twentyPercent);
            //Console.WriteLine("10%: " + tenPercent);
            //Console.WriteLine("Kvadrat: " + square);

            #endregion

            #region Task 7
            /* 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap */

            //int number1, number2;
            //while (true)
            //{
            //    Console.Write("1-ci 5 rəqəmli ədədi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number1) && (number1 >= 10000 && number1 <= 99999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //}

            //while (true)
            //{
            //    Console.Write("2-ci 5 rəqəmli ədədi daxil edin: ");
            //    if (int.TryParse(Console.ReadLine(), out number2) && (number2 >= 10000 && number2 <= 99999))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //}

            //int sum = number1 + number2;
            //int result = int.Parse("5" + sum.ToString() + "5");
            //double fivePercent = result * 0.05;
            //Console.WriteLine("Nəticə: " + result);
            //Console.WriteLine("5%: " + fivePercent);

            #endregion

            #region Task 8
            /* 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
               I ededin 4%-ni tap. 
               Sonra II ededin 9% ni tap. 
               Sonra Cavabları toplayıb 10 %ni tap. */

            //int number1 = ReadNumber("1-ci 4 rəqəmli ədədi daxil edin: ", 4);
            //int number2 = ReadNumber("2-ci 7 rəqəmli ədədi daxil edin: ", 7);

            //int firstPercent = (int)(number1 * 0.04);
            //int secondPercent = (int)(number2 * 0.09);
            //int tenPercent = (int)((firstPercent + secondPercent) * 0.10);

            //Console.WriteLine($"I ededin 4%-i: {firstPercent}");
            //Console.WriteLine($"II ededin 9%-i: {secondPercent}");
            //Console.WriteLine($"Cavabların cəmi: {tenPercent}");

            //static int ReadNumber(string prompt, int digitCount)
            //{
            //    while (true)
            //    {
            //        Console.Write(prompt);
            //        string input = Console.ReadLine();
            //        if (int.TryParse(input, out int number) && input.Length == digitCount && !input.StartsWith("0"))
            //        {
            //            return number;
            //        }
            //        Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
            //    }
            //}

            #endregion

            #region Task 9
            /* 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap. */

            int[] numbers = new int[3];
            numbers[0] = ReadNumber("1-ci 6 rəqəmli ədədi daxil edin: ", 6);
            numbers[1] = ReadNumber("2-ci 6 rəqəmli ədədi daxil edin: ", 6);
            numbers[2] = ReadNumber("3-cü 6 rəqəmli ədədi daxil edin: ", 6);

            double total = 0;

            foreach (int i in numbers)
            {
                double numPercent = (int)(i * 0.10);
                total += numPercent;
            }

            double tenPercentOfTotal = (int)(total * 0.10);

            Console.WriteLine("Nəticə: " + tenPercentOfTotal);

            static int ReadNumber(string prompt, int digitCount)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int number) && input.Length == digitCount && !input.StartsWith("0"))
                    {
                        return number;
                    }
                    Console.WriteLine("Daxil edilən ədəd düzgün deyil.");
                }
            }

            #endregion
        }
    }
}
