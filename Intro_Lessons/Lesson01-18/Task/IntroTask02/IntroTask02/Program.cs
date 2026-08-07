namespace IntroTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            /* 2 olculu massiv verilmisdir.Onun her sutunundaki en boyuk elementi tap. */

            //Console.Write("Massivin uzunluğunu daxil edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n, n];

            //Console.WriteLine("Massivin elementlərini daxil edin: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"arr[{i},{j}]= ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}

            //for (int j = 0; j < arr.GetLength(1); j++)
            //{
            //    int max = arr[0, j];
            //    for (int i = 1; i < arr.GetLength(0); i++)
            //    {
            //        if (arr[i, j] > max)
            //        {
            //            max = arr[i, j];
            //        }
            //    }
            //    Console.WriteLine($"Sutun {j} üçün ən böyük element: {max}");
            //}

            #endregion

            #region Task 2

            /* 1 olculu massiv verilmisdir. Buna esases asagidaki tapsiriqlari yerine yetirin:
                -Tek elementlerin say
                -Menfi elementlerin sayi
                -Kvadrat koku tam olan elementleri.(Meselen 16,25,49) */

            //Console.Write("Massivin uzunluğunu daxil edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //Console.WriteLine("Massivin elementlərini daxil edin: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"arr[{i}]= ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int oddCount = 0;
            //int negativeCount = 0;
            //int perfectSquareCount = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        oddCount++;
            //    }
            //    if (arr[i] < 0)
            //    {
            //        negativeCount++;
            //    }
            //    if (arr[i] >= 0 && Math.Sqrt(arr[i]) % 1 == 0)
            //    {
            //        perfectSquareCount++;
            //    }
            //}

            //Console.WriteLine($"Tek elementlerin sayi: {oddCount}");
            //Console.WriteLine($"Menfi elementlerin sayi: {negativeCount}");
            //Console.WriteLine($"Kvadrat koku tam olan elementlerin sayi: {perfectSquareCount}");

            #endregion

            #region Task 3

            /* 1 olculu massiv verilmisdir. Onun elementlerinin ededi silsile emele getirib-getirmediyini tapin. */

            //Console.Write("Massivin uzunluğunu daxil edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //Console.WriteLine("Massivin elementlərini daxil edin: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"arr[{i}]= ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int d = arr[1] - arr[0];
            //for (int i = 2; i < n; i++)
            //{
            //    if (arr[i] - arr[i - 1] != d)
            //    {
            //        Console.WriteLine("Massiv ededi silsile deyil.");
            //        return;
            //    }
            //}

            //Console.WriteLine("Massiv ededi silsiledir.");

            #endregion

            #region Task 4

            /*  1 olculu massiv verilmisdir. Onun elemenlerini tersine duzun. Yani birinci element sonuncu, sonuncu element ise birinci olsun(1,2,3 => 3,2,1) */

            Console.Write("Massivin uzunluğunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Massivin elementlərini daxil edin: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }

            Console.WriteLine("Massivin tersine duzulmus hali: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            #endregion
        }
    }
}
