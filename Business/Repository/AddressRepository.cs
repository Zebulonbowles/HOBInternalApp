using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public AddressRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<AddressDTO> CreateAddress(AddressDTO addressDTO)
        {
            Address address = _mapper.Map<AddressDTO, Address>(addressDTO);

            var addedAddress = await _db.Addresses.AddAsync(address);
            await _db.SaveChangesAsync();
            return _mapper.Map<Address, AddressDTO>(addedAddress.Entity);
        }

        public async Task<AddressDTO> GetAddress(int addressId)
        {
            try
            {
                AddressDTO address = _mapper.Map<Address, AddressDTO>(
                await _db.Addresses.FirstOrDefaultAsync(x => x.Id == addressId));
                return address;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<AddressDTO>> GetAllAddresses()
        {
            try
            {
                IEnumerable<AddressDTO> addressDTOs =
                    _mapper.Map<IEnumerable<Address>, IEnumerable<AddressDTO>>(_db.Addresses);

                return addressDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<AddressDTO> UpdateAddress(int addressId, AddressDTO addressDTO)
        {
            try
            {
                if (addressId == addressDTO.Id)
                {
                    var addressDetails = await _db.Addresses.FindAsync(addressId);
                    var address = _mapper.Map<AddressDTO, Address>(addressDTO, addressDetails);
                    var updatedAddress = _db.Addresses.Update(address);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Address, AddressDTO>(updatedAddress.Entity);
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
        public async Task<int> DeleteAddress(int addressId)
        {
            var address = await _db.Addresses.FindAsync(addressId);
            if (address != null)
            {
                _db.Addresses.Remove(address);
                return await _db.SaveChangesAsync();

            }
            return 0;
        }
    }
}
