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
        [Get("/weatherforecast")]
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();

        [Get("/extremeparkourtutorial/")]
        Task<IEnumerable<VideoTutorialData>> GetTutorialsAsync();

        [Post("/extremeparkourtutorial/")]
        Task<int> AddTutorial(VideoTutorialData newTutorial);

        [Get("/extremeparkourworkout/")]
        Task<IEnumerable<WorkoutData>> GetWorkoutsAsync();

        [Post("/extremeparkourworkout/")]
        Task<int> AddWorkout(WorkoutData newTutorail);
    }

}
