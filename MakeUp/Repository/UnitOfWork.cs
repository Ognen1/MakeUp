﻿using MakeUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Repository
{
    public class UnitOfWork
    {
        private readonly GradeSystemContext _context;
        private StudentRepository _studentRepository;
        private CourseRepository _courseRepository;

        public UnitOfWork(GradeSystemContext context)
        {
            this._context = context;
        }

        public IStudentRepository Students => _studentRepository = _studentRepository ?? new StudentRepository(_context);

        public ICourseRepository Courses => _courseRepository = _courseRepository ?? new CourseRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
