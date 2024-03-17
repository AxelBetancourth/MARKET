using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Core
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entidad);
    }
}
