using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    interface IFarmerRepository
    {
        public Task<FarmerDTO> CreateFarmer(FarmerDTO farmerDTO);
        public Task<FarmerDTO> UpdateFarmer(int farmerId, FarmerDTO farmerDTO);
        public Task<FarmerDTO> GetFarmer(int farmerId);
        public Task<IEnumerable<FarmerDTO>> GetAllFarmers();
        public Task<int> DeleteFarmer(int farmerId);
    }
}
