using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Datos
{
    public class ParametrosProductos
    {
        //ATRIBUTOS Y PROPIEDADES
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private object valor;
        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        //CONSTRUCTOR
        public ParametrosProductos(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
