using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IAdminServiceAsync
    {
        Task<IEnumerable<PurchaseModel>> GetTopPurchasesAsync(
                        [FromQuery] DateTime? fromDate = null,
                        [FromQuery] DateTime? toDate = null,
                        [FromQuery] int pageSize = 30,
                        [FromQuery] int pageIndex = 1);
    }
}
