using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajoparte3
{
    internal class ServicioVerProductos
    {

        VerProductosDAO oDao;
        public ServicioVerProductos(string cadena)
        {
            oDao = new VerProductosDAO(cadena);
        }
        public void Editar(Producto prod)
        {
            oDao.EditarProd(prod);
        }

        public List<Producto> ListaProductos(Filtro filtro)
        {
            return oDao.RecuperarProductos(filtro);
        }

        public List<Producto> ListaProductosOrdenados(Filtro filtro, string cadena)
        {
            return oDao.RecuperarProductosOrdenados(filtro, cadena);
        }

        public string RecuperarDetalle(string id)
        {
            return oDao.RecuperarDetalle(id);
        }
        public bool EliminarProducto(string id)
        {
            return oDao.Eliminar(id);
        }

        public List<Producto> CargarConsulta(int NroConsulta)
        {
            return oDao.CargarConsulta(NroConsulta);
        }

        public Producto BuscarProd(string id)
        {
            return oDao.RecuperarPr(id);
        }
    }
}
