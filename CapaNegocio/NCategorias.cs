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
    public class NCategorias
    {
        private DCategorias dCategorias;

        public NCategorias()
        {
            dCategorias = new DCategorias();
        }

        public List<MCategorias> TodasLasCategorias()
        {
            return dCategorias.categoriaTodas();
        }
        public List<MCategorias> CategoriasActivas()
        {
            return dCategorias.categoriaTodas().Where(c => c.Estado == true).ToList();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var categorias = CategoriasActivas().Select(c => new
            {
                c.Descripción,
                c.CategoriaId,
            }).ToList();
            foreach (var item in categorias)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.CategoriaId,
                    Descripcion = item.Descripción
                });
            }

            return Datos;
        }
        public int AgregarCategoria(MCategorias categorias)
        {
            return dCategorias.GuardarCategoria(categorias);
        }
        public int EditarCategoria(MCategorias categorias)
        {
            return dCategorias.GuardarCategoria(categorias);
        }
        public int EliminarCategoria(int categoriaId)
        {
            return dCategorias.EliminarCategoria(categoriaId);
        }
    }
}
