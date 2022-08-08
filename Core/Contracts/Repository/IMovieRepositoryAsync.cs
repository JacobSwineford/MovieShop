using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Contracts.Repository
{
    public interface IMovieRepositoryAsync : IRepositoryAsync<Movie>
    {
    }
}
