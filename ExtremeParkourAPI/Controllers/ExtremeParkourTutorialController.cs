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
    public class ExtremeParkourTutorialController : ControllerBase
    {
        public List<VideoTutorialData> Tutorials;

        private readonly ILogger<ExtremeParkourTutorialController> _logger;
        private readonly IDataService dataService;

        public ExtremeParkourTutorialController(ILogger<ExtremeParkourTutorialController> logger, IDataService dataService)
        {
            _logger = logger;
            this.dataService = dataService;
            Tutorials = (List<VideoTutorialData>)dataService.GetTutorials();
        }

        [HttpGet]
        public IEnumerable<VideoTutorialData> Get()
        {
            return dataService.GetTutorials();
        }

        [HttpPost]
        public int Post(VideoTutorialData newTutorial)
        {
            dataService.AddTutorial(newTutorial);
            Tutorials = (List<VideoTutorialData>)dataService.GetTutorials();
            return Tutorials.Count;
        }
    }
}