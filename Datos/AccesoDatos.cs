using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace MenuPrincipalTPI.Datos
{
    public class AccesoDatos
    {
        //                               
        //                                
        string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos()
        {
            conexion= new SqlConnection(cadenaConexion);            //defino la conexion con el link de la base de datos
        }

        public string DevolverConeccion()
        {
            return cadenaConexion;        
        }
        public void Conectar()                                     //abrir la conexion con la base de datos
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public AccesoDatos(string cadena)

        {
            
            try
            {
                conexion = new SqlConnection(cadena.Replace(@"\\", @"\"));
                conexion.Open();
                conexion.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error en la cadena de conexión: ", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion = null;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: ", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: ", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion = null;
            }


        }



        public DataTable ConsultarTabla(string nombreTabla)          //metodo para sacar las tablas y cargarlas en el combobox
        {
            DataTable tabla = new DataTable();                      //creo el objeto tabla con los parametros del nombre de tabla
            Conectar();                                             //abre la conexion con la base de datos
            comando.CommandText = "SELECT * FROM " + nombreTabla;   //hace la consulta en la BD con el nombre de la tabla 
            tabla.Load(comando.ExecuteReader());                    //en tabla se van a guardar los valores que el datareader obtenga de la base de datos
            Desconectar();
            return tabla;
        }

        public void Comando(string delete)
        {
            this.Conectar();
            comando.CommandText = delete;
            comando.ExecuteReader();
            this.Desconectar();
        }


        public DataTable Consulta(string consultaSql)
        {
            //creo la tabla
            DataTable tabla = new DataTable();
            this.Conectar();
            //pido datos de la tabla
            comando.CommandText = consultaSql;
            //ejecuto el comando
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();

            return tabla;


        }

        public bool Comprobar(string cadena)
        {
            try
            {
                conexion = new SqlConnection(cadena.Replace(@"\\", @"\").Trim());
                conexion.Open();
                conexion.Close();
                return true;
            }
            catch 
            {
                
                return false;
            }
            
        }




        //------------------------------------------------Cargar Productos-------------------------------------------------------------------------------


        public int ActualizarBDProductos(string consultaSQL, List<ParametrosProductos> parametros)
        {
            int filasAfectadas = 0;

                Conectar();
                SqlCommand cmd = new SqlCommand(consultaSQL, conexion); //instancia de la clase SqlCommand que usa el parametro consulta SQL y la coneccion con la BD
                foreach (ParametrosProductos parametro in parametros)   //verifico si el parametro cargado es una Lista 
                {
                                                                        // Verificar si el valor es una lista de cadenas
                    if (parametro.Valor is List<string>)
                    {
                                                                        // Unir todos los valores de la lista  en una sola cadena separada por comas
                        string valor = string.Join(",", (List<string>)parametro.Valor);
                        cmd.Parameters.AddWithValue(parametro.Nombre, valor);
                    }
                    else
                    {
                                                                        // Agregar el parámetro normalmente
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
                    }
                }
                filasAfectadas = cmd.ExecuteNonQuery();
            Desconectar();
            
            return filasAfectadas;
        }

        public string ObtenerNombreMarca(int codigoMarca)               //busco el nombre de la marca accediento a la tabla auxiliar marcas
        {
            string nombreMarca = string.Empty;
            
                string consultaSQL = "SELECT marca FROM marcas WHERE id_marca = @id_marca";

                SqlCommand cmd = new SqlCommand(consultaSQL, conexion);
                cmd.Parameters.AddWithValue("@id_marca", codigoMarca);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nombreMarca = reader["marca"].ToString();
                }
            Desconectar();
            return nombreMarca;
        }
        public string ObtenerNombreGenero(int codigoGenero)             //busco el nombre del genero accediento a la tabla auxiliar generos
        {
            string nombreGenero = string.Empty;
            
                string consultaSQL = "SELECT genero FROM generos WHERE id_genero = @id_genero";

                SqlCommand cmd = new SqlCommand(consultaSQL, conexion);
                cmd.Parameters.AddWithValue("@id_genero", codigoGenero);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nombreGenero = reader["genero"].ToString();
                }
            Desconectar();
            return nombreGenero;
        }

        //--------------------------------------------------------Cargar Datos----------------------------------------------------------------
        public object ConsultaEscalar(string consultaSQL, List<ParametrosCargarDatos> parametros)      // Metodo para ejecutar una consulta SQL que retorna un valor escalar
        {
            object resultado = null;
            Conectar();
            comando.CommandText = consultaSQL;
            foreach (ParametrosCargarDatos p in parametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            resultado = comando.ExecuteScalar();
            Desconectar();
            return resultado;
        }

        public int ActualizarBDDatos(string consultaSQL, List<ParametrosCargarDatos> lista)
        {
            int filasAfectadas = 0;
            Conectar();
            comando.CommandText = consultaSQL;
            foreach (ParametrosCargarDatos p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }

        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }
    }
}
