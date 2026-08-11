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

            //int[] numbers = new int[3];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumber($"{i + 1}-ci 6 rəqəmli ədədi daxil edin: ", 6);
            //}

            //double total = 0;

            //foreach (int i in numbers)
            //{
            //    double numPercent = (int)(i * 0.10);
            //    total += numPercent;
            //}

            //double tenPercentOfTotal = (int)(total * 0.10);

            //Console.WriteLine("Nəticə: " + tenPercentOfTotal);

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

            #region Task 10
            /* 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
                Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel */

            //int[] numbers = new int[3];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumber($"{i + 1}-ci 4 rəqəmli ədədi daxil edin: ", 4);
            //}

            //double p1 = numbers[0] * 0.01;
            //double p2 = numbers[1] * 0.02; 
            //double p3 = numbers[2] * 0.03;

            //double difference = p1 - p2 - p3;

            //double p3_7percent = numbers[2] * 0.07;
            //double finalResult = difference + p3_7percent;

            //Console.WriteLine("Nəticə: " + finalResult);

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

            #region Task 11
            /* 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
                Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix. */

            //int[] numbers = new int[4];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumber($"{i + 1}-ci 5 rəqəmli ədədi daxil edin: ", 5);
            //}

            //double sum1 = numbers[0] + numbers[2];
            //double sum2 = numbers[1] + numbers[3];
            //double product = sum1 * sum2;
            //double result = product - (numbers[2] * 0.03);

            //Console.WriteLine("Nəticə: " + result);

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

            #region Task 12
            /* 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. 
                Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap. */

            //int[] numbers = new int[4];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumber($"{i + 1}-ci 6 rəqəmli ədədi daxil edin: ", 6);
            //}

            //double sum10Percent = 0;
            //double sum15Percent = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum10Percent += numbers[i] * 0.10;
            //    sum15Percent += numbers[i] * 0.15;
            //}

            //double product = sum10Percent * sum15Percent;
            //double result = product * 0.10;
            //double finalResult = result * 0.11;

            //Console.WriteLine("Nəticə: " + finalResult);

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

            #region Task 13
            /* 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine. 
                Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla. */

            //int[] fiveDigitNumbers = new int[3];
            //int[] threeDigitNumbers = new int[2];
            //for (int i = 0; i < fiveDigitNumbers.Length; i++)
            //{
            //    fiveDigitNumbers[i] = ReadNumber($"{i + 1}-ci 5 rəqəmli ədədi daxil edin: ", 5);
            //}
            //for (int i = 0; i < threeDigitNumbers.Length; i++)
            //{
            //    threeDigitNumbers[i] = ReadNumber($"{i + 1}-ci 3 rəqəmli ədədi daxil edin: ", 3);
            //}

            //double productOfFiveDigitNumbers = 1;
            //for (int i = 0; i < fiveDigitNumbers.Length; i++)
            //{
            //    productOfFiveDigitNumbers *= fiveDigitNumbers[i] * 0.05;
            //}

            //double sumOfThreeDigitNumbers = 0;
            //for (int i = 0; i < threeDigitNumbers.Length; i++)
            //{
            //    sumOfThreeDigitNumbers += threeDigitNumbers[i] * 0.03;
            //}

            //double finalResult = (productOfFiveDigitNumbers * 0.10) + (sumOfThreeDigitNumbers * 0.10);

            //Console.WriteLine("Nəticə: " + finalResult);

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

            #region Task 14
            /* 6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
                I neticeden II neticeni cix. Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap. */

            //int[] numbers = new int[6];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumber($"{i + 1}-ci 6 rəqəmli ədədi daxil edin: ", 6);
            //}

            //long sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //long concatenatedNumber = long.Parse(numbers[0].ToString() + numbers[2].ToString());

            //long difference = sum - concatenatedNumber;

            //double tenPercent = difference * 0.10;

            //double finalResult = (tenPercent + numbers[4] + numbers[5]) * 0.11;

            //Console.WriteLine("Nəticə: " + finalResult);

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

            #region Task 15
            /*  7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
                3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
                Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
                Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
                Sonra alinan cavabin ustune gel 6 reqemli ededi.
                Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
                Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
                Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel. */

            int [] threeDigitNumbers = new int[2];
            for (int i = 0; i < threeDigitNumbers.Length; i++)
            {
                threeDigitNumbers[i] = ReadNumber($"{i + 1}-ci 3 rəqəmli ədədi daxil edin: ", 3);
            }
            int[] fourDigitNumbers = new int[2];
            for (int i = 0; i < fourDigitNumbers.Length; i++)
            {
                fourDigitNumbers[i] = ReadNumber($"{i + 1}-ci 4 rəqəmli ədədi daxil edin: ", 4);
            }
            int[] fiveDigitNumbers = new int[2];
            for (int i = 0; i < fiveDigitNumbers.Length; i++)
            {
                fiveDigitNumbers[i] = ReadNumber($"{i + 1}-ci 5 rəqəmli ədədi daxil edin: ", 5);
            }
            int sixDigitNumber = ReadNumber("6 rəqəmli ədədi daxil edin: ", 6);

            int sumThreeDigit = threeDigitNumbers[0] + threeDigitNumbers[1];
            long productFourDigit = (long)fourDigitNumbers[0] * fourDigitNumbers[1];
            int sumFourDigit = fourDigitNumbers[0] + fourDigitNumbers[1];
            int sumFiveDigit = fiveDigitNumbers[0] + fiveDigitNumbers[1];

            long result = sumThreeDigit + productFourDigit;

            result = result * 10 + 7;

            result += sumFiveDigit;

            long productThreeDigit = (long)threeDigitNumbers[0] * threeDigitNumbers[1];
            long modifiedProductThreeDigit = productThreeDigit * 10 + 1;
            result -= modifiedProductThreeDigit;

            result += sixDigitNumber;

            int sumThreeAndFourDigits = sumThreeDigit + sumFourDigit;
            result -= sumThreeAndFourDigits;

            double eighteenPercent = result * 0.18;
            double threePercent = eighteenPercent * 0.03;
            double onePercent = threePercent * 0.01;

            double finalResult = onePercent + sumFiveDigit;

            Console.WriteLine("\nNəticə: " + finalResult);

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
