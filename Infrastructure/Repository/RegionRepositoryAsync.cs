using Core.Contracts.Repository;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class RegionRepositoryAsync : BaseRepositoryAsync<Region>, IRegionRepositoryAsync
    {
        public RegionRepositoryAsync(MVCDbContext _context) : base(_context) { }
    }
}
