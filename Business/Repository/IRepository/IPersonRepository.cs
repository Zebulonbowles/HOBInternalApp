using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository 
{ 
    public interface IPersonRepository
    {
        public Task<PersonDTO> CreatePerson(PersonDTO personDTO);
        public Task<PersonDTO> UpdatePerson(int personId, PersonDTO personDTO);
        public Task<PersonDTO> GetPerson(int personId);
        public Task<IEnumerable<PersonDTO>> GetAllPeople();
        public Task<int> DeletePerson(int personId);
    }
}