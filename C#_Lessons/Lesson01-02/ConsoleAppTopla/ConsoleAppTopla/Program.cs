namespace ConsoleAppTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region CutFor
        //for (int i = 1; i < 10; i++)
        //{
        //    Console.WriteLine($">> {i}");
        //    if (i % 2!=0)
        //    {
        //        continue;
        //    }

        //    Console.WriteLine(i); 
        //}
        #endregion

        #region unsafe
        //int a = 14;

        //unsafe
        //{
        //    int* addr = &a;
        //    Console.WriteLine(a);
        //    Console.WriteLine((IntPtr)addr);
        //}
        #endregion

        #region bool
        //bool adamSistemdedir = false; //1byte

        //if (adamSistemdedir == true)
        //{
        //    Console.WriteLine("sidebar gorunur");
        //}
        //else
        //{
        //    Console.WriteLine("sidebar gorunmur");
        //}
        #endregion

        #region massiv
        //int[] numbers = { 22, 13, 17, 30, 50 };

        //bool hamisiCutdur = true;

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 != 0)
        //    {
        //        hamisiCutdur = false;
        //        break;
        //    }
        //}
        //Console.WriteLine(hamisiCutdur);
        #endregion

        #region sizeof
        //Console.WriteLine($"Size: {sizeof(byte)}");
        //Console.WriteLine($"Min: {byte.MinValue}");
        //Console.WriteLine($"Min: {byte.MaxValue}");
        //Console.WriteLine(sizeof(byte));

        //Console.WriteLine($"Size: {sizeof(int)}");
        //Console.WriteLine($"Min: {int.MinValue}");
        //Console.WriteLine($"Min: {int.MaxValue}");
        //Console.WriteLine($"CTS Type Name: {typeof(int)}");
        //Console.WriteLine($"Default: {default(int)}");
        #endregion

        #region convert

        //string strValue = Console.ReadLine();

        //int value = Convert.ToInt32(strValue);

        //Console.WriteLine(value + 1);

        #endregion

        #region convertTryParse

        //label1:

        //    Console.Write("yashiniz: ");

        //    string strAge = Console.ReadLine();

        //    bool veziyyet = int.TryParse(strAge, out int age);

        //    if (veziyyet == false)
        //    {
        //        goto label1;
        //    }

        //    if (age < 18)
        //    {
        //        Console.WriteLine("Yashiniz suruculuk vesiqesi ucun uygun deyil!");
        //        Console.ReadKey();
        //        goto label1;
        //    }

        #endregion

        #region goto

        //l1:
        //    Console.Write("a: ");

        //    string strA = Console.ReadLine();

        //    if (!int.TryParse(strA, out int a))
        //    {
        //        goto l1;
        //    }

        //l2:
        //    Console.Write("b: ");

        //    string strB = Console.ReadLine();

        //    if (!int.TryParse(strB, out int b))
        //    {
        //        goto l2;
        //    }

        //    int c = a + b;

        //    Console.WriteLine(a + "+" + b + "=" + c);
        //    Console.WriteLine("{0}+{1}={2}", a, b, c);

        //    Console.WriteLine($"{a}+{b}={c}");

            #endregion
        }
    }
}
