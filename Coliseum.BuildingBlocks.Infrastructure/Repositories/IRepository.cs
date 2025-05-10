namespace Coliseum.BuildingBlocks.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByAsync(int id);
        
        Task<IEnumerable<T>> GetAllAsync();

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);
    }
}
