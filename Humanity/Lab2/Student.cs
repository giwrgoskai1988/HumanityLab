using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student:Person
    { 
        private string _FacultyNumber { get; set; }

        public Student(string fn,string ln,string Fn,Gender g):base(fn,ln,g)
        {
            _FacultyNumber = Fn;
        }

        public override void Print()
        {     

            Console.WriteLine($"Firstname:{_FirstName} -- Lastname:{_LastName} -- Gender:{ _Gender} -- Faculty Number:{_FacultyNumber}");
        }

    }
}
