using Core.Contracts.Repository;
using Core.Entities;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class MovieRepositoryAsync : BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        public MovieRepositoryAsync(MVCDbContext _context) : base(_context) { }
    }
}
