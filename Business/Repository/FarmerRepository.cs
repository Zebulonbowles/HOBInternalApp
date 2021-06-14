using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Repository
{
    public class FarmerRepository : IFarmerRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public FarmerRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<FarmerDTO> CreateFarmer(FarmerDTO farmerDTO)
        {
            Farmer farmer = _mapper.Map<FarmerDTO, Farmer>(farmerDTO);

            var addedFarmer = await _db.Farmers.AddAsync(farmer);
            await _db.SaveChangesAsync();
            return _mapper.Map<Farmer, FarmerDTO>(addedFarmer.Entity);
        }

        public async Task<FarmerDTO> GetFarmer(int farmerId)
        {
            try
            {
                FarmerDTO farmer = _mapper.Map<Farmer, FarmerDTO>(
                await _db.Farmers.FirstOrDefaultAsync(x => x.Id == farmerId));
                return farmer;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<FarmerDTO>> GetAllFarmers()
        {
            try
            {
                IEnumerable<FarmerDTO> farmerDTOs =
                    _mapper.Map<IEnumerable<Farmer>, IEnumerable<FarmerDTO>>(_db.Farmers);

                return farmerDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<FarmerDTO> UpdateFarmer(int farmerId, FarmerDTO farmerDTO)
        {
            try
            {
                if (farmerId == farmerDTO.Id)
                {
                    var farmerDetails = await _db.Farmers.FindAsync(farmerId);
                    var farmer = _mapper.Map<FarmerDTO, Farmer>(farmerDTO, farmerDetails);
                    var updatedFarmer = _db.Farmers.Update(farmer);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Farmer, FarmerDTO>(updatedFarmer.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<int> DeleteFarmer(int farmerId)
        {
            var farmer = await _db.Farmers.FindAsync(farmerId);
            if (farmer != null)
            {
                _db.Farmers.Remove(farmer);
                return await _db.SaveChangesAsync();

            }
            return 0;
        }
    }
}
