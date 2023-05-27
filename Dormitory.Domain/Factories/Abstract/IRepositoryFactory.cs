using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dormitory.Domain.Repositories.Abstract;

namespace Dormitory.Domain.Factories.Abstract
{
    public interface IRepositoryFactory
    {
        IStudentRepository GetStudentRepository();

        IWorkerRepository GetWorkerRepository();
    }
}
