using System.Collections.Generic;

namespace Dormitory.Domain.Repositories.Abstract
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void DeleteAt(int index);

        void EditAt(int index, T entity);

        List<T> GetAll();
    }
}
