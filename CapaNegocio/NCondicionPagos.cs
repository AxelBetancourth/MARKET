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
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var condiciones = TodasLasCondiciones().Select(c => new
            {
                c.Codigo,
                c.CodigoPagoId,
            }).ToList();
            foreach (var item in condiciones)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.CodigoPagoId,
                    Descripcion = item.Codigo
                });
            }

            return Datos;
        }
        public int AgregarCondiciones(MCondicionPagos condiciones)
        {
            condiciones.FechaCreacion = DateTime.Now;
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

