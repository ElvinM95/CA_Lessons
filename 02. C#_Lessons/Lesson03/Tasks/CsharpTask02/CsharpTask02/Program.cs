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

            //int result = 0;
            //int multiplier = 1;

            //// Ədəd 9 rəqəmli olduğu üçün sağdan sola doğru hərəkət edəndə 
            //// ən sağdakı rəqəm 9-cu mövqedədir. Buna görə 9-dan başlayırıq.
            //int position = 9;

            //while (number > 0)
            //{
            //    int digit = number % 10; // Ən sağdakı rəqəmi alırıq

            //    // Əgər mövqe tək rəqəmdirsə (9, 7, 5, 3, 1)
            //    if (position % 2 != 0)
            //    {
            //        result += digit * multiplier; // Yeni ədədə əlavə edirik
            //        multiplier *= 10;             // Növbəti mərtəbəyə keçirik (1, 10, 100...)
            //    }

            //    number /= 10; // Yoxlanmış rəqəmi silib sola keçirik
            //    position--;   // Mövqeni bir addım azaldırıq (sola doğru)
            //}

            //Console.WriteLine(result); // Nəticə: 12439

            #endregion

            #region Task 10

            /* 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
                sonra cut yerde dayanlarinda bir eded duzlet,
                sonra onlari topla */

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

            //int resultOdd = 0;
            //int resultEven = 0;
            //int multiplierOdd = 1;
            //int multiplierEven = 1;
            //int position = 9;

            //while (number > 0)
            //{
            //    int digit = number % 10; // Ən sağdakı rəqəmi alırıq

            //    // Əgər mövqe tək rəqəmdirsə (9, 7, 5, 3, 1)
            //    if (position % 2 != 0)
            //    {
            //        resultOdd += digit * multiplierOdd; // Yeni ədədə əlavə edirik
            //        multiplierOdd *= 10;             // Növbəti mərtəbəyə keçirik (1, 10, 100...)
            //    }
            //    else
            //    {
            //        resultEven += digit * multiplierEven; // Yeni ədədə əlavə edirik
            //        multiplierEven *= 10;             // Növbəti mərtəbəyə keçirik (1, 10, 100...)
            //    }

            //    number /= 10; // Yoxlanmış rəqəmi silib sola keçirik
            //    position--;   // Mövqeni bir addım azaldırıq (sola doğru)
            //}

            //Console.WriteLine("Result Odd: " + resultOdd);
            //Console.WriteLine("Result Even: " + resultEven);
            //Console.WriteLine("Sum: " + (resultOdd + resultEven));  

            #endregion

            #region Task 11

            /* 8 reqemli ededin reqemlerini iki -iki qruplashdir.
                Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
                Sonra cavabin ozunden onun 18% ni cix; */

            //int number;
            //Console.Write("Enter an 8-digit number:");
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out number) && number >= 10000000 && number <= 99999999)
            //    {
            //        break; // Valid 8-digit number, exit the loop
            //    }
            //    Console.Write("Invalid input. Please enter a valid 8-digit number:");
            //}
            //int sum = 0;
            //int tempNumber = number;
            //// Qrupları iki-iki ayırmaq və cəmləmək
            //while (tempNumber > 0)
            //{
            //    int group = tempNumber % 100; // Son iki rəqəmi alırıq
            //    sum += group;                 // Cəmləyirik
            //    tempNumber /= 100;            // Son iki rəqəmi silirik
            //}
            //sum = sum * 100 + 99; // Axırına 99 əlavə edirik
            //double result = sum - (sum * 0.18); // Cavabdan onun 18%-ni çıxırıq
            //Console.WriteLine("The final result is: " + result);

            #endregion

            #region Task 12

            /* 2 dene 5 reqemli eded daxil et.
                I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
                Neticenin axirina I ededin en axiinci reqemini artir. */

            //int firstNumber = GetValidNumber("first", 5);
            //int secondNumber = GetValidNumber("second", 5);
            //int sumFirst = 0;
            //int productSecond = 1;
            //int lastDigitFirst = firstNumber % 10; // I ededin ən axırıncı rəqəmi
            //while (firstNumber > 0)
            //{
            //    int digit = firstNumber % 10;
            //    sumFirst += digit;
            //    firstNumber /= 10;
            //}
            //while (secondNumber > 0)
            //{
            //    int digit = secondNumber % 10;
            //    productSecond *= digit;
            //    secondNumber /= 10;
            //}
            //int result = sumFirst + productSecond;
            //result = result * 10 + lastDigitFirst; // Neticenin axirina I ededin en axirinci reqemini artir

            //Console.WriteLine("The final result is: " + result);

            //static int GetValidNumber(string orderName, int digitCount)
            //{
            //    // Daxil ediləcək rəqəmin sayına uyğun minimum və maksimum dəyərləri dinamik tapırıq.
            //    // Məsələn, digitCount = 5 olarsa: 
            //    // minValue = 10 ^ 4 = 10000
            //    // maxValue = 10 ^ 5 - 1 = 100000 - 1 = 99999
            //    int minValue = (int)Math.Pow(10, digitCount - 1);
            //    int maxValue = (int)Math.Pow(10, digitCount) - 1;

            //    Console.Write($"Enter the {orderName} {digitCount}-digit number: ");

            //    int number;
            //    while (true)
            //    {
            //        // Parametrlərə əsasən həm prompt, həm də limitlər avtomatik formalaşır
            //        if (int.TryParse(Console.ReadLine(), out number) && number >= minValue && number <= maxValue)
            //        {
            //            return number;
            //        }
            //        Console.Write($"Invalid input. Please enter a valid {digitCount}-digit number: ");
            //    }
            //}

            #endregion

            #region Task 13

            /* 3 dene 5 reqemli eded var.
                Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
                Yekunda alian cavabin 50%-ni hemin ededin uzerine gel. */

            //int num1 = GetValidNumber("first", 5);
            //int num2 = GetValidNumber("second", 5);
            //int num3 = GetValidNumber("third", 5);

            //// 2. Hər ədədin ilk və son rəqəmindən yeni ədəd yaradırıq
            //int combinedNum1 = GetFirstAndLastCombined(num1);
            //int combinedNum2 = GetFirstAndLastCombined(num2);
            //int combinedNum3 = GetFirstAndLastCombined(num3);

            //// 3. Alınan nəticələri toplayırıq
            //int sum = combinedNum1 + combinedNum2 + combinedNum3;

            //// 4. Yekun cavabın 50%-ni tapıb üzərinə gəlirik
            //// QEYD: Məbləğ tək rəqəm ola bilər deyə, double istifadə etmək mütləqdir.
            //double finalResult = sum + (sum * 0.5);
            //// Və ya daha qısa: double finalResult = sum * 1.5;

            //Console.WriteLine("\n--- Nəticələr ---");
            //Console.WriteLine($"Combined numbers: {combinedNum1}, {combinedNum2}, {combinedNum3}");
            //Console.WriteLine($"Sum of combinations: {sum}");
            //Console.WriteLine($"Final Result (+50%): {finalResult}");

            //static int GetFirstAndLastCombined(int number)
            //{
            //    number = Math.Abs(number); // Mənfi ədəd riskinə qarşı
            //    int lastDigit = number % 10;

            //    int firstDigit = number;
            //    while (firstDigit >= 10)
            //    {
            //        firstDigit /= 10;
            //    }

            //    // Yeni 2 rəqəmli ədədi formalaşdırırıq: (İlk rəqəm * 10) + Son rəqəm
            //    return (firstDigit * 10) + lastDigit;
            //}

            //static int GetValidNumber(string orderName, int digitCount)
            //{
            //    // Daxil ediləcək rəqəmin sayına uyğun minimum və maksimum dəyərləri dinamik tapırıq.
            //    // Məsələn, digitCount = 5 olarsa: 
            //    // minValue = 10 ^ 4 = 10000
            //    // maxValue = 10 ^ 5 - 1 = 100000 - 1 = 99999
            //    int minValue = (int)Math.Pow(10, digitCount - 1);
            //    int maxValue = (int)Math.Pow(10, digitCount) - 1;

            //    Console.Write($"Enter the {orderName} {digitCount}-digit number: ");

            //    int number;
            //    while (true)
            //    {
            //        // Parametrlərə əsasən həm prompt, həm də limitlər avtomatik formalaşır
            //        if (int.TryParse(Console.ReadLine(), out number) && number >= minValue && number <= maxValue)
            //        {
            //            return number;
            //        }
            //        Console.Write($"Invalid input. Please enter a valid {digitCount}-digit number: ");
            //    }
            //}

            #endregion

            #region Task 14

            /* 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
                6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
                Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
                Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
                Neticenin 60 % tap. Cavabin axirina 60 artir.
                Neticeden 18% cix. */

            //int num1 = GetValidNumber("first", 6);
            //int num2 = GetValidNumber("second", 6);
            //int num3 = GetValidNumber("third", 6);
            //int num4 = GetValidNumber("fourth", 7);

            //int sumFirstThree = GetFirstThreeSum(num1) + GetFirstThreeSum(num2) + GetFirstThreeSum(num3);

            //int lastFourOfNum4 = num4 % 10000; // 7 rəqəmli ədədin son 4 rəqəmi

            //int firstThreeOfNum4 = num4 / 10000; // 7 rəqəmli ədədin ilk 3 rəqəmi

            //int productFirstThreeOfNum4 = 1;

            //while (firstThreeOfNum4 > 0)
            //{
            //    productFirstThreeOfNum4 *= firstThreeOfNum4 % 10;
            //    firstThreeOfNum4 /= 10;
            //}

            //int result = sumFirstThree + lastFourOfNum4 - productFirstThreeOfNum4;

            //double sixtyPercent = result * 0.6;

            //int partResult = (int)(sixtyPercent * 100 + 60); // Cavabin axirina 60 artir

            //double finalResult = partResult - (partResult * 0.18); // Neticeden 18% cix

            //static int GetFirstThreeSum(int number)
            //{
            //    number = Math.Abs(number); // Mənfi ədəd riskinə qarşı
            //    int firstThreeDigits = number / 1000; // İlk 3 rəqəmi alırıq
            //    return firstThreeDigits;
            //}

            //static int GetValidNumber(string orderName, int digitCount)
            //{
            //    int minValue = (int)Math.Pow(10, digitCount - 1);
            //    int maxValue = (int)Math.Pow(10, digitCount) - 1;

            //    Console.Write($"Enter the {orderName} {digitCount}-digit number: ");

            //    int number;
            //    while (true)
            //    {
            //        // Parametrlərə əsasən həm prompt, həm də limitlər avtomatik formalaşır
            //        if (int.TryParse(Console.ReadLine(), out number) && number >= minValue && number <= maxValue)
            //        {
            //            return number;
            //        }
            //        Console.Write($"Invalid input. Please enter a valid {digitCount}-digit number: ");
            //    }
            //}

            #endregion

            #region Task 15

            /* 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
                 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
                 Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
                 Cavabdan 7 reqemli ededin son 5 reqemini cix.
                 Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
                 Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
                 Cavabin axirina 11 artir.
                 Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
                 Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et. */

            // 1. Ədədlərin dinamik şəkildə daxil edilməsi (long tipli)
            long num1_3 = GetValidNumber("1-ci (3 rəqəmli)", 3);
            long num2_3 = GetValidNumber("2-ci (3 rəqəmli)", 3);
            long num1_6 = GetValidNumber("1-ci (6 rəqəmli)", 6);
            long num2_6 = GetValidNumber("2-ci (6 rəqəmli)", 6);
            long num1_7 = GetValidNumber("1-ci (7 rəqəmli)", 7);

            // Addım 1: 3 rəqəmlilərin cəminin axırdan 2 rəqəminin kvadratı
            long sum3 = num1_3 + num2_3;
            long last2OfSum3 = sum3 % 100;
            long step1 = last2OfSum3 * last2OfSum3;

            // Addım 2: 3 rəqəmliləri yapışdır (məs: 123 və 456 -> 123456) və step1-in üstünə gəl
            long concat3 = (num1_3 * 1000) + num2_3;
            long step2 = step1 + concat3;

            // Addım 3: step2 - 7 rəqəmli ədədin son 5 rəqəmi
            long last5Of7 = num1_7 % 100000;
            long step3 = step2 - last5Of7;

            // Addım 4: step3 + 6 rəqəmlilərin cəminin axırıncı 3 rəqəmi
            long sum6 = num1_6 + num2_6;
            long last3OfSum6 = sum6 % 1000;
            long step4 = step3 + last3OfSum6;

            // Addım 5: step4 + 7 rəqəmli ədədin rəqəmləri cəminin tərsi
            long sumOfDigits7 = GetSumOfDigits(num1_7);
            long reversedSum = ReverseNumber(sumOfDigits7);
            long step5 = step4 + reversedSum;

            // Addım 6: Cavabın axırına 11 artır. 
            // (Riyazi daşma və ya mənfi ədəd xətalarından qaçmaq üçün String istifadə edirik)
            string step6Str = step5.ToString() + "11";
            long step6 = long.Parse(step6Str);

            // Addım 7: step6 - 7 rəqəmli ədədin tək yerdə dayanan rəqəmlərindən alınan ədəd
            // Qeyd: "Tək yerdə dayananlar" soldan sağa 1, 3, 5, 7-ci rəqəmlər sayılır (indeks 0, 2, 4, 6)
            long oddPositionsNum = GetOddPositionDigits(num1_7);
            long step7 = step6 - oddPositionsNum;

            // Addım 8: Axırdan 2-ci ilə sonuncu rəqəmin arasına 88 əlavə et
            string step7Str = step7.ToString();
            // Insert metodu mətni verilmiş indeksdən bölür və arasına istədiyimizi yazır
            string finalResultStr = step7Str.Insert(step7Str.Length - 1, "88");
            long finalResult = long.Parse(finalResultStr);

            // Nəticəni göstər
            Console.WriteLine("\n--- Yekun Nəticə ---");
            Console.WriteLine($"Final cavab: {finalResult}");

            static long GetValidNumber(string orderName, int digitCount)
            {
                long minValue = (long)Math.Pow(10, digitCount - 1);
                long maxValue = (long)Math.Pow(10, digitCount) - 1;

                Console.Write($"Daxil edin: {orderName} ədəd: ");
                long number;
                while (true)
                {
                    if (long.TryParse(Console.ReadLine(), out number) && number >= minValue && number <= maxValue)
                    {
                        return number;
                    }
                    Console.Write($"Səhv daxiletmə. Zəhmət olmasa {digitCount} rəqəmli ədəd daxil edin: ");
                }
            }

            // Ədədin rəqəmlərinin cəmini tapır
            static long GetSumOfDigits(long number)
            {
                number = Math.Abs(number);
                long sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            // Ədədi tərsinə çevirir (məsələn, 42 -> 24)
            static long ReverseNumber(long number)
            {
                // LINQ istifadə edərək ən oxunaqlı tərsinə çevirmə üsulu
                string reversedStr = new string(number.ToString().Reverse().ToArray());
                return long.Parse(reversedStr);
            }

            // Tək yerdə (soldan sağa: 1-ci, 3-cü...) dayanan rəqəmlərdən ədəd düzəldir
            static long GetOddPositionDigits(long number)
            {
                string numStr = Math.Abs(number).ToString();
                string resultStr = "";

                // Indekslər 0-dan başlayır. 0 (1-ci), 2 (3-cü), 4 (5-ci) rəqəmləri yığırıq
                for (int i = 0; i < numStr.Length; i += 2)
                {
                    resultStr += numStr[i];
                }
                return long.Parse(resultStr);
            }
        }

        #endregion
    }
    
}
