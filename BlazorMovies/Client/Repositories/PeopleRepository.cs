﻿using BlazorMovies.Client.Helpers;
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
        private string url = "api/people";

        public PeopleRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }


        public async Task<List<Person>> GetPerson()
        {
            var response = await httpService.Get<List<Person>>(url);
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


        public async Task UpdatePerson(Person person)
        {
            var response = await httpService.Put(url, person);
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
