using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Negocio
{
    public class TiposPrendas
    {
        //ATRIBUTOS Y PROPIEDADES
        public int Codigo { get; set; }
        public string TipoPrenda { get; set; }

        //METODOS
        public override string ToString()
        {
            return TipoPrenda;
        }
    }
}
