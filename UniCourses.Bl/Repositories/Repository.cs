using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using UniCourses.Dal.Contexts;

namespace UniCourses.Bl.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly MyContext context;
        private DbSet<T> entities;

        public Repository(MyContext _context)
        {
            context = _context;
            entities = _context.Set<T>();
        }
        public T GetBy(Expression<Func<T, bool>> expression)
        {
            return entities.FirstOrDefault(expression);
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> expression, string includeProperties = null)
        {
            IQueryable<T> query = entities;
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[]
                         { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }
        public IEnumerable<T> GetAllLazy(string includeProperties = null)

        {
            IQueryable<T> query = entities;
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[]
                         { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.ToList();
        }

        public IEnumerable<T> GetAllLazy(Expression<Func<T, bool>> expression,
            string includeProperties = null)

        {
            IQueryable<T> query = entities.Where(expression);
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[]
                         { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.ToList();
        }
        public IQueryable<T> GetAll()
        {
            return entities;
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return entities.Where(expression);
        }
        public void Add(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        public void RemoveRange(IEnumerable<T> entity)
        {
            context.RemoveRange(entity);
        }
        public void Update(T entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public T Bul(int id)
        {
            return entities.Find(id);
        }
        
        public IQueryable<T> GetInclude(Expression<Func<T, bool>> expression)
        {
            return entities.Include(expression);
        }
        
        public IEnumerable<T> ListTo()
        {
            return entities.ToList();
        }

    }
}