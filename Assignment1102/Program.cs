using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("kshitij", 80, 81, 92);
            s1.calculation();
            Console.WriteLine(s1);

            Student s2 = new Student("ram", 81, 82, 83);
            s2.calculation();
            Console.WriteLine(s2);

            Student s3 = new Student("om", 82, 83, 84);
            s3.calculation();
            Console.WriteLine(s3);
        }
    }
}
