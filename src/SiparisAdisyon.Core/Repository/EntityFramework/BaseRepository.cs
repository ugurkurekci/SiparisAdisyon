using Microsoft.EntityFrameworkCore;
using SiparisAdisyon.Core.Entity;
using System.Linq.Expressions;

namespace SiparisAdisyon.Core.Repository.EntityFramework;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity, new()
{

    protected readonly DbContext _context;

    public BaseRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<int> AddAsync<T>(T entity) where T : class
    {
        _context.Set<T>().Add(entity);
        return await _context.SaveChangesAsync();
    }

    public Task<int> UpdateAsync<T>(T entity) where T : class
    {
        var entry = _context.Entry(entity);
        entry.State = EntityState.Modified;
        return _context.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync<T>(T entity) where T : class
    {
        var entry = _context.Entry(entity);
        entry.State = EntityState.Deleted;
        return await _context.SaveChangesAsync();
    }

    public async Task<T> FindByIdAsync<T>(int id) where T : class
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<T> FindByKeyValueAsync<T>(string column, string value) where T : class
    {
        ParameterExpression parameter = Expression.Parameter(typeof(T), "x");
        MemberExpression property = Expression.Property(parameter, column);
        ConstantExpression constant = Expression.Constant(value);
        BinaryExpression equal = Expression.Equal(property, constant);
        var lambda = Expression.Lambda<Func<T, bool>>(equal, parameter);
        return await _context.Set<T>().FirstOrDefaultAsync(lambda);

    }

    public async Task<List<T>> GetAllAsync<T>() where T : class
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<List<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class
    {
        return await _context.Set<T>().Where(predicate).ToListAsync();
    }

}