using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class RegionServiceAsync : IRegionServiceAsync
    {
        IRegionRepositoryAsync regionRepository;
        public RegionServiceAsync(IRegionRepositoryAsync _regionRepository)
        {
            regionRepository = _regionRepository;
        }

        public async Task<int> InsertRegionAsync(RegionModel regionModel)
        {
            Region regionEntity = new Region();
            regionEntity.Name = regionModel.Name;
            return await regionRepository.InsertAsync(regionEntity);
        }

        public async Task<IEnumerable<RegionModel>> GetAllRegionsAsync()
        {
            var result = await regionRepository.GetAllAsync();

            List<RegionModel> regions = new List<RegionModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    RegionModel r = new RegionModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    regions.Add(r);
                }
            }
            return regions;
        }

        public async Task<int> DeleteRegionAsync(int id)
        {
            return await regionRepository.DeleteAsync(id);
        }

        public async Task<int> UpdateRegionAsync(RegionModel model)
        {
            Region e = new Region
            {
                Name = model.Name,
                Id = model.Id
            };
            return await regionRepository.UpdateAsync(e);
        }

        public Task<object?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetRegionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
