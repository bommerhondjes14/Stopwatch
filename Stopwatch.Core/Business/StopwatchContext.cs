using System.Data.Entity;

namespace Stopwatch.Core.Business
{
    public class StopwatchContext : DbContext
    {
        public StopwatchContext()
            : base("name=StopwatchContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        //public virtual DbSet<Author> Authors { get; set; }
        //public virtual DbSet<Course> Courses { get; set; }
        //public virtual DbSet<Tag> Tags { get; set; }

        
    }
}
