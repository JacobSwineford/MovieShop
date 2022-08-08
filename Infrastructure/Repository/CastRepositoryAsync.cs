using Core.Contracts.Repository;
using Core.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepositoryAsync
    {
        public CastRepositoryAsync(MVCDbContext _context) : base(_context) {}
    }
}
