using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;

namespace Infrastructure.Service
{
    public class CastServiceAsync : ICastServiceAsync
    {

        ICastRepositoryAsync rep;

        public CastServiceAsync(ICastRepositoryAsync rep)
        {
            this.rep = rep;
        }
        public async Task<IEnumerable<Cast>> GetCastDetails()
        {
            var re = await rep.GetAllAsync();
            return re.ToList();
        }
    }
}
