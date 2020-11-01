using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public interface IPeopleRepository
    {
        Task CreatePerson(Person person);
        Task DeletePerson(int Id);
        Task<Person> GetPerson(int Id);
        Task<List<Person>> GetPerson();
        Task<List<Person>> GetPersonByName(string name);
        Task UpdatePerson(Person person);
    }
}
