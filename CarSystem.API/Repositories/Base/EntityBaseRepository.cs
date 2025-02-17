﻿using CarSystem.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace CarSystem.API.Repositories.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public EntityBaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
            string? includeProperties = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if(includeProperties != null)
            {
                foreach(string property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }

            if(predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null,
            string? includeProperties = null, bool tracked = true)
        {
            IQueryable<T> query = _context.Set<T>();

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            if(predicate != null)
            {
                query = query.Where(predicate);
            }

            if(includeProperties != null)
            {
                foreach(string property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> CreateAsync(T entity)
        {
            EntityEntry entry = await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();

            return (entry != null);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            EntityEntry entry = _context.Set<T>().Update(entity);

            await _context.SaveChangesAsync();

            return (entry != null);
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            EntityEntry entry = _context.Set<T>().Remove(entity);

            await _context.SaveChangesAsync();

            return (entry != null);
        }

        public async Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if(predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query.FirstOrDefaultAsync() != null;
        }
    }
}
