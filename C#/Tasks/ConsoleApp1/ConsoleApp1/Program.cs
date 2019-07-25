using System;

namespace ConsoleApp1
{
    class student : human
    {
        string hightschool;
        int year;
        string group;
        
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 5)
                    Console.WriteLine("Prom!");
                else
                if (value < 1)
                    Console.WriteLine("you are not student");
                else
                    year = value;
            }
        }
        public string Hightschool { get => hightschool; set => hightschool = value; }
        public string Group { get => group; set => group = value; }

        public student(string name, int age, string number, string hightschool) : base (name,age,number)
        {
            this.Hightschool = hightschool;
        }
        public void postupit()
        {
            year = 1;
        }
        public void end_of_course()
        {
            year++;
        }
        public void takegroup(string group)
        {
            this.group = group;
        }
       
    }
    class human
    {
        string name;
        int age;
        string number;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Age is incorrect");
            }
         }

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.Length > 8 || value.Length < 5)
                    Console.WriteLine("Number is incorrect");
                else
                    number = value;
            }
        }

        public human  (string name, int age, string number)
        {
            this.name = name;
            this.age = age;
            this.number = number;
        }
        public void showname ()
        {
            Console.WriteLine(Name);
        }
        public void birthday ()
        {
             Age += 1;
        }
        public void shownumber ()
        {
            Console.WriteLine(Number);
        }
    }
    class worker : human 
    {
        string company;
        string position;
        bool hvoroba_O_O = false;
        public string Company { get => company; set => company = value; }
        public string Position { get => position; set => position = value; }
        public bool Hvoroba_O_O { get => hvoroba_O_O; set => hvoroba_O_O = value; }
        public worker(string name, int age, string number, string company) : base(name, age, number)
        {
            this.company = company;
        }
        public void takeposition(string position)
        {
            this.position = position;
        }
        public void zabolet()
        {
            Hvoroba_O_O = true;
        }
        public void voscresnut()
        {
            Hvoroba_O_O = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            human human1 = new human("Василий", 13, "059203947");
            Console.WriteLine("about human");
            human1.birthday();
            Console.WriteLine(human1.Age);
            Console.WriteLine("about student");
            student student1 = new student("Danya", 18, "0501073094", "DNU");
            student1.postupit();
            student1.takegroup("ПА-18-2");
            Console.WriteLine(student1.Year);
            student1.end_of_course();
            Console.WriteLine(student1.Year);
            Console.WriteLine("about worker");
            worker worker1 = new worker("Vlad", 18, "05810283", "Company of fucking dolboebu");
            worker1.takeposition("Glavnui pidoras");
            Console.WriteLine(worker1.Position);
            worker1.zabolet();
            Console.WriteLine(worker1.Hvoroba_O_O);
            worker1.voscresnut();
            Console.WriteLine(worker1.Hvoroba_O_O);
            Console.ReadKey();
        }
    }
}
