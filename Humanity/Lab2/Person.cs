using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
      
        protected string _FirstName { get; set; }
        protected string _LastName { get; set; }
        protected Gender _Gender { get; set; }

        public static int firstnamelength;
        public static int lastnamelength;

        static Person()
        {
            firstnamelength = 3;
            lastnamelength = 3;
        }
        public Person(string fn, string ln, Gender g)
        {
            _FirstName = fn;
            _LastName = ln;
            _Gender = g;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Firstname:{_FirstName} -- Lastname:{_LastName} -- Gender:{_Gender}");
        }

    }
}
