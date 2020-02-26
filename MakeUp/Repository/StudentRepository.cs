using MakeUp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly GradeSystemContext _context;
        public StudentRepository(GradeSystemContext context)
          : base(context)
        { }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Student.SingleOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var ucenici = await _context.Student.ToListAsync();
            return ucenici;
        }
    }
}
