namespace ConsoleAppBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = new int();

            a = 10;

            Book kitab1 = new Book();

            kitab1.name = "The Great Gatsby";
            kitab1.authorName = "F. Scott Fitzgerald";
            kitab1.genre = "Novel";
            kitab1.pageCount = 180;
            kitab1.price = 10.99;

            kitab1.ShowInfo();
        }
    }
}
