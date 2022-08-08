using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Repository
{
    // struct means no classes (data types)
    // class means no structs (reference types)
    public interface IRepositoryAsync<T> where T : class
    {
        Task<int> InsertAsync(T data);
        Task<int> UpdateAsync(T data);
        Task<int> DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

    }
}
