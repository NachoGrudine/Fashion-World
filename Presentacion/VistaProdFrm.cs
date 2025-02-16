using MenuPrincipalTPI.Datos;
using MenuPrincipalTPI.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// cadena utn: Data Source=172.16.10.196;Initial Catalog=FW_part2_CORRECTO;User ID=alumno1w2;Password=alumno1w2
namespace Trabajoparte3
{
    public partial class VistaProdFrm : Form
    {
        public int NroConsulta;
        ServicioVerProductos Svp;
        AccesoDatos DB;
        int totales = 0;
        private string cadena;
        bool direction = false; 

        Filtro filtro = new Filtro();
        public VistaProdFrm(string cadena, int consulta)
        {
            InitializeComponent();

            this.cadena = cadena;
            Svp = new ServicioVerProductos(cadena);
            NroConsulta = consulta;
        }

        public void CargarConsulta(int nroConsulta)
        {
            CargarGrilla(Svp.CargarConsulta(nroConsulta));
        }
        public void CargarGrilla(List<Producto> lista)
        {

            labMostrando.Text = "Mostrando: ";
            string precio = string.Empty;


            dataGrid.Rows.Clear();
            foreach (Producto prod in lista)
            {

                precio = "$" + prod.Precio.ToString();
                dataGrid.Rows.Add(prod.Id, prod.Nombre, prod.Marca, prod.Talla, precio);


            }
            labMostrando.Text = labMostrando.Text + dataGrid.RowCount.ToString();
            labTotal.Text = "Totales: " + totales.ToString();
        }



        private void butVerdet_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count == 0)
            {
                while (MessageBox.Show("No hay un producto soleccionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error) != DialogResult.OK)
                {

                }

            }


            else
            {

                while (MessageBox.Show(Svp.RecuperarDetalle(dataGrid.CurrentRow.Cells[0].Value.ToString()), "Datos del Producto", MessageBoxButtons.OK) != DialogResult.OK)
                {

                }

            }

        }



        private void butBuscar_Click(object sender, EventArgs e)
        {
            Filtrosfrm fd = new Filtrosfrm(filtro, cadena);
            fd.ShowDialog();

            CargarGrilla(Svp.ListaProductos(filtro));
            filtro = fd.Recordar();


        }

        private void VistaProdFrm_Load(object sender, EventArgs e)
        {
            if (NroConsulta != 0)
            {
                CargarConsulta(NroConsulta);
            }
            else 
            {
                CargarGrilla(Svp.ListaProductos(filtro));
                totales = dataGrid.RowCount;
                labTotal.Text = "Totales: " + totales.ToString();
            }
            
        }



        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGrid.Rows.Count == 0)
            {
                while (MessageBox.Show("No hay un producto soleccionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error) != DialogResult.OK)
                {

                }

            }
            else
            {
                if (MessageBox.Show("DESEA ELIMINAR EL PRODUCTO: " + dataGrid.CurrentRow.Cells[1].Value.ToString() + " " + dataGrid.CurrentRow.Cells[3].Value.ToString() + "?", "Eliminar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {

                    if(Svp.EliminarProducto(dataGrid.CurrentRow.Cells[0].Value.ToString()))
                    { totales = totales - 1; }
                    
                    Filtrosfrm fd = new Filtrosfrm(new Filtro(), cadena);
                    CargarGrilla(Svp.ListaProductos(filtro));
                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto prod;
            if (dataGrid.Rows.Count == 0)
            {
                while (MessageBox.Show("No hay un producto soleccionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error) != DialogResult.OK)
                {

                }

            }
            else
            {
                DB = new AccesoDatos(cadena);
                prod = Svp.BuscarProd(dataGrid.CurrentRow.Cells[0].Value.ToString());
                frmCargarProductos Cp = new frmCargarProductos(DB,prod,cadena);
                this.Hide();
                Cp.ShowDialog();
                this.Show();
                CargarGrilla(Svp.ListaProductos(filtro));
            }
        }



        private void dataGrid_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewColumn column = dataGrid.Columns[e.ColumnIndex];



            if (column.Name == "colPrecio")
            {
                if (direction)
                {
                    direction = false;
                    CargarGrilla(Svp.ListaProductosOrdenados(filtro, " Order by p.precio DESC"));
                }
                else
                {
                    direction = true;
                    CargarGrilla(Svp.ListaProductosOrdenados(filtro, " Order by p.precio ASC"));

                }


            }
        }
    }



}



