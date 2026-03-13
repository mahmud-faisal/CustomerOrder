using CustomerOrder.Models.EntityModels;

namespace CustomerOrder.Services.Abstractions
{
    public interface IService<T> where T : class, IEntity
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        ICollection<T> GetAll();
        T Get(int id);
    }
}
