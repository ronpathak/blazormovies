using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorMovies.Server;
using BlazorMovies.Shared.Entities;
using BlazorMovies.Server.Helpers;
using AutoMapper;

namespace BlazorMovies.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public PeopleController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            _context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        // GET: api/People
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }

        // GET: api/People/PageNumber/RecordsPerPage
        [HttpGet("pages/{pagenumber}/{recordsperpage}")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeopleByPage(int pagenumber, int recordsperpage)
        {
            return await _context.People.Skip((pagenumber-1)*recordsperpage).Take(recordsperpage).ToListAsync();
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            var person = await _context.People.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }


        // GET: api/People/filter 
        // this method is used to filter the names in the multiple selector typeahead
        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<Person>>> FilterByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) { return new List<Person>(); }
            return await _context.People.Where(x => x.Name.Contains(searchText))
                .Take(5)
                .ToListAsync();
        }

        [HttpGet("count")]
        public int CountPeople()
        {
            int NumberOfRecords = _context.People.Count();
            return NumberOfRecords;
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, Person person)
        {

            var personDB = await _context.People.FindAsync(id);
            if (personDB == null)
            {
                return NotFound();
            }

            personDB = mapper.Map(person, personDB);

            if (!string.IsNullOrWhiteSpace(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                personDB.Picture = await fileStorageService.EditFile(personPicture,
                    "jpg", "people", personDB.Picture);
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/People
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(Person person)
        {

            if (!string.IsNullOrWhiteSpace(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                person.Picture = await fileStorageService.SaveFile(personPicture, "jpg", "people");
            }

            _context.People.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> DeletePerson(int id)
        {
            var person = await _context.People.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.People.Remove(person);
            await _context.SaveChangesAsync();

            return person;
        }

        private bool PersonExists(int id)
        {
            return _context.People.Any(e => e.Id == id);
        }
    }
}
