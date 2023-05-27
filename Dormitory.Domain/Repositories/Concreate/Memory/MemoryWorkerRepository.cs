using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Domain.Repositories.Concreate.Memory
{
    public class MemoryWorkerRepository : IWorkerRepository
    {
        protected List<Worker> worker_vector;

        public MemoryWorkerRepository()
        {
            worker_vector = new List<Worker>();
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
