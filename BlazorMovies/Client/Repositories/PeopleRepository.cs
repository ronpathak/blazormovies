using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public class PeopleRepository: IPeopleRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/people";

        public PeopleRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }


        public async Task<List<Person>> GetPeople()
        {
            var response = await httpService.Get<List<Person>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<int> CountPeople()
        {
            Console.WriteLine("Executing people repo CountPeople");
            var response = await httpService.Get<int>($"{url}/count");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Person>> GetPeopleByPage(int pagenumber, int recordsperpage)
        {
            var response = await httpService.Get<List<Person>>($"{url}/pages/{pagenumber}/{recordsperpage}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Person> GetPerson(int Id)
        {
            var response = await httpService.Get<Person>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task<List<Person>> GetPersonByName(string name)
        {
            var response = await httpService.Get<List<Person>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreatePerson(Person person)
        {
            var response = await httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }


        public async Task UpdatePerson(int Id, Person person)
        {
            var response = await httpService.Put($"{url}/{Id}", person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }


        public async Task DeletePerson(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
