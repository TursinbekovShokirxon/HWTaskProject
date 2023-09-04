using Domain.Models;

namespace Infrastructure.Interface
{
    public interface InterfaceBaseDb<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<bool> Create(T obj);
        public Task<bool> Delete(int id);
        public Task<bool> Update(T id);
    }
}