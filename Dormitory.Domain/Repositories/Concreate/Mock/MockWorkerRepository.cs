using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Abstract;
using System.Collections.Generic;

namespace Dormitory.Domain.Repositories.Concreate.Mock
{
    internal class MockWorkerRepository : IWorkerRepository
    {
        protected List<Worker> worker_vector;

        public MockWorkerRepository()
        {
            worker_vector = new List<Worker>
            {
                new Worker{ Name = "Sus", Surname = "Polk", Age = 25, Position = "Guard", Salary = 3000 },
                new Worker{ Name = "Andrij", Surname = "Kravets", Age = 32, Position = "Cleaner", Salary = 2500 },
                new Worker{ Name = "DeLano", Surname = "Rusvelt", Age = 40, Position = "Manager", Salary = 5000 },
                new Worker{ Name = "Olk", Surname = "Patri", Age = 20, Position = "Guard", Salary = 3000 }
            };
        }

        public void Add(Worker worker)
        {
            worker_vector.Add(worker);
        }

        public void EditAt(int index, Worker worker)
        {
            worker_vector.RemoveAt(index);
            worker_vector.Insert(index, worker);
        }

        public void DeleteAt(int index)
        {
            worker_vector.RemoveAt(index);
        }

        public List<Worker> GetAll()
        {
            return worker_vector;
        }
    }
}
