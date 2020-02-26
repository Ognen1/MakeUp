using MakeUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public async Task<Student> NewStudent(Student newStudent)
        {
            await _unitOfWork.Student
                .AddAsync(newStudent);

            return newStudent;
        }

        public async Task UpdateStudent(Student studentUpdate, Student student)
        {
            studentUpdate.StudentName = student.StudentName;

            await _unitOfWork.CommitAsync();
        }
        public async Task DeleteStudent(Student student)
        {
            _unitOfWork.Student.Remove(student);

            await _unitOfWork.CommitAsync();
        }
    }
}
