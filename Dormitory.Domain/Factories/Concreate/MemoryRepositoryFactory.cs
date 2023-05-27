using Dormitory.Domain.Factories.Abstract;
using Dormitory.Domain.Repositories.Abstract;
using Dormitory.Domain.Repositories.Concreate.Memory;

namespace Dormitory.Domain.Factories.Concreate
{
    internal class MemoryRepositoryFactory : IRepositoryFactory
    {
        public IStudentRepository GetStudentRepository()
        {
            return new MemoryStudentRepository();
        }

        public IWorkerRepository GetWorkerRepository() 
        {
            return new MemoryWorkerRepository();
        }
    }
}
