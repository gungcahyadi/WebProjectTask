using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace WebProjectTask.SharedKernel.Interfaces
{
    public interface RepositoryInterface<T> : IReadRepositoryBase<T> where T : class
    {
        
    }
}