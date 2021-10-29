using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ben", "Programming", 2.3);
            Student student2 = new Student("Tim", "Arts", 3.7);
            Console.WriteLine(student1);
            Console.WriteLine(student2);

            Console.WriteLine("Studnet 1 honors: " + student1.hasHonors());
            Console.WriteLine("Studnet 2 honors: " + student2.hasHonors());

            Console.ReadLine();
        }
    }
}
