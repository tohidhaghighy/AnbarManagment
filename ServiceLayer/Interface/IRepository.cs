using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IRepository<T>
    {
        Task<Boolean> Add(T item);
        Task<Boolean> Delete(int Id);
        Task<List<T>> GetAll();
        Task<T> Update(T item);
        Task<List<T>> GetSelect(Expression<Func<T, bool>> where);
        Task<T> GetItem(Expression<Func<T, bool>> where);
    }
}
