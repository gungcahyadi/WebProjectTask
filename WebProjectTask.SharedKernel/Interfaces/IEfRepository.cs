using Ardalis.Specification;

namespace WebProjectTask.SharedKernel.Interfaces
{
    public interface IEfRepository<T> : IRepositoryBase<T> where T : class
    {
        
    }
}