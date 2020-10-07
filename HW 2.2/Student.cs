using System;

namespace HW_2._2
{
    public class Student
    {
        public string Name { get; set; }
        public byte Age { get; }

        public Student(string name, byte age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.Write(Name);
            Console.WriteLine(Age);
        }

    }

    //    internal class PaidStudent : Student
    //    {
    //        public int paidstudent(string name, byte age, int cardnumber)
    //            : base(name, age)
    //        {
    //            cardnumber = cardnumber;
    //        }
    //        public override void display()
    //        {
    //            console.writeline(name);
    //            console.writeline(age);
    //            console.writeline(cardnumber);
    //        }
    //    }

    //    internal class Budgetstudent : student
    //    {
    //        public int budgetstudent(string name, byte age)
    //            : base(name, age)

    //            console.writeline(name);
    //            console.writeline(age);
    //    }

}
