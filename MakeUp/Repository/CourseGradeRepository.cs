using MakeUp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Repository
{
    public class CourseGradeRepository : Repository<CourseGrade>, ICourseGradeRepository
    {
        private readonly GradeSystemContext _context;
        public CourseGradeRepository(GradeSystemContext context)
          : base(context)
        { }

        public async Task<IEnumerable<CourseGrade>> GetCourseGrade()
        {
            return await _context.CourseGrade.ToListAsync();
        }
    }
}
