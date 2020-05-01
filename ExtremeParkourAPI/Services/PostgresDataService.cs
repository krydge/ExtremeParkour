using ExtremeParkour.Shared;
using ExtremeParkourAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeParkourAPI.Services
{
    public class PostgresDataService : IDataService
    {
        private readonly DatabaseContext dbContext;

        public PostgresDataService(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddTutorial(VideoTutorialData tutorial)
        {
            dbContext.Add(tutorial);
            dbContext.SaveChanges();
        }

        public void AddWorkout(WorkoutData workout)
        {
            dbContext.Add(workout);
            dbContext.SaveChanges();
        }

        public IEnumerable<VideoTutorialData> GetTutorials()
        {
            return dbContext.VideoMetaData.ToList();
        }

        public IEnumerable<WorkoutData> GetWorkouts()
        {
            return dbContext.WorkoutMetaData.ToList();
        }
    }
}
