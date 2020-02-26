using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetCourses();
        Task<Course> GetCourseById(int id);

    }
}
