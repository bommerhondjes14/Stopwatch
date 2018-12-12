using Stopwatch.Core.Business;
using Stopwatch.Core.Data;

namespace Stopwatch.Core.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StopwatchContext _context;

        public UnitOfWork(StopwatchContext context)
        {
            _context = context;
            //Courses = new CourseRepository(_context);
        }

        //public ICourseRepository Courses { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}