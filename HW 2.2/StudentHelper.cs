using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2._2
{
    static class StudentHelper
    {
        public static string TakeName()
        {
            Console.Write("Please, enter your First and Last name ...");
            string name = Console.ReadLine();

            return name;
        }

        public static byte TakeAge()
        {
            Console.Write("Please, enter your age ...");
            byte age = Convert.ToByte(Console.ReadLine());

            return age;
        }

    }
}
