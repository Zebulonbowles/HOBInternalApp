using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    interface IAddressRepository
    {
        public Task<AddressDTO> CreateAddress(AddressDTO addressDTO);
        public Task<AddressDTO> UpdateAddress(int addressId, AddressDTO addressDTO);
        public Task<AddressDTO> GetAddress(int addressId);
        public Task<IEnumerable<AddressDTO>> GetAllAddresses();
        public Task<int> DeleteAddress(int addressId);

    }
}
