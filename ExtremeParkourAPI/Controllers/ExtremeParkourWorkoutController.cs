using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExtremeParkour.Shared;
using ExtremeParkourAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xamarin.Forms;

namespace ExtremeParkourAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExtremeParkourWorkoutController : ControllerBase
    {
        public List<WorkoutData> Workouts;

        private readonly ILogger<ExtremeParkourWorkoutController> _logger;
        private readonly IDataService dataService;

        public ExtremeParkourWorkoutController(ILogger<ExtremeParkourWorkoutController> logger, IDataService dataService)
        {
            _logger = logger;
            this.dataService = dataService;
            Workouts = (List<WorkoutData>)dataService.GetWorkouts();
        }

        [HttpGet]
        public IEnumerable<WorkoutData> Get()
        {
            return dataService.GetWorkouts();
        }

        [HttpPost]
        public int Post(WorkoutData newWorkout)
        {
            dataService.AddWorkout(newWorkout);
            Workouts = (List<WorkoutData>)dataService.GetWorkouts();
            return Workouts.Count;
        }
    }
}