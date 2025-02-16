using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajoparte3
{
    public class Producto
    {
        private int id;
        public int Id
        { 
            get { return id; }
            set { id = value; } 
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string talla;
        public string Talla
        {
            get { return talla; }
            set { talla = value; }
        }


        private double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string genero;
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private string rubro;
        public string Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }

        private string tipoprenda;
        public string TipoPrenda
        {
            get { return tipoprenda; }
            set { tipoprenda = value; }
        }

        private int idmarca;
        public int IdMarca
        {
            get { return idmarca; }
            set { idmarca = value; }
        }
        private int idtalla;
        public int IdTalla
        {
            get { return idtalla; }
            set { idtalla = value; }
        }

        private int idgenero;
        public int IdGenero
        {
            get { return idgenero; }
            set { idgenero = value; }
        }

        private int idrubro;
        public int Idrubro
        {
            get { return idrubro; }
            set { idrubro = value; }
        }

        private int idtipoprenda;
        public int IdTipoPrenda
        {
            get { return idtipoprenda; }
            set { idtipoprenda = value; }
        }

















        //public override string ToString()
        //{
        //    return $"{Nombre} - {Descripcion} - ${Precio} - {NombreMarca} - {NombreGenero}";

        //}
    }


}
