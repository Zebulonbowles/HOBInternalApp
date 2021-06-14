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
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public PersonRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<PersonDTO> CreatePerson(PersonDTO personDTO)
        {
            Person person = _mapper.Map<PersonDTO, Person>(personDTO);

            var addedPerson = await _db.People.AddAsync(person);
            await _db.SaveChangesAsync();
            return _mapper.Map<Person, PersonDTO>(addedPerson.Entity);
        }

        public async Task<PersonDTO> GetPerson(int personId)
        {
            try
            {
                PersonDTO person = _mapper.Map<Person, PersonDTO>(
                await _db.People.FirstOrDefaultAsync(x => x.Id == personId));
                return person;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<PersonDTO>> GetAllPeople()
        {
            try
            {
                IEnumerable<PersonDTO> personDTOs =
                    _mapper.Map<IEnumerable<Person>, IEnumerable<PersonDTO>>(_db.People);

                return personDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<PersonDTO> UpdatePerson(int personId, PersonDTO personDTO)
        {
            try
            {
                if (personId == personDTO.Id)
                {
                    var personDetails = await _db.People.FindAsync(personId);
                    var person = _mapper.Map<PersonDTO, Person>(personDTO, personDetails);
                    var updatedPerson = _db.People.Update(person);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Person, PersonDTO>(updatedPerson.Entity);
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
        public async Task<int> DeletePerson(int personId)
        {
            var person = await _db.People.FindAsync(personId);
            if (person != null)
            {
                _db.People.Remove(person);
                return await _db.SaveChangesAsync();

            }
            return 0;
        }
    }
}