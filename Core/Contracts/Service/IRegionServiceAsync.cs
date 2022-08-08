using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IRegionServiceAsync
    {
        Task<int> InsertRegionAsync(RegionModel regionModel);
        Task<IEnumerable<RegionModel>> GetAllRegionsAsync();
        Task<int> DeleteRegionAsync(int id);

        Task<int> UpdateRegionAsync(RegionModel model);
        Task<object?> GetAllAsync();
        Task GetRegionByIdAsync(int id);
    }
}