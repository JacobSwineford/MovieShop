using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Models;
using Dapper;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class AdminServiceAsync : IAdminServiceAsync
    {
        IPurchaseRepositoryAsync pur;

        public AdminServiceAsync(IPurchaseRepositoryAsync pur)
        {
            this.pur = pur;
        }

        async Task<IEnumerable<PurchaseModel>> IAdminServiceAsync.GetTopPurchasesAsync(
            DateTime? fromDate,
            DateTime? toDate,
            int pageSize,
            int pageIndex)
        {
            var b = pur.GetAllAsync();
            var c = from p in b.Result where p.Id == 2 select p.Id;

            using (IDbConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString))
            {
                string sql = "select top 10 percent * from purchase order by totalprice desc";
                IEnumerable<PurchaseModel> purchases =
                    await conn.QueryAsync<PurchaseModel>(sql);
                return purchases.ToList();
            }
        }
    }
}
