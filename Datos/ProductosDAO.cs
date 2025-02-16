using MenuPrincipalTPI.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Datos
{
    public class ProductosDAO
    {
        private readonly AccesoDatos _accesoDatos;


        AccesoDatos objetoBaseDatos = new AccesoDatos();
        public ProductosDAO(AccesoDatos accesoDatos)
        {

            _accesoDatos = accesoDatos;
        }
        public bool AgregarProducto(Productos producto)
        {
            // Lógica para insertar el producto en la base de datos
            string consultaSQLProducto = "INSERT INTO Productos (nombre, descripcion, id_marca, id_rubro, precio, id_genero, id_talla, id_tipo_prenda) " +
                                         "VALUES (@nombre, @descripcion, @id_marca, @id_rubro, @precio, @id_genero, @id_talla, @id_tipo_prenda);";


            List<ParametrosProductos> parametros = new List<ParametrosProductos>
            {

                new ParametrosProductos("@nombre", producto.NombreProducto),
                new ParametrosProductos("@descripcion", producto.Descripcion),
                new ParametrosProductos("@id_marca", producto.Marca),
                new ParametrosProductos("@id_rubro", producto.Rubro),
                new ParametrosProductos("@precio", producto.Precio),
                new ParametrosProductos("@id_genero", producto.Genero),
                new ParametrosProductos("@id_talla", producto.Talla),
                new ParametrosProductos("@id_tipo_prenda", producto.TipoPrenda)
            };
            return _accesoDatos.ActualizarBDProductos(consultaSQLProducto, parametros) > 0;
        }
    }
}
