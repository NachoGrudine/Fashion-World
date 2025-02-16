using MenuPrincipalTPI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajoparte3
{
    public partial class Filtrosfrm : Form
    {



        AccesoDatos oBD;


        Filtro filtro = new Filtro();
        public Filtrosfrm(Filtro filtro, string cadena)
        {

            this.filtro = filtro;
            InitializeComponent();
            oBD = new AccesoDatos(cadena);
            CargarCombo(comboGeneros, "generos");
            CargarCombo(comboMarcas, "marcas");
            CargarCombo(comboTipos, "tipos_prenda");
            CargarCombo(comboRubros, "rubros");

            comboMarcas.Enabled = false;
            comboRubros.Enabled = false;
            comboGeneros.Enabled = false;
            numPrecioMax.Enabled = false;
            numPrecioMin.Enabled = false;
            comboTipos.Enabled = false;
            checkXs.Enabled = false;
            checkS.Enabled = false;
            checkM.Enabled = false;
            checkL.Enabled = false;
            checkXl.Enabled = false;
            checkXxl.Enabled = false;
            textNombre.Enabled = false;
            textDesc.Enabled = false;

            CargarFiltro();


        }

        public Filtrosfrm()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            comboMarcas.Enabled = false;
            comboRubros.Enabled = false;
            comboGeneros.Enabled = false;
            numPrecioMax.Enabled = false;
            numPrecioMin.Enabled = false;
            comboTipos.Enabled = false;
            checkXs.Enabled = false;
            checkS.Enabled = false;
            checkM.Enabled = false;
            checkL.Enabled = false;
            checkXl.Enabled = false;
            checkXxl.Enabled = false;
            textNombre.Enabled = false;
            textDesc.Enabled = false;
            checkS.Checked = true;
        }

        public void CargarFiltro()
        {
            textNombre.Text = filtro.Nomb;
            textDesc.Text = filtro.Desc;
            comboMarcas.SelectedIndex = filtro.IndMarca;
            comboGeneros.SelectedIndex = filtro.IndGenero;
            comboRubros.SelectedIndex = filtro.IndRubro;
            comboTipos.SelectedIndex = filtro.IndTipo;
            numPrecioMin.Value = filtro.Min;
            numPrecioMax.Value = filtro.Max;
            checkXs.Checked = filtro.Xs;
            checkS.Checked = filtro.S;
            checkM.Checked = filtro.M;
            checkL.Checked = filtro.L;
            checkXl.Checked = filtro.Xl;
            checkXxl.Checked = filtro.Xxl;

            if (filtro.Nomb != string.Empty)
            {
                checkNombre.Checked = true;

            }
            if (filtro.Desc != string.Empty)
            {
                checkDescripcion.Checked = true;

            }
            if (filtro.IndMarca != -1)
            {
                checkMarca.Checked = true;

            }
            if (filtro.IndGenero != -1)
            {
                checkGenero.Checked = true;

            }
            if (filtro.IndRubro != -1)
            {
                checkRubro.Checked = true;

            }
            if (filtro.IndTipo != -1)
            {
                checkTipo.Checked = true;

            }

            if (filtro.Min != 0 || filtro.Max != 500000)
            {
                checkPrecio.Checked = true;

            }
            if (filtro.Xs)
            {
                checkTallas.Checked = true;

            }
            if (filtro.S)
            {
                checkTallas.Checked = true;

            }
            if (filtro.M)
            {
                checkTallas.Checked = true;

            }
            if (filtro.L)
            {
                checkTallas.Checked = true;

            }
            if (filtro.Xl)
            {
                checkTallas.Checked = true;

            }
            if (filtro.Xxl)
            {
                checkTallas.Checked = true;

            }
        }
        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
            //creo tabla del tipo datatable, y le pido consultar tabla
            DataTable tabla = oBD.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            //tomo el valor de los ids para el valuemember(el valor de lo seleccionado)
            combo.ValueMember = tabla.Columns[0].ColumnName;
            //tomo el nombre para el texto que muestra en el desplegable como las opciones
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            //establezco el combo en ninguno seleccionado
            combo.SelectedIndex = -1;
            //le digo que el combo(el desplegable) sea dropdownlist, asi no se puede editar el texto que contiene
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void checkMarca_CheckedChanged(object sender, EventArgs e)
        {
            //MARCAS
            if (checkMarca.Checked == false)
            {
                comboMarcas.Enabled = false;
                comboMarcas.SelectedIndex = -1;
            }
            else
            {
                comboMarcas.Enabled = true;
            }
        }

        private void checkRubro_CheckedChanged(object sender, EventArgs e)
        {
            //RUBROS
            if (checkRubro.Checked == false)
            {
                comboRubros.Enabled = false;
                comboRubros.SelectedIndex = -1;
            }
            else
            {
                comboRubros.Enabled = true;
            }
        }

        private void checkGenero_CheckedChanged(object sender, EventArgs e)
        {
            //GENEROS
            if (checkGenero.Checked == false)
            {
                comboGeneros.Enabled = false;
                comboGeneros.SelectedIndex = -1;
            }
            else
            {
                comboGeneros.Enabled = true;
            }
        }

        private void checkPrecio_CheckedChanged(object sender, EventArgs e)
        {
            // Precio
            if (checkPrecio.Checked == false)
            {
                numPrecioMax.Enabled = false;
                numPrecioMax.Value = 500000;
                numPrecioMin.Enabled = false;
                numPrecioMin.Value = 0;
            }
            else
            {
                numPrecioMax.Enabled = true;
                numPrecioMin.Enabled = true;
            }
        }

        private void checkTipo_CheckedChanged(object sender, EventArgs e)
        {
            //TIPO DE PRENDA
            if (checkTipo.Checked == false)
            {
                comboTipos.Enabled = false;
                comboTipos.SelectedIndex = -1;
            }
            else
            {
                comboTipos.Enabled = true;
            }
        }


        private void checkTallas_CheckedChanged(object sender, EventArgs e)
        {
            //Tallas
            if (checkTallas.Checked == false)
            {
                checkXs.Enabled = false;
                checkS.Enabled = false;
                checkM.Enabled = false;
                checkL.Enabled = false;
                checkXl.Enabled = false;
                checkXxl.Enabled = false;
                checkXs.Checked = false;
                checkS.Checked = false;
                checkM.Checked = false;
                checkL.Checked = false;
                checkXl.Checked = false;
                checkXxl.Checked = false;

            }
            else
            {
                checkXs.Enabled = true;
                checkS.Enabled = true;
                checkM.Enabled = true;
                checkL.Enabled = true;
                checkXl.Enabled = true;
                checkXxl.Enabled = true;
            }


        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            CargarFiltro();
            this.Close();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            checkMarca.Checked = false;
            checkPrecio.Checked = false;
            checkTallas.Checked = false;
            checkRubro.Checked = false;
            checkGenero.Checked = false;
            checkTipo.Checked = false;
            checkNombre.Checked = false;
            checkDescripcion.Checked = false;
        }

        private void checkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            //Descripciones
            if (checkDescripcion.Checked == false)
            {
                textDesc.Enabled = false;
                textDesc.Text = string.Empty;
            }
            else
            {
                textDesc.Enabled = true;
            }
        }

        private void checkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombre.Checked == false)
            {
                textNombre.Enabled = false;
                textNombre.Text = string.Empty;
            }
            else
            {
                textNombre.Enabled = true;
            }
        }
        //Filtrosfrm(string nomb, string desc,int indMarca, int indRubro, int indGenero,int indTipo, int min, int max, bool xs, bool s, bool m, bool l, bool xl, bool xll)

        public Filtro Recordar()
        {
            return (filtro);
        }





        //public string ObtenerFiltros()
        //{
        //    string tallas_consulta = string.Empty;
        //    if (textNombre.Text != string.Empty)
        //    {
        //        consultaSql = consultaSql + " AND p.nombre LIKE '%" + textNombre.Text + "%'";
        //    }
        //    if (textDesc.Text != string.Empty)
        //    {
        //        consultaSql = consultaSql + " AND p.descripcion LIKE '%" + textDesc.Text + "%'";
        //    }
        //    if (comboMarcas.SelectedIndex != -1)
        //    {
        //        consultaSql = consultaSql + " AND m.marca = '" + comboMarcas.Text + "'";
        //    }
        //    if (comboGeneros.SelectedIndex != -1)
        //    {
        //        consultaSql = consultaSql + " AND g.genero = '" + comboGeneros.Text + "'";
        //    }
        //    if (comboRubros.SelectedIndex != -1)
        //    {
        //        consultaSql = consultaSql + " AND r.rubro = '" + comboRubros.Text + "'";
        //    }
        //    if (comboTipos.SelectedIndex != -1)
        //    {
        //        consultaSql = consultaSql + " AND tip.tipo_prenda = '" + comboTipos.Text + "'";
        //    }
        //    if (checkPrecio.Checked)
        //    {
        //        consultaSql = consultaSql + " AND p.precio between " + numPrecioMin.Value.ToString() + " and " + numPrecioMax.Value.ToString();
        //    }
        //    if (checkTallas.Checked && (checkXs.Checked || checkS.Checked || checkM.Checked || checkL.Checked || checkXl.Checked || checkXxl.Checked))
        //    {

        //        if (checkXs.Checked) { tallas_consulta = tallas_consulta + ",'Xs'"; }
        //        if (checkS.Checked) { tallas_consulta = tallas_consulta + ",'S'"; }
        //        if (checkM.Checked) { tallas_consulta = tallas_consulta + ",'M'"; }
        //        if (checkL.Checked) { tallas_consulta = tallas_consulta + ",'L'"; }
        //        if (checkXl.Checked) { tallas_consulta = tallas_consulta + ",'Xl'"; }
        //        if (checkXxl.Checked) { tallas_consulta = tallas_consulta + ",'XXl'"; }

        //        tallas_consulta = tallas_consulta.Substring(1);

        //        consultaSql = consultaSql + " AND  t.talla in (" + tallas_consulta + ")";
        //    }
        //    return consultaSql;
        //}
        private void butAplicar_Click(object sender, EventArgs e)
        {
            filtro.Nomb = textNombre.Text;
            filtro.Desc = textDesc.Text;
            filtro.IndMarca = comboMarcas.SelectedIndex;
            filtro.IndGenero = comboGeneros.SelectedIndex;
            filtro.IndRubro = comboRubros.SelectedIndex;
            filtro.IndTipo = comboTipos.SelectedIndex;
            filtro.Min = (int)numPrecioMin.Value;
            filtro.Max = (int)numPrecioMax.Value;
            filtro.Xs = checkXs.Checked;
            filtro.S = checkS.Checked;
            filtro.M = checkM.Checked;
            filtro.L = checkL.Checked;
            filtro.Xl = checkXl.Checked;
            filtro.Xxl = checkXxl.Checked;
            this.Close();




        }
    }
}
