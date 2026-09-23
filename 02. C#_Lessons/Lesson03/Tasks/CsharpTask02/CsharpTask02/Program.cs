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

            #region Task 09

            /* 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439 */

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

            int temp = number;
            int result = 0;
            int multiplier = 1; // To keep track of the position of the digit in the result
            while (true)
            {

                int digit = number % 10;
                if (digit % 2 == 1) // Check if the position is odd
                {
                    result = digit * multiplier + result;
                }
                number /= 10;
                multiplier *= 10;
                if (number == 0)
                {
                    break; // Exit the loop when all digits are processed
                }
            }

            Console.WriteLine("The new number is: " + result);

            #endregion
        }
    }
}
