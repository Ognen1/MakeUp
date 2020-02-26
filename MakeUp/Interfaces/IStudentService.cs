using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Interfaces
{
    public interface IStudentService
    {
        Task<Student> NewStudent(Student newStudent);
        Task UpdateStudent(Student studentUpdate, Student student);
        Task DeleteStudent(Student student);
    }
}
