using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Repository
{
    public interface IReportRepositoryAsync : IRepositoryAsync<MovieModel>
    {
        Task<IEnumerable<MovieModel>> GetTopPurchasedMovies(
            DateTime? fromDate = null, DateTime? toDate = null,
            int pageSize = 30, int pageIndex = 1);
    }
}
