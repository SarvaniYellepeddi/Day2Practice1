using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Student
    {
        int studentId;
        string studentName;
        string email;

        
        static int count;

        internal Student()
        {
            count++;
        }

        internal Student(int studentId, string studentName, string email)
        {
            count++;
            this.studentId = studentId;
            this.studentName = studentName;
            this.email = email;
        }

        //static method
        static internal int GetCount()
        {

            return count;
        }
    }
}
