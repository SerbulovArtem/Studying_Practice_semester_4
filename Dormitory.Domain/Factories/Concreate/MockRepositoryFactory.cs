using Dormitory.Domain.Factories.Abstract;
using Dormitory.Domain.Repositories.Abstract;
using Dormitory.Domain.Repositories.Concreate.Mock;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dormitory.Domain.Factories.Concreate
{
    internal class MockRepositoryFactory : IRepositoryFactory
    {
        public IStudentRepository GetStudentRepository()
        {
            return new MockStudentRepository();
        }

        public IWorkerRepository GetWorkerRepository() 
        {
            return new MockWorkerRepository();
        }
    }
}
