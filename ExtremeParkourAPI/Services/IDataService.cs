using ExtremeParkour.Shared;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace ExtremeParkourAPI.Services
{
    public interface IDataService
    {
        void AddWorkout(WorkoutData workout);
        void AddTutorial(VideoTutorialData tutorial);
        IEnumerable<WorkoutData> GetWorkouts();
        IEnumerable<VideoTutorialData> GetTutorials();
    }
}
