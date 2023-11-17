using WebProjectTask.SharedKernel.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebProjectTask.Infrastructure.Data
{
    public class EfRepository<T> : RepositoryBase<T>, IEfRepository<T> where T : class
    {
        public EfRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

    }
}