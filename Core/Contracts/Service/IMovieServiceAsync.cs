using Core.Entities;
using Core.Models;

namespace Core.Contracts.Service
{
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieModel>> GetAllMoviesAsync();
		Task<MovieModel> GetByIdAsync(int movieId);
        Task<int> AddMovieAsync(MovieModel model);
        Task<int> UpdateMovieAsync(MovieModel model);
        Task<int> DeleteMovieAsync(int id);
    }
}
