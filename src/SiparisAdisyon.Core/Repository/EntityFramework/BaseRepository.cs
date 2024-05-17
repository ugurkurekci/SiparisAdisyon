using Microsoft.EntityFrameworkCore;
using OneOf;
using SiparisAdisyon.Core.Entity;
using SiparisAdisyon.Core.Results;
using System.Linq.Expressions;

namespace SiparisAdisyon.Core.Repository.EntityFramework;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity, new()
{

    protected readonly DbContext _context;

    public BaseRepository(DbContext context)
    {
        _context = context;
    }
    public async Task<OneOf<Result, Error>> AddAsync<T>(T entity) where T : class
    {

        try
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return new Result { Message = "Added successfully", Code = "SUCCESS_DB_ADD", Success = true };

        }
        catch (Exception ex)
        {
            return new Error { Message = $"Error: {ex.InnerException.Message}", Code = "ERROR_DB_ADD", Success = false };
        }

    }

    public async Task<OneOf<Result, Error>> DeleteAsync<T>(T entity) where T : class
    {
        try
        {

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return new Result { Message = "Deleted successfully", Code = "SUCCESS_DB_DELETE", Success = true };


        }
        catch (Exception ex)
        {
            return new Error { Message = $"Error: {ex.InnerException.Message}", Code = "ERROR_DB_DELETE", Success = false };

        }
    }

    public async Task<OneOf<T, Error>> FindByIdAsync<T>(int id) where T : class
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null)
        {
            return new Error { Message = "Entity not found", Code = "ERROR_DB_FIND", Success = false };
        }
        return entity;

    }

    public async Task<OneOf<T, Error>> FindByKeyValueAsync<T>(string column, string value) where T : class
    {

        var entity = await _context.Set<T>().FirstOrDefaultAsync(e => EF.Property<string>(e, column) == value);
        if (entity == null)
        {
            return new Error { Message = "Entity not found", Code = "ERROR_DB_FIND", Success = false };
        }

        return entity;

    }

    public async Task<OneOf<List<T>, Error>> GetAllAsync<T>() where T : class
    {
        var entities = await _context.Set<T>().ToListAsync();
        if (entities == null)
        {
            return new Error { Message = "Entities not found", Code = "ERROR_DB_FIND", Success = false };
        }

        return entities;
    }

    public async Task<OneOf<List<T>, Error>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class
    {
        var entities = await _context.Set<T>().Where(predicate).ToListAsync();
        if (entities == null)
        {
            return new Error { Message = "Entities not found", Code = "ERROR_DB_FIND", Success = false };
        }

        return entities;

    }

    public async Task<OneOf<Result, Error>> UpdateAsync<T>(T entity) where T : class
    {
        try
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return new Result { Message = "Updated successfully", Code = "SUCCESS_DB_UPDATE", Success = true };
        }
        catch (Exception ex)
        {
            return new Error { Message = $"Error: {ex.InnerException.Message}", Code = "ERROR_DB_UPDATE", Success = false };
        }

    }
}