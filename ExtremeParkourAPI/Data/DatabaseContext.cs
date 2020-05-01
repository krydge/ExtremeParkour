using ExtremeParkour.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeParkourAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<VideoTutorialData> VideoMetaData { get; private set; }
        public DbSet<WorkoutData> WorkoutMetaData { get; private set; }
    }
}
