using System;

namespace HW_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentHelper studentHelper = new StudentHelper();
            //string name = StudentHelper.TakeName();

            Student vasil = new Student("Vasiliy", 23);
            Student sveta = new Student("Sveta", 25);
            Student petro = new Student("Petro", 27);

            vasil.Display();
            sveta.Display();
            petro.Display();


            Console.ReadKey(); 
        }





    }
}