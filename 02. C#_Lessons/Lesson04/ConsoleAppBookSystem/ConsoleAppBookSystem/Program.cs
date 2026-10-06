using System.Text;

namespace ConsoleAppBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int len;

        l1:
            Console.WriteLine("kitab sayi: ");

            if (!int.TryParse(Console.ReadLine(), out len) || len <= 0)
            {
                Console.WriteLine("0-dan boyuk eded daxil edilmelidi!");
                goto l1;
            }

            Book[] books = new Book[len];

            for (int i = 0; i < books.Length; i++)
            {

                Book book = new Book();

                book.name = ReadString($"{i + 1}, adi: ", false);
                book.name = ReadString($"{i + 1}, muellifi: ", false);
                book.name = ReadString($"{i + 1}, janrı: ", true);
                book.pageCount = ReadInteger($"{i + 1}, sehife sayi: ");
                book.price = ReadDouble($"{i + 1}, qiymeti: ");

                books[i] = book;


            }
            Console.WriteLine("Kitablariniz");

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

        }

        static void Task1()
        {
            //int a = new int();

            //a = 10;

            Book[] books = new Book[3];



            Book kitab1 = new Book();

            kitab1.name = "The Great Gatsby";
            kitab1.authorName = "F. Scott Fitzgerald";
            kitab1.genre = "Novel";
            kitab1.pageCount = 180;
            kitab1.price = 10.99;

            books[0] = kitab1;

            Book kitab2 = new Book();

            kitab2.name = "Alqış sədları altında";
            kitab2.authorName = "Çingiz Abdullayev";
            kitab2.genre = "Novel";
            kitab2.pageCount = 450;
            kitab2.price = 5.99;

            books[1] = kitab2;

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Kitab: {i + 1}");
                Console.WriteLine(books[i]);
            }

            //foreach (var book in books)
            //{
            //    Console.WriteLine("=======================");
            //    Console.WriteLine(book);
            //    Console.WriteLine("=======================");
            //}

            //Console.WriteLine(kitab1);
            //Console.WriteLine(kitab2);
            //Console.WriteLine($"{kitab1.price} ₼");



            //kitab1.ShowInfo();
            //Console.WriteLine("==================");
            //Console.WriteLine(kitab1);
            //Console.WriteLine("==================");
            //Console.WriteLine(kitab1.ToString());

            //AZN price = new AZN();
            //price.Value = 5.40;

            //Console.WriteLine(price.Value);
            //Console.WriteLine(price);
        }

        static string ReadString(string text, bool allowEmpty)
        {
        l1: Console.WriteLine(text);
            string name = Console.ReadLine();

            if (!allowEmpty && string.IsNullOrWhiteSpace(name))
            {
                goto l1;
            }
            return name;
        }

        static int ReadInteger(string text)
        {
            int a;
        l1: Console.Write(text);

            if (int.TryParse(Console.ReadLine(), out a))
            {
                goto l1;
            }
            return a;
        }
        static double ReadDouble(string text)
        {
            double a;
        l1: Console.Write(text);

            if (double.TryParse(Console.ReadLine(), out a))
            {
                goto l1;
            }
            return a;
        }
    }
}
