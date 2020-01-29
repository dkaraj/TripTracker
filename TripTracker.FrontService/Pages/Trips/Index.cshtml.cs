using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TripTracker.BackService.Models;
using TripTracker.FrontService.Data;
using TripTracker.FrontService.Services;

namespace TripTracker.FrontService.Pages.Trips
{
    public class IndexModel : PageModel
    {
        //private readonly TripTracker.FrontService.Data.ApplicationDbContext _context;
        private readonly IApiClient _Client;

        public IndexModel(IApiClient client)
        {
            _Client = client;
        }

        public IList<Trip> Trips { get;set; }

        public async Task OnGetAsync()
        {
            Trips = await _Client.GetTripsAsync();
        }
    }
}
