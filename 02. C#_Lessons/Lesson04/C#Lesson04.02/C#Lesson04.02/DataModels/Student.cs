using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson04._02.DataModels
{
    internal class Student
    {
        #region Members

        #region Fields
        //static public string name { get; set; } // static keyword classın özünə aid olan bir field və ya method olduğunu göstərir. Bu field bütün Student class-lar üçün eyni olacaq.
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        #endregion

        #region Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Surname: {this.surname}, Age: {age}"); // this keyword klassın özünü göstərir, amma burada istifadə olunması məcburi deyil.
        }
        #endregion
        #endregion
    }
}
