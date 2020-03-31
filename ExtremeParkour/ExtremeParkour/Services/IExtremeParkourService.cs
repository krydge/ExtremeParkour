using ExtremeParkour.Data;
using ExtremeParkour.Shared;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeParkour.Services
{
   

    public interface IExtremeParkourService
    {
        [Get("/extremeparkourtutorial/")]
        Task<IEnumerable<VideoTutorialData>> GetTutorialsAsync();

        [Post("/extremeparkourtutorial/")]
        int AddTutorial(VideoTutorialData newTutorail);

        [Get("/extremeparkourworkout/")]
        Task<IEnumerable<VideoTutorialData>> GetWorkoutsAsync();

        [Post("/extremeparkourworkout/")]
        int AddWorkout(VideoTutorialData newTutorail);
    }

}
