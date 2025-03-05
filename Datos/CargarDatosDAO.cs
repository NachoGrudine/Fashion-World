using MenuPrincipalTPI.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Datos
{
    public class CargarDatosDAO
    {
        AccesoDatos oBD;

        // Constructor que inicializa la instancia de AccesoDatos
        public CargarDatosDAO(string cadena)
        {
            oBD = new AccesoDatos(cadena);
        }

        // Metodo para recuperar todas las marcas de la base de datos
        public List<Marcas> RecuperarMarcas()
        {
            List<Marcas> Lista = new List<Marcas>();
            DataTable tabla = oBD.ConsultarTabla("marcas");
            foreach (DataRow fila in tabla.Rows)
            {
                Marcas oMarca = new Marcas();
                oMarca.Codigo = (int)fila["id_marca"];
                oMarca.Marca = fila["marca"].ToString();
                Lista.Add(oMarca);
            }
            return Lista;
        }

        // Metodo para recuperar todos los tipos de prendas de la base de datos
        public List<TiposPrendas> RecuperarTiposPrenda()
        {
            List<TiposPrendas> Lista1 = new List<TiposPrendas>();
            DataTable tabla = oBD.ConsultarTabla("tipos_prenda");
            foreach (DataRow fila in tabla.Rows)
            {
                TiposPrendas oTp = new TiposPrendas();
                oTp.Codigo = (int)fila["id_tipo_prenda"];
                oTp.TipoPrenda = fila["tipo_prenda"].ToString();
                Lista1.Add(oTp);
            }
            return Lista1;
        }

        // Metodo para recuperar todos los rubros de la base de datos
        public List<Rubros> RecuperarRubros()
        {
            List<Rubros> Lista2 = new List<Rubros>();
            DataTable tabla = oBD.ConsultarTabla("rubros");
            foreach (DataRow fila in tabla.Rows)
            {
                Rubros oRubro = new Rubros();
                oRubro.Codigo = (int)fila["id_rubro"];
                oRubro.Rubro = fila["rubro"].ToString();
                Lista2.Add(oRubro);
            }
            return Lista2;
        }

        // Metodo para agregar una nueva marca a la base de datos
        public void AgregarMarca(string marca)
        {
            string consulta = "INSERT INTO marcas (marca) VALUES (@marca)";
            List<ParametrosCargarDatos> parametros = new List<ParametrosCargarDatos>
            {
                new ParametrosCargarDatos("@marca", marca)
            };
            oBD.ActualizarBDDatos(consulta, parametros);
        }

        // Metodo para agregar un nuevo rubro a la base de datos
        public void AgregarRubro(string rubro)
        {
            string consulta = "INSERT INTO rubros (rubro) VALUES (@rubro)";
            List<ParametrosCargarDatos> parametros = new List<ParametrosCargarDatos>
            {
                new ParametrosCargarDatos("@rubro", rubro)
            };
            oBD.ActualizarBDDatos(consulta, parametros);
        }

        // Metodo para agregar un nuevo tipo de prenda a la base de datos
        public void AgregarTipoPrenda(string tipoPrenda)
        {
            string consulta = "INSERT INTO tipos_prenda (tipo_prenda) VALUES (@tipoPrenda)";
            List<ParametrosCargarDatos> parametros = new List<ParametrosCargarDatos>
            {
                new ParametrosCargarDatos("@tipoPrenda", tipoPrenda)
            };
            oBD.ActualizarBDDatos(consulta, parametros);
        }

        // Metodo para verificar si un valor existe en alguna de las tablas (marcas, rubros, tipos de prenda)
        public bool ExisteValorEnTablas(string valor)
        {
            if (ExisteValorEnTabla("marcas", "marca", valor))
            {
                return true;
            }

            if (ExisteValorEnTabla("rubros", "rubro", valor))
            {
                return true;
            }

            if (ExisteValorEnTabla("tipos_prenda", "tipo_prenda", valor))
            {
                return true;
            }

            return false; // El valor no existe en ninguna tabla
        }

        // Metodo para verificar si un valor especifico existe en una tabla y columna dadas
        public bool ExisteValorEnTabla(string nombreTabla, string columna, string valor)
        {
            string consulta = $"SELECT COUNT(*) FROM {nombreTabla} WHERE {columna} = @valor";
            List<ParametrosCargarDatos> parametros = new List<ParametrosCargarDatos>
            {
                new ParametrosCargarDatos("@valor", valor)
            };
            object resultado = oBD.ConsultaEscalar(consulta, parametros);

            return Convert.ToInt32(resultado) > 0;
        }
    }
}
