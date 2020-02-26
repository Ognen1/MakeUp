using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeUp.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Student { get; }

        ICourseRepository Course { get; }

        Task<int> CommitAsync();
    }
}
