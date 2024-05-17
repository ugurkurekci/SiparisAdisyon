using OneOf;
using SiparisAdisyon.Core.Entity;
using SiparisAdisyon.Core.Results;
using System.Linq.Expressions;

namespace SiparisAdisyon.Core.Repository.EntityFramework;

public interface IBaseRepository<TEntity> where TEntity : class, IEntity, new()
{

    Task<OneOf<Result, Error>> AddAsync<T>(T entity) where T : class;

    Task<OneOf<Result, Error>> UpdateAsync<T>(T entity) where T : class;

    Task<OneOf<Result, Error>> DeleteAsync<T>(T entity) where T : class;

    Task<OneOf<T, Error>> FindByIdAsync<T>(int id) where T : class;

    Task<OneOf<T, Error>> FindByKeyValueAsync<T>(string column, string value) where T : class;

    Task<OneOf<List<T>, Error>> GetAllAsync<T>() where T : class;

    Task<OneOf<List<T>, Error>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class;

}