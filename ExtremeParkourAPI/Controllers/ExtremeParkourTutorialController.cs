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
    public class ExtremeParkourTutorialController : ControllerBase
    {
        public IEnumerable<VideoTutorialData> Tutorials;

        private readonly ILogger<ExtremeParkourTutorialController> _logger;

        public ExtremeParkourTutorialController(ILogger<ExtremeParkourTutorialController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<VideoTutorialData> Get()
        {
            return Tutorials;
        }

        [HttpPost]
        public void Post(VideoTutorialData newTutorial)
        {
            newTutorial.Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png");
            Tutorials.Append(newTutorial);
        }
    }
}