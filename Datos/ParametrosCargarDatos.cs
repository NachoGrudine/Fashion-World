using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Datos
{
    public class ParametrosCargarDatos
    {
        //ATRIBUTOS Y PROPIEDADES
        private string nombre;
        private object valor;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        //CONSTRUCTOR
        public ParametrosCargarDatos(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
