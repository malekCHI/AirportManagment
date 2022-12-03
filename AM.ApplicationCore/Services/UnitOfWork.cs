using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly Type repositoryType;
        private bool disposedValue;

        public UnitOfWork(DbContext context, Type type)
        {
            _context = context;
            repositoryType = type;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IGenericRepository<T> Repository<T>() where T : class
        {
            return (IGenericRepository<T>)Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
        }

        public int Save()
        {
            // Save changes with the default options
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();

                    disposedValue = true;
                }
            }


            //public void Dispose()
            //{
            //    // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
            //    Dispose(disposing: true);
            //    GC.SuppressFinalize(this);
            //}
        }
    }
}
