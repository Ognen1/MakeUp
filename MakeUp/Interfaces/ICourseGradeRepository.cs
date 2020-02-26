using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Interfaces
{
    public interface ICourseGradeRepository : IRepository<CourseGrade>
    {
        public Task<IEnumerable<CourseGrade>> GetCourseGrade();
    }
}
