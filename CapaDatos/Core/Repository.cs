using CapaDatos.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MarketContext dbcontext;

        public Repository()
        {
            dbcontext = new MarketContext();
        }
        public void Agregar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
            dbcontext.SaveChanges();
        }
        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }
        public void Editar(T entidad)
        {

            dbcontext.Set<T>();
            dbcontext.SaveChanges();
        }
        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
            dbcontext.SaveChanges();
        }
    }
}
