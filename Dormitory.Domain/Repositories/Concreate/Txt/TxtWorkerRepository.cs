using Dormitory.Domain.Convertors.Txt;
using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Abstract;

namespace Dormitory.Domain.Repositories.Concreate.Txt
{
    internal class TxtWorkerRepository : TxtBaseRepository<Worker>, IWorkerRepository
    {
        public TxtWorkerRepository() : base("C:\\Users\\Артем\\source\\repos\\Studying_Practice_semester_4\\Dormitory.Domain\\Data\\Txt\\Workers.txt",
            new WorkerTxtConvertor())
        { }
    }
}
