using Domain.Interface.IRepositories;
using Domain.Interface.IUnitOfWork;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;

namespace MDH.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MHDbContext _context;
        private Dictionary<Type, object> _repositories;
        public UnitOfWork(MHDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Rollback changes if needed
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new Repository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
