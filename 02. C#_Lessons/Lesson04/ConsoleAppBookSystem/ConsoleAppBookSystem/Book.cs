using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookSystem
{
    internal class Book
    {
        /*
            PascalCase
            camelCase
            snake_case
         */
        public string name;
        public string authorName;
        public string genre;
        public int pageCount;
        public double price;

        public void ShowInfo()
        {
            Console.WriteLine($"{name} \n{authorName}\n {genre}\n {pageCount}\n {price} AZN");
        }
    }
}
