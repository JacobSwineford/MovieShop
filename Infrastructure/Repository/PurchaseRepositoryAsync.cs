using Core.Contracts.Repository;
using Core.Entities;

namespace MVC_Project.Infrastructure.Repository
{
    public class PurchaseRepositoryAsync : IPurchaseRepositoryAsync
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Purchase>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Purchase> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Purchase data)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Purchase data)
        {
            throw new NotImplementedException();
        }
    }
}
