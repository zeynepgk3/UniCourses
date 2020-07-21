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

        public void Update(T entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
