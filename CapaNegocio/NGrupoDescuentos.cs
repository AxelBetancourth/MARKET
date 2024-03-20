using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NGrupoDescuentos
    {
        private DGrupoDescuentos dGrupoDescuentos;

        public NGrupoDescuentos()
        {
            dGrupoDescuentos = new DGrupoDescuentos();
        }
        public List<MGrupoDescuentos> TodasLosDescuentos()
        {
            return dGrupoDescuentos.GDescuentosTodas();
        }
        public List<MGrupoDescuentos> DescuentosActivos()
        {
            return dGrupoDescuentos.GDescuentosTodas().Where(c => c.Estado == true).ToList();
        }
        public int AgregarDescuentos(MGrupoDescuentos descuentos)
        {
            return dGrupoDescuentos.GuardarDescuentos(descuentos);
        }
        public int EditarDescuentos(MGrupoDescuentos descuentos)
        {
            return dGrupoDescuentos.GuardarDescuentos(descuentos);
        }
        public int EliminarDescuentos(int grupoDescuentosId)
        {
            return dGrupoDescuentos.EliminarDescuentos(grupoDescuentosId);
        }
    }
}
