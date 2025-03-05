using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajoparte3
{
    public class Filtro
    {
        private string nomb;
        public string Nomb
        {
            get { return nomb; }
            set { nomb = value; }
        }

        private string desc;
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        private int indMarca;
        public int IndMarca
        {
            get { return indMarca; }
            set { indMarca = value; }
        }

        private int indRubro;
        public int IndRubro
        {
            get { return indRubro; }
            set { indRubro = value; }
        }

        private int indGenero;
        public int IndGenero
        {
            get { return indGenero; }
            set { indGenero = value; }
        }

        private int indTipo;
        public int IndTipo
        {
            get { return indTipo; }
            set { indTipo = value; }
        }

        private int min;
        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        private int max;
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        private bool xs;
        public bool Xs
        {
            get { return xs; }
            set { xs = value; }
        }

        private bool s;
        public bool S
        {
            get { return s; }
            set { s = value; }
        }

        private bool m;
        public bool M
        {
            get { return m; }
            set { m = value; }
        }

        private bool l;
        public bool L
        {
            get { return l; }
            set { l = value; }
        }

        private bool xl;
        public bool Xl
        {
            get { return xl; }
            set { xl = value; }
        }

        private bool xxl;
        public bool Xxl
        {
            get { return xxl; }
            set { xxl = value; }
        }

        public Filtro()
        {

            nomb = string.Empty;
            desc = string.Empty;
            indMarca = -1;
            indRubro = -1;
            indGenero = -1;
            indTipo = -1;
            min = 0;
            max = 500000;
            xs = false;
            s = false;
            m = false;
            l = false;
            xl = false;
            xxl = false;
        }

        public Filtro(string nomb, string desc, int indMarca, int indRubro, int indGenero, int indTipo, int min, int max, bool xs, bool s, bool m, bool l, bool xl, bool xxl)
        {
            this.nomb = nomb;
            this.desc = desc;
            this.indMarca = indMarca;
            this.indRubro = indRubro;
            this.indGenero = indGenero;
            this.indTipo = indTipo;
            this.min = min;
            this.max = max;
            this.xs = xs;
            this.s = s;
            this.m = m;
            this.l = l;
            this.xl = xl;
            this.xxl = xxl;


        }
    }
}

