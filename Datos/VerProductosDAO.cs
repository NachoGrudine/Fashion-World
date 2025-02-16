using MenuPrincipalTPI.Datos;
using MenuPrincipalTPI.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajoparte3
{
    internal class VerProductosDAO
    {
        AccesoDatos oBD;
        public VerProductosDAO(string cadena)
        {
            oBD = new AccesoDatos(cadena);
        }

        //Eliminar el producto
        public bool Eliminar(string id)
        {

            try
            {
                oBD.Comando("DELETE from materiales_productos where id_producto = " + id);
                oBD.Comando("DELETE from productos where id_producto = " + id);
                return true;
            }
            catch
            {
                MessageBox.Show("EL producto tiene dependencias a otros registros ", "Error de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oBD.Desconectar();
                return false;
            }

        }
        public List<Producto> RecuperarProductos()
        {

            List<Producto> Lista = new List<Producto>();
            DataTable tabla = oBD.Consulta("SELECT p.id_producto, p.nombre, m.marca, t.talla, p.precio, p.descripcion, g.genero, r.rubro, tip.tipo_prenda  FROM productos p"
                       + " JOIN marcas as m on p.id_marca = m.id_marca"
                       + " JOIN generos as g on p.id_genero = g.id_genero "
                       + " JOIN tallas as t on t.id_talla = p.id_talla"
                       + " JOIN rubros as r on r.id_rubro = p.id_rubro");
            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = new Producto();
                oProducto.Id = (int)fila[0];
                oProducto.Nombre = fila[1].ToString();
                oProducto.Marca = fila[2].ToString();
                oProducto.Talla = fila[3].ToString();
                oProducto.Precio = Convert.ToDouble(fila[4]);
                oProducto.Descripcion = fila[5].ToString();
                oProducto.Genero = fila[6].ToString();
                oProducto.Rubro = fila[7].ToString();
                oProducto.TipoPrenda = fila[8].ToString();

                Lista.Add(oProducto);
            }

            return Lista;

        }



        

        public Producto RecuperarPr(string id)
        {
            
            Producto oProducto = new Producto();

            string consultaSql = "SELECT p.id_producto, p.nombre, m.id_marca, t.id_talla, p.precio, p.descripcion, g.id_genero, r.id_rubro, tip.id_tipo_prenda  FROM productos p"
                   + " JOIN marcas as m on p.id_marca = m.id_marca"
                   + " JOIN generos as g on p.id_genero = g.id_genero "
                   + " JOIN tallas as t on t.id_talla = p.id_talla"
                   + " JOIN rubros as r on r.id_rubro = p.id_rubro"
                   + " JOIN tipos_prenda as tip on tip.id_tipo_prenda = p.id_tipo_prenda"
                   + " WHERE p.id_producto = " + id;

            DataTable table = oBD.Consulta(consultaSql);
            foreach (DataRow fila in table.Rows)
            {

                oProducto.Id = (int)fila[0];
                oProducto.Nombre = fila[1].ToString();
                oProducto.IdMarca = (int)fila[2];
                oProducto.IdTalla = (int)fila[3];
                oProducto.Precio = Convert.ToDouble(fila[4]);
                oProducto.Descripcion = fila[5].ToString();
                oProducto.IdGenero = (int)fila[6];
                oProducto.Idrubro = (int)fila[7];
                oProducto.IdTipoPrenda = (int)fila[8];
            }
            return oProducto;
        }


        public List<Producto> RecuperarProductosOrdenados(Filtro filtro, string cadena)
        {
            string consultaSql = ("SELECT p.id_producto, p.nombre, m.marca, t.talla, p.precio, p.descripcion, g.genero, r.rubro, tip.tipo_prenda  FROM productos p"
                       + " JOIN marcas as m on p.id_marca = m.id_marca"
                       + " JOIN generos as g on p.id_genero = g.id_genero "
                       + " JOIN tallas as t on t.id_talla = p.id_talla"
                       + " JOIN rubros as r on r.id_rubro = p.id_rubro"
                       + " JOIN tipos_prenda as tip on tip.id_tipo_prenda = p.id_tipo_prenda");
            string tallas_consulta = string.Empty;
            if (filtro.Nomb != string.Empty)
            {
                consultaSql = consultaSql + " AND p.nombre LIKE '%" + filtro.Nomb + "%'";
            }
            if (filtro.Desc != string.Empty)
            {
                consultaSql = consultaSql + " AND p.descripcion LIKE '%" + filtro.Desc + "%'";
            }
            if (filtro.IndMarca != -1)
            {
                consultaSql = consultaSql + " AND m.id_marca = '" + (filtro.IndMarca + 1) + "'";
            }
            if (filtro.IndGenero != -1)
            {
                consultaSql = consultaSql + " AND g.id_genero = '" + (filtro.IndGenero + 1) + "'";
            }
            if (filtro.IndRubro != -1)
            {
                consultaSql = consultaSql + " AND r.id_rubro = '" + (filtro.IndRubro + 1) + "'";
            }
            if (filtro.IndTipo != -1)
            {
                consultaSql = consultaSql + " AND tip.id_tipo_prenda = '" + (filtro.IndTipo + 1) + "'";
            }
            if (filtro.Min != 0 || filtro.Max != 500000)
            {
                consultaSql = consultaSql + " AND p.precio between " + filtro.Min.ToString() + " and " + filtro.Max.ToString();
            }


            if (filtro.Xs || filtro.S || filtro.M || filtro.L || filtro.Xl || filtro.Xxl)
            {
                if (filtro.Xs) { tallas_consulta = tallas_consulta + ",'Xs'"; }
                if (filtro.S) { tallas_consulta = tallas_consulta + ",'S'"; }
                if (filtro.M) { tallas_consulta = tallas_consulta + ",'M'"; }
                if (filtro.L) { tallas_consulta = tallas_consulta + ",'L'"; }
                if (filtro.Xl) { tallas_consulta = tallas_consulta + ",'Xl'"; }
                if (filtro.Xxl) { tallas_consulta = tallas_consulta + ",'XXl'"; }

                tallas_consulta = tallas_consulta.Substring(1);

                consultaSql = consultaSql + " AND  t.talla in (" + tallas_consulta + ")";
            }
            consultaSql = consultaSql + cadena;
            List<Producto> Lista = new List<Producto>();
            DataTable tabla = oBD.Consulta(consultaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = new Producto();
                oProducto.Id = (int)fila[0];
                oProducto.Nombre = fila[1].ToString();
                oProducto.Marca = fila[2].ToString();
                oProducto.Talla = fila[3].ToString();
                oProducto.Precio = Convert.ToDouble(fila[4]);
                oProducto.Descripcion = fila[5].ToString();
                oProducto.Genero = fila[6].ToString();
                oProducto.Rubro = fila[7].ToString();
                oProducto.TipoPrenda = fila[8].ToString();

                Lista.Add(oProducto);
            }

            return Lista;
        }

        public string RecuperarDetalle(string id)
        {
            string producto = string.Empty;
            Producto oProducto = new Producto();

            string consultaSql = "SELECT p.id_producto, p.nombre, m.marca, t.talla, p.precio, p.descripcion, g.genero, r.rubro, tip.tipo_prenda  FROM productos p"
                   + " JOIN marcas as m on p.id_marca = m.id_marca"
                   + " JOIN generos as g on p.id_genero = g.id_genero "
                   + " JOIN tallas as t on t.id_talla = p.id_talla"
                   + " JOIN rubros as r on r.id_rubro = p.id_rubro"
                   + " JOIN tipos_prenda as tip on tip.id_tipo_prenda = p.id_tipo_prenda"
                   + " WHERE p.id_producto = " + id;

            DataTable table = oBD.Consulta(consultaSql);
            foreach (DataRow fila in table.Rows)
            {
                
                oProducto.Id = (int)fila[0];
                oProducto.Nombre = fila[1].ToString();
                oProducto.Marca = fila[2].ToString();
                oProducto.Talla = fila[3].ToString();
                oProducto.Precio = Convert.ToDouble(fila[4]);
                oProducto.Descripcion = fila[5].ToString();
                oProducto.Genero = fila[6].ToString();
                oProducto.Rubro = fila[7].ToString();
                oProducto.TipoPrenda = fila[8].ToString();

                producto = $@" NOMBRE: {oProducto.Nombre}

 DESCRIPCION: {oProducto.Descripcion} 

 MARCA: {oProducto.Marca}

 TALLA: {oProducto.Talla}

 GENERO: {oProducto.Genero}    

 RUBRO: {oProducto.Rubro}

 TIPO DE PRENDA: {oProducto.TipoPrenda}

 PRECIO: {oProducto.Precio}";




            }
            return producto;

        }
        public List<Producto> RecuperarProductos(Filtro filtro)
        {
            string consultaSql = ("SELECT p.id_producto, p.nombre, m.marca, t.talla, p.precio, p.descripcion, g.genero, r.rubro, tip.tipo_prenda  FROM productos p"
                       + " JOIN marcas as m on p.id_marca = m.id_marca"
                       + " JOIN generos as g on p.id_genero = g.id_genero "
                       + " JOIN tallas as t on t.id_talla = p.id_talla"
                       + " JOIN rubros as r on r.id_rubro = p.id_rubro"
                       + " JOIN tipos_prenda as tip on tip.id_tipo_prenda = p.id_tipo_prenda");
            string tallas_consulta = string.Empty;
            if (filtro.Nomb != string.Empty)
            {
                consultaSql = consultaSql + " AND p.nombre LIKE '%" + filtro.Nomb + "%'";
            }
            if (filtro.Desc != string.Empty)
            {
                consultaSql = consultaSql + " AND p.descripcion LIKE '%" + filtro.Desc + "%'";
            }
            if (filtro.IndMarca != -1)
            {
                consultaSql = consultaSql + " AND m.id_marca = '" + (filtro.IndMarca + 1)  + "'";
            }
            if (filtro.IndGenero != -1)
            {
                consultaSql = consultaSql + " AND g.id_genero = '" + (filtro.IndGenero + 1) + "'";
            }
            if (filtro.IndRubro != -1)
            {
                consultaSql = consultaSql + " AND r.id_rubro = '" + (filtro.IndRubro + 1) + "'";
            }
            if (filtro.IndTipo != -1)
            {
                consultaSql = consultaSql + " AND tip.id_tipo_prenda = '" + (filtro.IndTipo + 1) + "'";
            }
            if (filtro.Min != 0 || filtro.Max != 500000)
                {
                consultaSql = consultaSql + " AND p.precio between " + filtro.Min.ToString() + " and " + filtro.Max.ToString();
            }


            if (filtro.Xs || filtro.S || filtro.M || filtro.L || filtro.Xl || filtro.Xxl)
            {
                if (filtro.Xs) { tallas_consulta = tallas_consulta + ",'Xs'"; }
                if (filtro.S) { tallas_consulta = tallas_consulta + ",'S'"; }
                if (filtro.M) { tallas_consulta = tallas_consulta + ",'M'"; }
                if (filtro.L) { tallas_consulta = tallas_consulta + ",'L'"; }
                if (filtro.Xl) { tallas_consulta = tallas_consulta + ",'Xl'"; }
                if (filtro.Xxl) { tallas_consulta = tallas_consulta + ",'XXl'"; }

                tallas_consulta = tallas_consulta.Substring(1);

                consultaSql = consultaSql + " AND  t.talla in (" + tallas_consulta + ")";
            }
            List<Producto> Lista = new List<Producto>();
            DataTable tabla = oBD.Consulta(consultaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = new Producto();
                oProducto.Id = (int)fila[0];
                oProducto.Nombre = fila[1].ToString();
                oProducto.Marca = fila[2].ToString();
                oProducto.Talla = fila[3].ToString();
                oProducto.Precio = Convert.ToDouble(fila[4]);
                oProducto.Descripcion = fila[5].ToString();
                oProducto.Genero = fila[6].ToString();
                oProducto.Rubro = fila[7].ToString();
                oProducto.TipoPrenda = fila[8].ToString();

                Lista.Add(oProducto);
            }

            return Lista;
        }

        public void EditarProd(Producto prod)
        {
            string consulta = string.Empty;
            consulta = $@" UPDATE productos
SET nombre = '{prod.Nombre}', descripcion = '{prod.Descripcion}', id_marca = {prod.IdMarca}, id_rubro = {prod.Idrubro}, precio = {prod.Precio}, id_genero = {prod.IdGenero}, id_tipo_prenda = {prod.IdTipoPrenda}
WHERE id_producto = {prod.Id}";

            oBD.Comando(consulta);

        }


        //------------------------------------------------ CONSULTAS---------------------------------------------------------
        public List<Producto> CargarConsulta(int NroConsulta)
        {
            int nroConsulta;
            nroConsulta = NroConsulta;

            if (nroConsulta == 5)
            {
                List<Producto> Lista = new List<Producto>();
                DataTable tabla = oBD.Consulta("EXEC Consulta5");

                foreach (DataRow fila in tabla.Rows)
                {
                    Producto oProducto = new Producto();
                    oProducto.Id = (int)fila[0];
                    oProducto.Nombre = fila[1].ToString();
                    oProducto.Marca = fila[2].ToString();
                    oProducto.Talla = fila[3].ToString();
                    oProducto.Precio = Convert.ToDouble(fila[4]);
                    oProducto.Descripcion = fila[5].ToString();
                    oProducto.Genero = fila[6].ToString();
                    oProducto.Rubro = fila[7].ToString();
                    oProducto.TipoPrenda = fila[8].ToString();

                    Lista.Add(oProducto);
                }
                return Lista;
            }

            if (nroConsulta == 6)
            {
                List<Producto> Lista = new List<Producto>();
                DataTable tabla = oBD.Consulta("EXEC Consulta6");

                foreach (DataRow fila in tabla.Rows)
                {
                    Producto oProducto = new Producto();
                    oProducto.Id = (int)fila[0];
                    oProducto.Nombre = fila[1].ToString();
                    oProducto.Marca = fila[2].ToString();
                    oProducto.Talla = fila[3].ToString();
                    oProducto.Precio = Convert.ToDouble(fila[4]);
                    oProducto.Descripcion = fila[5].ToString();
                    oProducto.Genero = fila[6].ToString();
                    oProducto.Rubro = fila[7].ToString();
                    oProducto.TipoPrenda = fila[8].ToString();

                    Lista.Add(oProducto);
                }
                return Lista;
            }

            if (nroConsulta == 7)
            {
                List<Producto> Lista = new List<Producto>();
                DataTable tabla = oBD.Consulta("EXEC Consulta7");

                foreach (DataRow fila in tabla.Rows)
                {
                    Producto oProducto = new Producto();
                    oProducto.Id = (int)fila[0];
                    oProducto.Nombre = fila[1].ToString();
                    oProducto.Marca = fila[2].ToString();
                    oProducto.Talla = fila[3].ToString();
                    oProducto.Precio = Convert.ToDouble(fila[4]);
                    oProducto.Descripcion = fila[5].ToString();
                    oProducto.Genero = fila[6].ToString();
                    oProducto.Rubro = fila[7].ToString();
                    oProducto.TipoPrenda = fila[8].ToString();

                    Lista.Add(oProducto);
                }
                return Lista;
            }

            if (nroConsulta == 8)
            {
                List<Producto> Lista = new List<Producto>();
                DataTable tabla = oBD.Consulta("EXEC Consulta8");

                foreach (DataRow fila in tabla.Rows)
                {
                    Producto oProducto = new Producto();
                    oProducto.Id = (int)fila[0];
                    oProducto.Nombre = fila[1].ToString();
                    oProducto.Marca = fila[2].ToString();
                    oProducto.Talla = fila[3].ToString();
                    oProducto.Precio = Convert.ToDouble(fila[4]);
                    oProducto.Descripcion = fila[5].ToString();
                    oProducto.Genero = fila[6].ToString();
                    oProducto.Rubro = fila[7].ToString();
                    oProducto.TipoPrenda = fila[8].ToString();

                    Lista.Add(oProducto);
                }
                return Lista;
            }

            //Nunca va a llegar hasta aquí, ya que nroConsulta siempre tendra un valor
            List<Producto> ListaVacia = new List<Producto>();
            return ListaVacia;
        }
    }   
}
