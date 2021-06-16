using AutoMapper;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddressDTO, Address>();
            CreateMap<Address, AddressDTO>();

            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>();

            CreateMap<PersonDTO, Person>();
            CreateMap<Person, PersonDTO>();

            CreateMap<FarmerDTO, Farmer>().
                ForMember(d => d.FarmAddress.Address1, opt=> opt.MapFrom(s => s.FarmAddress)).
                ForMember(d => d.ContactPerson.FirstName, opt=> opt.MapFrom(s=>s.FarmContactPersonFirstName)).
                ForMember(d => d.FarmPhone, opt => opt.MapFrom(s => s.FarmContactPhone)).ReverseMap();
    


        }
    }
}
