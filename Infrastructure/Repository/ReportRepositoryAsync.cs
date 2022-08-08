using Core.Contracts.Repository;
using Core.Entities;
using Core.Models;
using Dapper;
using Infrastructure.Data;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ReportRepositoryAsync : BaseRepositoryAsync<MovieModel>, IReportRepositoryAsync
    {

        public ReportRepositoryAsync(MVCDbContext _context) : base(_context) { }


        public async Task<IEnumerable<MovieModel>> GetTopPurchasedMovies(
            DateTime? fromDate, DateTime? toDate,
            int pageSize, int pageIndex)
        {
            using (IDbConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString))
            {
                string sql = "select * from movie where releasedate between @past and @future";
                IEnumerable<MovieModel> movies = 
                    await conn.QueryAsync<MovieModel>(sql, new { past = fromDate, future = toDate});
                return movies.ToList();
            }
        }
    }
}
