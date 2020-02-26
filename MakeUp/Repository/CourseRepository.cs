using MakeUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MakeUp.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    { 
        private readonly GradeSystemContext _context;
        public CourseRepository(GradeSystemContext context)
          : base(context)
        { }

        public async Task<Course> GetCourseById(int id)
        {
            return await _context.Course.SingleOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await _context.Course.ToListAsync();
        }
    }
}
