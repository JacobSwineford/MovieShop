using Core.Entities;

namespace Core.Contracts.Service
{
    public interface ICastServiceAsync
    {
        public Task<IEnumerable<Cast>> GetCastDetails(); // no cast details table, only cast table
    }
}
