using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(Student.GetCount());
            Student s2 = new Student(1, "sarvani", "sarvani@gmail.com");
            Console.WriteLine(Student.GetCount());

            Student s = new Student();
            Console.WriteLine(Student.GetCount());

            Program p = new Program();
            p.Show();
        }

        void Show()
        {

        }
    }
}
