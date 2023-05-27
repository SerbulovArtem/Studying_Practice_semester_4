using System;

namespace Dormitory.Domain.Models
{
    public class Student : Person
    {
        protected sbyte course;
        protected int room_number;

        /*public Student(string name, string surname, short age, sbyte course, int room_number) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Course = course;
            Room_number = room_number;
        }*/

        public sbyte Course
        {
            get { return course; }
            set 
            {
                if (value > 7 || value <= 0) { throw new Exception("Invalid data"); }
                course = value;
            }
        }

        public int Room_number
        {
            get { return room_number; }
            set
            {
                if (value > 1000 || value <= 0) { throw new Exception("Invalid data"); }
                room_number = value;
            }
        }

        public override string ToString() => $"{name} {surname} {age} {course} {room_number}";
    }
}
