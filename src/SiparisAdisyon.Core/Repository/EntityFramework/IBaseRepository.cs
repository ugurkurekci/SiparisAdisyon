using SiparisAdisyon.Core.Entity;
using System.Linq.Expressions;

namespace SiparisAdisyon.Core.Repository.EntityFramework;

public interface IBaseRepository<TEntity> where TEntity : class, IEntity, new()
{

    Task<int> AddAsync<T>(T entity) where T : class;

    Task<int> UpdateAsync<T>(T entity) where T : class;

    Task<int> DeleteAsync<T>(T entity) where T : class;

    Task<T> FindByIdAsync<T>(int id) where T : class;

    Task<T> FindByKeyValueAsync<T>(string column, string value) where T : class;

    Task<List<T>> GetAllAsync<T>() where T : class;

    Task<List<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class;

}