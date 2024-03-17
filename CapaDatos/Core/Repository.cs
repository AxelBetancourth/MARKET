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
            throw new NotImplementedException();
        }
    }
}
