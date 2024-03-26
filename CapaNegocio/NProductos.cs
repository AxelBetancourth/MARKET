using CapaDatos.BaseDatos.Modelos;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.Comun;

namespace CapaNegocio
{
    public class NProductos
    {

        private DProductos dproductos;

        public NProductos()
        {
            dproductos = new DProductos();
        }

        public List<MProductos> TodosProductos()
        {
            return dproductos.TodosLosProductos();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var Productos = TodosProductos().Select(c => new
            {
                c.ProductoId,
                c.Categoriaid,
            }).ToList();
            foreach (var item in Productos)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.ProductoId,
                    Descripcion = item.Categoriaid.ToString()
                });
            }

            return Datos;
        }
        public int AgregarProducto(MProductos Productos)
        {
            return dproductos.Guardar(Productos);
        }
        public int EditarProducto(MProductos Productos)
        {
            
            return dproductos.Guardar(Productos);
        }

        public int Eliminar(int ProductoId)
        {
            return dproductos.Eliminar(ProductoId);
        }
        public List<object> obtenerProductosGrid()
        {
            var productos = dproductos.TodosLosProductos().Select(c => new {
                c.ProductoId,
                CategoriaDescripcion = c.MCategotias.Descripción,
                UnidadMedidaDescripcion = c.MUnidadMedidas.Descripción, 
                c.Estado,
                c.PrecioCompra,
                c.FechaCreacion
            });
            return productos.Cast<object>().ToList();
        }

        public List<object> obtenerProductosActivosGrid()
        {
            var productos = dproductos.TodosLosProductos().Select(c => new {
                c.ProductoId,
                CategoriaDescripcion = c.MCategotias.Descripción,
                UnidadMedidaDescripcion = c.MUnidadMedidas.Descripción,
                c.Estado,
                c.PrecioCompra,
                c.FechaCreacion
            });
            return productos.Where(c => c.Estado == true).Cast<object>().ToList();
        }
    }
}
