using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;
using TripTracker.BackService.Data;
using Microsoft.EntityFrameworkCore;
using TripTrackerDTO;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        TripContext  _context;
        public TripsController(TripContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        private Models.Repository _repository;
 
        // GET api/Trips
        [HttpGet]
        //public IEnumerable<Models.Trip> Get()
        //{
        //    //Queryable _context.Trips
        //    // ToList made possible execution
        //    return _context.Trips.ToList();
        //}
        public async Task<IActionResult> GetAsync()
        {

            var trips = await _context.Trips
                .AsNoTracking()
                .Include(t=>t.Segments)
                .Select(
                t=> new TripWithSegments
                {
                    Id=t.Id,
                    Name = t.Name,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    Segments = t.Segments.ToList<TripTrackerDTO.Segment>()
                })
                .ToListAsync();
            return Ok(trips); 
        }

        // GET api/Trip/5
        [HttpGet("{id}")]
        public TripWithSegments Get(int id)
        {
            return _context.Trips
            
                .Select(
                t => new TripWithSegments
                {
                    Id = t.Id,
                    Name = t.Name,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    Segments = t.Segments.ToList<TripTrackerDTO.Segment>()
                }).SingleOrDefault(t => t.Id == id);
        }

        // POST api/Trips
        [HttpPost]
        public IActionResult Post([FromBody]Models.Trip value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Trips.Add(value);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/Trip/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody]Models.Trip value)
        {
            //var  tripFromDb = _context.Trips.Find(id);
            //tripFromDb.Name = value.Name;
            //tripFromDb.StartDate = value.StartDate;
            if (_context.Trips.Any(t=>t.Id==id) )
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Trips.Update(value);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
            
        {
            var myTrip = _context.Trips.Find(id);
            if (myTrip==null)
            {
                return NotFound();
            }
            _context.Trips.Remove(myTrip);
            _context.SaveChanges();
            
            return NoContent();
        }
    }
}

