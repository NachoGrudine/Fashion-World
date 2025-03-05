using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Negocio
{
    public class Marcas
    {
        //ATRIBUTOS Y PROPIEDADES
        public int Codigo { get; set; }
        public string Marca { get; set; }

        //METODOS
        public override string ToString()
        {
            return Marca;
        }
    }
}
