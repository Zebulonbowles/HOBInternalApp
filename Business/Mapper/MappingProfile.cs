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

            CreateMap<FarmerDTO, Farmer>();
            CreateMap<Farmer, FarmerDTO>();


        }
    }
}
