using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookSystem
{
    internal class Book : Object // Inheritance - törəmə
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
            Console.WriteLine($"Adi: {name} \n{authorName}\n {genre}\n {pageCount}\n {price}");
        }

        public override string ToString()
        {
            return $"Adi: {name} \n{authorName}\n {genre}\n {pageCount}\n {price}";
        }
    }

    class AZN
    {
        public double Value;

        public override string ToString()
        {
            return $"{Value}₼";
        }
    }
}
