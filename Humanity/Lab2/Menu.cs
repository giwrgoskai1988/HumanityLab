using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2
{
    class Menu
    {
        public static List<Person> people;

        public Menu() { }
      
        static Menu()
        {
            people = new List<Person>();
        }

        public void Humanity()
        {
            Person p1 = new Student("st1", "st1ln", "AS44F", Gender.Male);
            Person p2 = new Student("st2", "st2ln", "54FDFGH", Gender.Female);
            Person p3 = new Worker("w1", "w1ln", 500, 8, Gender.Male);
            Person p4 = new Worker("w2", "w2ln", 400, 7, Gender.Other);

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);



            bool flag = true;
            Console.WriteLine("-------WELCOME!-------");
            while (flag)
            {
                int answer = Helper.IntCheck("\nPlease enter a number according to your choice:\n1.Add Student\n2.Add Worker\n3.Show Student\n4.Show Worker\n5.Exit", 5);

                Console.WriteLine("\nPlease enter a number according to your choice:\n1.Add Student\n2.Add Worker\n3.Show Student\n4.Show Worker\n5.Exit");

                switch (answer)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddWorker();
                        break;
                    case 3:
                        ShowPerson();
                        break;
                    case 4:
                        ShowPerson(false);
                        break;
                    case 5:
                        flag = false;
                        break;
                }



                //******************************************  IGNORE 
                //delegate asdf = (answer switch
                //{
                //    (1) => (Action)AddStudent,
                //    (2) => (Action)AddWorker,
                //    (3) => (Action<bool>)ShowPerson,
                //    (4) => (Action<bool>)ShowPerson,
                //    (5)=>false,
                //    _ => throw new ArgumentException("Can't be null")
                //});
            }
        }
        

        //******************************************  IGNORE 
        //public void asdfasdf(int answer)
        //{
        //    object a = (answer switch
        //    {
        //        (1) => (Action)AddStudent,
        //        (2) => (Action)AddWorker,
        //        (3) => (Action<bool>)ShowPerson,
        //        (4) => (Action<bool>)ShowPerson,
        //        (5) => false,
        //        _ => throw new ArgumentException("")
        //    });

        //    Console.WriteLine(a.ToString());
        //}

        void AddStudent()
        {

            ArrayList st = new ArrayList
            {
                Helper.StringChecker("first name" , Person.firstnamelength),
                Helper.StringChecker("last name", Person.lastnamelength),
                Helper.FacultyNumber(),
                (Gender)Helper.IntCheck("Gender:\n1.Male\n2.Female\n3.Other",3),
            };

            Student student = new Student((string)st[0], (string)st[1], (string)st[2], (Lab2.Gender)(st[3]));

            people.Add(student);
        }

        void AddWorker()
        {

            ArrayList wr = new ArrayList
            {
                Helper.StringChecker("first name" , Person.firstnamelength),
                Helper.StringChecker("last name", Person.lastnamelength),
                Helper.DoubleCheck("week salary", Worker.weekSalaryMin),
                Helper.IntCheck("working hours", Worker.workingHoursMax),
                (Gender)Helper.IntCheck("Gender:\n1.Male\n2.Female\n3.Other",3),
            };

            Worker worker = new Worker((string)wr[0], (string)wr[1], (double)wr[2], (int)wr[3], (Lab2.Gender)(wr[4]));


            people.Add(worker);

        }

        void ShowPerson(bool a = true)
        {
            var d = a ? people.Where(p => p.GetType() == typeof(Student)).ToList() : people.Where(p => p.GetType() == typeof(Worker)).ToList();

            foreach (Person person in d)
            {
                person.Print();
            }
        }


    }
}
    
