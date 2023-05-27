using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Abstract;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Dormitory.Domain.Repositories.Concreate.Mock
{
    internal class MockStudentRepository : IStudentRepository
    {
        protected List<Student> student_vector;
        
        public MockStudentRepository()
        {
            student_vector = new List<Student> 
            {
                new Student{Name = "Artem", Surname = "Serbulov", Age = 19, Course = 2, Room_number = 100 },
                new Student{ Name = "Ivan", Surname = "Janchenko", Age = 19, Course = 2, Room_number = 101 },
                new Student{ Name = "Vlad", Surname = "Kutsyk", Age = 19, Course = 2, Room_number = 102 },
                new Student{ Name = "Oleksij", Surname = "Zvarych", Age = 19, Course = 2, Room_number = 101 }
            };
        }

        public void Add(Student student)
        {
            student_vector.Add(student);
        }

        public void EditAt(int index, Student student)
        {
            student_vector.RemoveAt(index);
            student_vector.Insert(index, student);
        }

        public void DeleteAt(int index)
        {
            student_vector.RemoveAt(index);
        }

        public List<Student> GetAll()
        {
            return student_vector;
        }
    }
}
