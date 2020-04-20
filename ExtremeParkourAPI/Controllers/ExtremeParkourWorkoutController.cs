using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtremeParkour.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExtremeParkourAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExtremeParkourWorkoutController : ControllerBase
    {
        public IEnumerable<WorkoutData> Workouts;

        private readonly ILogger<ExtremeParkourWorkoutController> _logger;

        public ExtremeParkourWorkoutController(ILogger<ExtremeParkourWorkoutController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WorkoutData> Get()
        {
            return Workouts;
        }

        [HttpPost]
        public void Post(WorkoutData newWorkout)
        {
            Workouts.Append(newWorkout);
        }
    }
}