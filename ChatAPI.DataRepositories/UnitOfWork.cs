using ChatAPI.Core.Repository_Interfaces;
using ChatAPI.DataRepositories.Repository;
using DomainChat.Contexts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChatAPI.DataRepositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ChatDbContext chatDbContext;

        public UnitOfWork(ChatDbContext chatDbContext)
        {
            this.chatDbContext = chatDbContext;
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new RepositoryBase<TEntity>(this.chatDbContext);
        }

        public void SaveChanges()
        {
            //this.RunBeforeSave(this.dbContextScope);
            this.chatDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            //this.RunBeforeSave(this.dbContextScope);
            await this.chatDbContext.SaveChangesAsync(cancellationToken);
        }

        //protected virtual void RunBeforeSave(IDbContextScope currentDbContextScope)
        //{
        //}

        private bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.chatDbContext.Dispose();
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
