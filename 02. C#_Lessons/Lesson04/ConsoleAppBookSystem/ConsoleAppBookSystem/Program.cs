using System.Text;

namespace ConsoleAppBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            //int a = new int();

            //a = 10;

            Book kitab1 = new Book();

            kitab1.name = "The Great Gatsby";
            kitab1.authorName = "F. Scott Fitzgerald";
            kitab1.genre = "Novel";
            kitab1.pageCount = 180;
            kitab1.price = 10.99;

            kitab1.ShowInfo();
            Console.WriteLine("==================");
            Console.WriteLine(kitab1);
            Console.WriteLine("==================");
            Console.WriteLine(kitab1.ToString());

            AZN price = new AZN();
            price.Value = 5.40;

            Console.WriteLine(price.Value);
            Console.WriteLine(price);
        }
    }
}
