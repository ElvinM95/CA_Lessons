namespace CsharpTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 01

            /* verilmish 4 reqemli ededin reqemlerinin cemini tap */
            //    int number;

            //    Console.WriteLine("Enter a 4-digit number:");
            //l1:
            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid 4-digit number.");
            //        goto l1;
            //    }

            //    if (number < 1000 || number > 9999)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid 4-digit number.");
            //        goto l1;
            //    }

            //    int sum = 0;

            //    while (number > 0)
            //    {
            //        int newNum = number % 10;
            //        sum += newNum;
            //        number /= 10;
            //    }

            //    Console.WriteLine("The sum of the digits is: " + sum);

            #endregion

            #region Task 02

            /* verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3 */

            //    int number;

            //    Console.WriteLine("Enter a 6-digit number:");
            //l1:
            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid 6-digit number.");
            //        goto l1;
            //    }

            //    if (number < 100000 || number > 999999)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid 6-digit number.");
            //        goto l1;
            //    }

            //    int sum = 0;

            //    int firstThreeDigits = number / 1000; // Get the first three digits

            //    while (firstThreeDigits > 0)
            //    {
            //        int newNum = firstThreeDigits % 10;
            //        sum += newNum;
            //        firstThreeDigits /= 10;
            //    }

            //    Console.WriteLine("The sum of the first three digits is: " + sum);

            #endregion

            #region Task 03

            /* verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi */

            //    int number;
            //    Console.WriteLine("Enter a 9-digit number:");
            //l1:
            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid 9-digit number.");
            //        goto l1;
            //    }
            //    if (number < 100000000 || number > 999999999)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid 9-digit number.");
            //        goto l1;
            //    }

            //    int sum = 0;
            //    int middleThreeDigits = (number / 1000) % 1000; // Get the middle three digits
            //    Console.WriteLine("The middle three digits are: " + middleThreeDigits);
            //    while (middleThreeDigits > 0)
            //    {
            //        int newNum = middleThreeDigits % 10;
            //        sum += newNum;
            //        middleThreeDigits /= 10;
            //    }
            //    Console.WriteLine("The sum of the middle three digits is: " + sum);

            #endregion

            #region Task 04

            /* verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati */

            //int number;

            //Console.Write("Enter a 5-digit number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 10000 && number <= 99999)
            //    {
            //        break; // Valid 5-digit number, exit the loop
            //    }
            //    Console.Write("Invalid input. Please enter a valid 5-digit number:");
            //}

            //int firstDigit = number / 10000; // Get the first digit
            //int lastDigit = number % 10; // Get the last digit
            //int sum = firstDigit + lastDigit;
            //int square = sum * sum;
            //Console.WriteLine("The square of the sum of the first and last digits is: " + square);

            #endregion

            #region Task 05

            /* verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at. */

            //int number;
            //Console.Write("Enter a 6-digit number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 100000 && number <= 999999)
            //    {
            //        break; // Valid 6-digit number, exit the loop
            //    }
            //    Console.Write("Invalid input. Please enter a valid 6-digit number:");
            //}

            //int firstDigit = number / 100000; // Get the first digit
            //int remainingDigits = number % 100000; // Get the remaining digits
            //int newNumber = remainingDigits * 10 + firstDigit; // Move the first digit to the end
            //Console.WriteLine("The new number is: " + newNumber);

            #endregion

            #region Task 06

            /* verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et */

            //int number;
            //Console.WriteLine("Enter an 8-digit number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 10000000 && number <= 99999999)
            //    {
            //        break; // Valid 8-digit number, exit the loop
            //    }
            //    Console.WriteLine("Invalid input. Please enter a valid 8-digit number:");
            //}

            //int middleDigits = (number % 10000000) / 10; // Get the middle digits
            //Console.WriteLine("The number without the first and last digits is: " + middleDigits);

            #endregion

            #region Task 07

            /* verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir */

            //int number;
            //Console.Write("Enter a 4-digit number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 1000 && number <= 9999)
            //    {
            //        break; // Valid 4-digit number, exit the loop
            //    }
            //    Console.Write("Invalid input. Please enter a valid 4-digit number:");
            //}

            //int reversedNumber = 0;
            //int tempNumber = number;
            //while (tempNumber > 0)
            //{
            //    int digit = tempNumber % 10;
            //    reversedNumber = reversedNumber * 10 + digit;
            //    tempNumber /= 10;
            //}

            //reversedNumber = (8 * 10000 + reversedNumber) * 10 + 8;
            //Console.WriteLine("The new number is: " + reversedNumber);

            #endregion

            #region Task 08

            /* Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap   */

            //int number;
            //Console.Write("Enter a number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 100)
            //    {
            //        break; // Valid number with at least 3 digits, exit the loop
            //    }
            //    Console.Write("Invalid input. Please enter a valid number with at least 3 digits:");
            //}

            //int lastDigit = number % 10; // Get the last digit
            //int thirdLastDigit = (number / 100) % 10; // Get the third last digit
            //int sum = lastDigit + thirdLastDigit;
            //Console.WriteLine("The sum of the third last digit and the last digit is: " + sum);

            #endregion

            #region Task 09.01

            /* 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439 */

            //int number;
            //Console.Write("Enter a 9-digit number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 100000000 && number <= 999999999)
            //    {
            //        break; // Valid 9-digit number, exit the loop
            //    }
            //    Console.Write("Invalid input. Please enter a valid 9-digit number:");
            //}

            //int mirrorNumber = 0;
            //int zeroCount = 0;
            //int temp = number;

            //while (temp > 0)
            //{
            //    int digit = temp % 10;
            //    if (mirrorNumber == 0 && digit == 0)
            //    {
            //        zeroCount++;
            //    }
            //    mirrorNumber = mirrorNumber * 10 + digit;
            //    temp /= 10;
            //}
            //int count = 1;
            //int result = 0;


            //while (mirrorNumber > 0)
            //{
            //    int digit = mirrorNumber % 10;
            //    if (count % 2 != 0) // Check if the digit is odd
            //    {
            //        result = result * 10 + digit;
            //    }
            //    mirrorNumber /= 10;
            //    count++;
            //}
            //while (zeroCount > 0)
            //{
            //    if (count % 2 != 0)
            //    {
            //        result = result * 10 + 0;
            //    }
            //    count++;
            //    zeroCount--;
            //}
            //Console.WriteLine("The new number is: " + result);

            #endregion

            #region Task 09.02

            int number;
            Console.Write("Enter a 9-digit number:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number) && number >= 100000000 && number <= 999999999)
                {
                    break; // Valid 9-digit number, exit the loop
                }
                Console.Write("Invalid input. Please enter a valid 9-digit number:");
            }

            int result = 0;
            int multiplier = 1;

            // Ədəd 9 rəqəmli olduğu üçün sağdan sola doğru hərəkət edəndə 
            // ən sağdakı rəqəm 9-cu mövqedədir. Buna görə 9-dan başlayırıq.
            int position = 9;

            while (number > 0)
            {
                int digit = number % 10; // Ən sağdakı rəqəmi alırıq

                // Əgər mövqe tək rəqəmdirsə (9, 7, 5, 3, 1)
                if (position % 2 != 0)
                {
                    result += digit * multiplier; // Yeni ədədə əlavə edirik
                    multiplier *= 10;             // Növbəti mərtəbəyə keçirik (1, 10, 100...)
                }

                number /= 10; // Yoxlanmış rəqəmi silib sola keçirik
                position--;   // Mövqeni bir addım azaldırıq (sola doğru)
            }

            Console.WriteLine(result); // Nəticə: 12439

            #endregion

            #region Task 10

            /* 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
                sonra cut yerde dayanlarinda bir eded duzlet,
                sonra onlari topla */



            #endregion
        }
    }
}
