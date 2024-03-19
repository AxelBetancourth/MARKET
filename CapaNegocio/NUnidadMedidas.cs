using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NUnidadMedidas
    {
        private DUnidadMedidas unidadMedidas;

        public NUnidadMedidas()
        {
            unidadMedidas = new DUnidadMedidas();
        }
        public List<MUnidadMedidas> TodasLasUnidades()
        {
            return unidadMedidas.UnidadesTodas();
        }
        public List<MUnidadMedidas> UnidadesActivas()
        {
            return unidadMedidas.UnidadesTodas().Where(c => c.Estado == true).ToList();
        }
        public int AgregarUnidades(MUnidadMedidas unidades)
        {
            return unidadMedidas.GuardarUnidades(unidades);
        }
        public int EditarUnidades(MUnidadMedidas unidades)
        {
            return unidadMedidas.GuardarUnidades(unidades);
        }
        public int EliminarUnidades(int unidadMedidaId)
        {
            return unidadMedidas.EliminarUnidades(unidadMedidaId);
        }
    }
}
