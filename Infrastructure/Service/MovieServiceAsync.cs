using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Core.Models;

namespace Infrastructure.Service
{
    public class MovieServiceAsync : IMovieServiceAsync
    {

        IMovieRepositoryAsync repo;

        public MovieServiceAsync(IMovieRepositoryAsync repo)
		{
            this.repo = repo;
		}

        public async Task<int> AddMovieAsync(MovieModel model)
        {
            Movie movie = new Movie();
            movie.Price = model.Price;
            return await repo.InsertAsync(movie);
        }

        public async Task<int> DeleteMovieAsync(int id)
        {
            return await repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<MovieModel>> GetAllMoviesAsync()
        {
            var result = await repo.GetAllAsync();
            List<MovieModel> models = new List<MovieModel>();
            foreach (var r in result) models.Add(MovieModel.From(r));
            return models;
        }

        public async Task<MovieModel> GetByIdAsync(int id)
		{
            return MovieModel.From(await repo.GetByIdAsync(id));
        }

        public async Task<int> UpdateMovieAsync(MovieModel model)
        {
            Movie movie = new Movie();
            movie.Price = model.Price;
            return await repo.UpdateAsync(movie);

        }
    }
}
