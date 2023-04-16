using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_C_
{
    internal class Task1
    {

        public string _FullName { get; set; }
        public DateTime _BirthDate { get; set; }
        public string _PhoneNumber { get; set; }
        public string _WorkEmail { get; set; }
        public string _Position { get; set; }
        public string _JobDescription { get; set; }
        public int _Salary { get; set; }


        public Task1()
        {
            Console.WriteLine("Enter full name:");
            _FullName = Console.ReadLine();

            Console.WriteLine("Enter birth date (yyyy-mm-dd):");
            _BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone number:");
            _PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter work email:");
            _WorkEmail = Console.ReadLine();

            Console.WriteLine("Enter position:");
            _Position = Console.ReadLine();

            Console.WriteLine("Enter job description:");
            _JobDescription = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            _Salary = int.Parse(Console.ReadLine());
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Full Name: {0}", _FullName);
            Console.WriteLine("Birth Date: {0}", _BirthDate);
            Console.WriteLine("Phone Number: {0}", _PhoneNumber);
            Console.WriteLine("Work Email: {0}", _WorkEmail);
            Console.WriteLine("Position: {0}", _Position);
            Console.WriteLine("Job Description: {0}", _JobDescription);
        }

        public static Task1 operator +(Task1 obj, int num)
        {
            obj._Salary += num;
            return obj;
        }
        public static Task1 operator -(Task1 obj, int num)
        {
            obj._Salary += num;
            return obj;
        }
        public static bool operator >(Task1 obj, int num)
        {
            return obj._Salary > num;
        }

        public static bool operator <(Task1 obj, int num)
        {
            return obj._Salary < num;
        }

        public static bool operator ==(Task1 emp1, Task1 emp2)
        {


            return emp1._FullName == emp2._FullName &&
                   emp1._BirthDate == emp2._BirthDate &&
                   emp1._PhoneNumber == emp2._PhoneNumber &&
                   emp1._WorkEmail == emp2._WorkEmail &&
                   emp1._Position == emp2._Position &&
                   emp1._JobDescription == emp2._JobDescription &&
                   emp1._Salary == emp2._Salary;
        }

        public static bool operator !=(Task1 emp1, Task1 emp2)
        {
            return !(emp1 == emp2);
        }

        public override bool Equals(Object obj)
        {


            return this == (Task1)obj;
        }
    }
}