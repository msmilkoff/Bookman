﻿namespace Bookman.Data
{
    using System.Linq;

    public interface IRepository<T>
        where T : class
    {
        IQueryable<T> All();

        T GetById(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(string id);

        void Detach(T entity);
    }
}
