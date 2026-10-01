using C_Lesson04._02.DataModels;
using C_Lesson04._02.MyCodes;
using System.Diagnostics;

namespace C_Lesson04._02
{
    internal class Program
    {
        #region Toplama Metodları
        //static int a = 10;
        //static int b = 60;
        //static void Main(string[] args)
        //{
        //    ToplaFile();
        //}

        //static void Topla()
        //{
        //    int cem = a + b;
        //    Console.WriteLine(cem);
        //}

        //static void ToplaSMS()
        //{
        //    int cem = a + b;
        //    Debug.WriteLine(cem);
        //}

        //static void ToplaFile()
        //{
        //    int cem = a + b;
        //    File.WriteAllText("C:\\Users\\Elvin\\Desktop\\demo.txt", cem.ToString());
        //}
        #endregion

        #region Toplama Metodları 2
        //static int a = 10;
        //static int b = 60;
        //static void Main(string[] args)
        //{
        //    SalamDe();
        //    int cavab = Topla();

        //    Console.WriteLine(cavab);
        //    Debug.WriteLine(cavab);
        //}

        //static int Topla()
        //{
        //    int cem = a + b;
        //    return cem;
        //}
        //static void SalamDe()
        //{
        //    Console.WriteLine("Salamlar!");
        //}
        #endregion

        #region Toplama Metodları 3

        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    int y = 60;

        //    SalamDe();
        //    int cavab = Topla(x, y);
        //    Console.WriteLine(cavab);
        //    Debug.WriteLine(cavab);
        //}

        //static int Topla(int a, int b)
        //{
        //    int cem = a + b;
        //    return cem;
        //}
        //static void SalamDe()
        //{
        //    Console.WriteLine("Salamlar!");
        //}
        #endregion

        #region Toplama Metodları 4

        //static void Main(string[] args)
        //{
        //    double x = 10;
        //    int y = 60;

        //    double cavab = Topla(x, y);
        //    Console.WriteLine(cavab);
        //    Debug.WriteLine(cavab);
        //}

        //static int Topla(int a, int b)
        //{
        //    int cem = a + b;
        //    return cem;
        //}
        //static double Topla(double a, double b)
        //{
        //    double cem = a + b;
        //    return cem;
        //}
        #endregion

        #region Toplama Metodları 5 Instance Method
        //static void Main(string[] args)
        //{
        //    double x = 10;
        //    int y = 60;

        //    Program p = new Program(); // sinifin instance yaratmaq lazımdır ki, non-static metodları çağıra bilək

        //    double cavab = p.Topla(x, y);
        //    Console.WriteLine(cavab);
        //    Debug.WriteLine(cavab);
        //}

        //static int Topla(int a, int b)
        //{
        //    int cem = a + b;
        //    return cem;
        //}
        //double Topla(double a, double b)
        //{
        //    double cem = a + b;
        //    return cem;
        //}
        #endregion

        #region Instance and Static Methods in Class

        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    int y = 60;

        //    Calculator c = new Calculator(); // sinifin instance yaratmaq lazımdır ki, non-static metodları çağıra bilək
        //    c.Topla(x, y);
        //    Calculator.Ferq(x, y); // static metodları çağırmaq üçün sinifin instance yaratmağa ehtiyac yoxdur
        //}

        //class Calculator
        //{
        //    internal int Topla(int a, int b)
        //    {
        //        int cem = a + b;
        //        return cem;
        //    }
        //    static internal int Ferq(int a, int b)
        //    {
        //        int ferq = a - b;
        //        return ferq;
        //    }
        //}

        #endregion

        #region Instance and Static Methods in Calculator Class 2

        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    int y = 60;

        //    Calculator c = new Calculator(); // sinifin instance yaratmaq lazımdır ki, non-static metodları çağıra bilək
        //    int cavab = c.Topla(x, y);

        //    Console.WriteLine(cavab);

        //    Calculator.Ferq(x, y); // static metodları çağırmaq üçün sinifin instance yaratmağa ehtiyac yoxdur
        //}
        #endregion

        #region Instance and Static Methods in Student Class
        //static void Main(string[] args)
        //{
        //    Student stu1 = new Student();
        //    Student.name = "Aqil";
        //    stu1.surname = "Abbasov";
        //    stu1.age = 26;

        //    Student stu2 = new Student();
        //    Student.name = "Orxan";
        //    stu2.surname = "Aliyev";
        //    stu2.age = 23;

        //    //Console.WriteLine(stu2.surname);
        //    //Console.WriteLine(stu2.age);

        //    stu1.PrintInfo();
        //    stu2.PrintInfo();

        //}
        #endregion
        
        #region Instance and Static Methods in Student Class 2
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.name = "Aqil";
            stu1.surname = "Abbasov";
            stu1.age = 26;

            Student stu2 = new Student();
            stu2.name = "Orxan";
            stu2.surname = "Aliyev";
            stu2.age = 23;

            //Console.WriteLine(stu2.surname);
            //Console.WriteLine(stu2.age);

            stu1.PrintInfo();
            stu2.PrintInfo();

        }
        #endregion
    }
}
