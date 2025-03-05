using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalTPI.Negocio
{
    public class Productos
    {
        //ATRIBUTOS Y PROPIEDADES
        private int tipoprenda;
        public int TipoPrenda
        {
            get { return tipoprenda; }
            set { tipoprenda = value; }
        }


        private int rubro;
        public int Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }


        private int genero;
        public int Genero
        {
            get { return genero; }
            set { genero = value; }
        }


        private int marca;
        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        private double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private string nombreproducto;
        public string NombreProducto
        {
            get { return nombreproducto; }
            set { nombreproducto = value; }
        }


        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        private int talla;
        public int Talla
        {
            get { return talla; }
            set { talla = value; }
        }


        private string nombremarca;
        public string NombreMarca
        {
            get { return nombremarca; }
            set { nombremarca = value; }
        }


        private string nombregenero;
        public string NombreGenero
        {
            get { return nombregenero; }
            set { nombregenero = value; }
        }

        //METODO
        private string talle = string.Empty;
        
        public override string ToString()
        {
            if(talla == 1) { talle = "Xs"; }
            if (talla == 2) { talle = "S"; }
            if (talla == 3) { talle = "M"; }
            if (talla == 4) { talle = "L"; }
            if (talla == 5) { talle = "XL"; }
            if (talla == 6) { talle = "XLL"; }
            return $"{NombreProducto}  ( {talle} )";

        }
    }
}
