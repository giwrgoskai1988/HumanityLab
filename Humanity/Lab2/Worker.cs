using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Worker:Person
    {
        public static int weekSalaryMin;
        public static int workingHoursMax;
        private double _WeekSalary { get; set; }
        private int _WorkingHours { get; set; }

        static Worker()
        {
            weekSalaryMin = 10;
            workingHoursMax = 12;
        }
        public Worker(string fn,string ln,double ws,int wh,Gender g):base(fn,ln,g)
        {
            _WeekSalary = ws;
            _WorkingHours = wh;
        }

        public override void Print() => Console.WriteLine($"Firstname:{_FirstName} -- Lastname:{_LastName} -- Gender:{ _Gender} -- Weekly Salary:{_WeekSalary} -- Working Hours:{_WorkingHours} -- Hourly Salary:{SalaryPerHour()}");
        private double SalaryPerHour() => Math.Round((_WeekSalary / 5) / _WorkingHours , 2 , MidpointRounding.AwayFromZero);
    }   
}
