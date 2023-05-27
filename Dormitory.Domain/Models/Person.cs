using Dormitory.Domain.Exceptions;
using System;

namespace Dormitory.Domain.Models
{
    public class Person
    {
        protected string name;
        protected string surname;
        protected short age;

        /*public Person(string name, string surname, short age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }*/

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length > 20 || value.Length == 0) {
                    //throw new Exception("Invalid data");
                    throw new NameStateException("Invalid data");
                }
                this.name = value;
            }
        }

        public string Surname
        {
            get { return surname; }
            set 
            {
                if (value.Length > 20 || value.Length == 0) { throw new Exception("Invalid data"); }
                surname = value; 
            }
        }

        public short Age
        {
            get { return age; }
            set 
            {
                if (value > 150 || value <= 0) { throw new Exception("Invalid data"); }
                age = value;
            }
        }

        public override string ToString() => $"{name} {surname} {age}";
    }
}
