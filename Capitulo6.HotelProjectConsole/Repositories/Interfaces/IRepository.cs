namespace Capitulo6.HotelProjectConsole.Repositories.Interfaces
{
    public interface IRepository<T, TId> where T : class
    {
        public Task<T> GetById(TId id);
        public Task<IEnumerable<T>> Get();
        public Task Insert(T entity);
        public Task InsertRange(IEnumerable<T> entity);
        public Task Update(T entity);
        public Task UpdateRange(IEnumerable<T> entity);
        public Task Delete(TId id);
        public Task DeleteRange(IEnumerable<TId> id);
    }
}
