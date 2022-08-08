using Core.Contracts.Repository;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ShipperRepositoryAsync : BaseRepositoryAsync<Shipper>, IShipperRepositoryAsync
    {
        public ShipperRepositoryAsync(MVCDbContext _context) : base(_context) { }
    }
}
