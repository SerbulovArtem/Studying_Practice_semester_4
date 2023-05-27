using Dormitory.Domain.Factories.Abstract;
using Dormitory.Domain.Repositories.Abstract;
using Dormitory.Domain.Repositories.Concreate.Txt;

namespace Dormitory.Domain.Factories.Concreate
{
    internal class TxtRepositoryFactory : IRepositoryFactory
    {
        public IStudentRepository GetStudentRepository()
        {
            return new TxtStudentRepository();
        }

        public IWorkerRepository GetWorkerRepository() 
        {
            return new TxtWorkerRepository();
        }
    }
}
