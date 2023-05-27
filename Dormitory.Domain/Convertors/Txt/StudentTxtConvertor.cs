using Dormitory.Domain.Models;

namespace Dormitory.Domain.Convertors.Txt
{
    internal class StudentTxtConvertor : ITxtConvertor<Student>
    {
        private char separator = ',';

        public Student Convert(string line)
        {
            var studentInfo = line.Split(separator);
            return new Student{Name = studentInfo[0], Surname = studentInfo[1], Age = System.Convert.ToInt16(studentInfo[2])
                , Course = System.Convert.ToSByte(studentInfo[3]), Room_number = System.Convert.ToInt32(studentInfo[4])};
        }

        public string Convert(Student student)
        {
            return $"{student.Name}{separator}{student.Surname}{separator}{student.Age}{separator}{student.Course}{separator}{student.Room_number}";
        }
    }
}
