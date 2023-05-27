using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Abstract;
using System.Collections.Generic;

namespace Dormitory.Domain.Repositories.Concreate.Memory
{
    public class MemoryStudentRepository : IStudentRepository
    {
        protected List<Student> student_vector;
        
        public MemoryStudentRepository()
        {
            student_vector = new List<Student>();
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
