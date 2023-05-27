using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Domain.Models
{
    public class Worker : Person
    {

        protected string position;
        protected int salary;

        /*public Worker(string name, string surname, short age, string position, int salary) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
        }*/

        public string Position
        {
            get { return position; }
            set 
            {
                if (value.Length > 30 || value.Length == 0) { throw new Exception("Invalid data"); }
                position = value;
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 1e8 || value <= 0) { throw new Exception("Invalid data"); }
                salary = value;
            }
        }

        public override string ToString() => $"{name} {surname} {age} {position} {salary}";
    }
}
