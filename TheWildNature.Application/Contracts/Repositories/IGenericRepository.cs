namespace TheWildNature.Application.Contracts.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<bool> Exist(int id);
        Task<T> AttachAsync(T entity);
    }
}
