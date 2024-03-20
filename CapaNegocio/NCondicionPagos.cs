using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCondicionPagos
    {
        private DCondicionPagos dCondicionPagos;

        public NCondicionPagos()
        {
            dCondicionPagos = new DCondicionPagos();
        }

        public List<MCondicionPagos> TodasLasCondiciones()
        {
            return dCondicionPagos.CondicionesTodas();
        }
        public List<MCondicionPagos> CondicionesActivas()
        {
            return dCondicionPagos.CondicionesTodas().Where(c => c.Estado == true).ToList();
        }
        public int AgregarCondiciones(MCondicionPagos condiciones)
        {
            return dCondicionPagos.GuardarUnidades(condiciones);
        }
        public int EditarCondiciones(MCondicionPagos condiciones)
        {
            return dCondicionPagos.GuardarUnidades(condiciones);
        }
        public int EliminarCondiciones(int codigoPagoId)
        {
            return dCondicionPagos.EliminarCondiciones(codigoPagoId);
        }
    }

}

