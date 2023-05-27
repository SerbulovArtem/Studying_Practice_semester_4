using Dormitory.Domain.Models;

namespace Dormitory.Domain.Convertors.Txt
{
    internal class WorkerTxtConvertor : ITxtConvertor<Worker>
    {
        private char separator = ',';

        public Worker Convert(string line)
        {
            var workerInfo = line.Split(separator);
            return new Worker
            {
                Name = workerInfo[0],
                Surname = workerInfo[1],
                Age = System.Convert.ToInt16(workerInfo[2]),
                Position = workerInfo[3],
                Salary = System.Convert.ToInt32(workerInfo[4])
            };
        }

        public string Convert(Worker student)
        {
            return $"{student.Name}{separator}{student.Surname}{separator}{student.Age}{separator}{student.Position}{separator}{student.Salary}";
        }
    }
}
