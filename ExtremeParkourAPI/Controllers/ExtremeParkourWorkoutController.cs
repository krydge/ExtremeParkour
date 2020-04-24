using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExtremeParkour.Shared;
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
            newWorkout.Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png");
            Workouts.Append(newWorkout);
        }
    }
}