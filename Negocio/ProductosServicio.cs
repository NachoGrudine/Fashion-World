using MenuPrincipalTPI.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Datos
{
    public class ProductosServicio
    {
        //ATRIBUTOS
        private readonly ProductosDAO _productoDAO;

        //CONSTRUCTOR
        public ProductosServicio(ProductosDAO productoDAO)
        {
            _productoDAO = productoDAO;
        }

        //METODOS
        public bool AgregarProducto(Productos producto)
        {
            return _productoDAO.AgregarProducto(producto);
        }
    }
}
