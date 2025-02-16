using MenuPrincipalTPI.Datos;
using MenuPrincipalTPI.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajoparte3;

namespace MenuPrincipalTPI
{
    public partial class frmMenuPrincipal : Form
    {
        AccesoDatos DB;
        public bool mostrar = false;
        Consultas consultas;
        public frmMenuPrincipal()
        {   
            InitializeComponent();
            DB = new AccesoDatos();
            textCadenaConexion.Text = DB.DevolverConeccion();
            

           
            textCadenaConexion.Enabled = false;
            textCadenaConexion.Visible = false;
            butConectar.Enabled = false;
            butConectar.Visible = false;
            mostrar = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarProductos frmP = new frmCargarProductos(DB);
            frmP.ShowDialog();
            this.Show();
        }

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarDatos frmD = new frmCargarDatos(textCadenaConexion.Text.Trim());
            frmD.ShowDialog();
            this.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            labeLink.Visible = false;
            if (DB.Comprobar(textCadenaConexion.Text.Trim()))
            {
                butSql.BackgroundImage = Properties.Resources.Verde;
            }
            else
            {
                butSql.BackgroundImage = Properties.Resources.Rojo;
            }



        }

        private void butCargarProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarProductos frmP = new frmCargarProductos(DB);
            frmP.ShowDialog();
            this.Show();
        }

        private void butCargarAux_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarDatos frmD = new frmCargarDatos(textCadenaConexion.Text.Trim());
            frmD.ShowDialog();
            this.Show();
        }

        private void butVerProd_Click(object sender, EventArgs e)
        {
            //en mi form la clase constructora te pide la coneccion, todos los form tendrian que tener esto
            VistaProdFrm vp = new VistaProdFrm(textCadenaConexion.Text.Trim(), 0);
            //oculto el menu, en el evento del VistaProdform de cuando se cierra, pongo que el menu se habilite de nuevo
            this.Hide();
            vp.ShowDialog();
            this.Show();
        }

        private void butSql_Click(object sender, EventArgs e)
        {
            //si mostrar esta en true oculta
            if (mostrar)
            {
                textCadenaConexion.Enabled = false;
                textCadenaConexion.Visible = false;
                butConectar.Enabled = false;
                butConectar.Visible = false;
                
                labeLink.Visible = false;
                mostrar = false;
                

            }
            else
            {
                //si esta en false habilita todo
                textCadenaConexion.Enabled = true;
                textCadenaConexion.Visible = true;
                butConectar.Enabled = true;
                butConectar.Visible = true;
                labeLink.Visible = true;
                mostrar = true;
                
            }
        }

        private void butConectar_Click(object sender, EventArgs e)
        {
            string conexion = textCadenaConexion.Text.Trim();
            DB = new AccesoDatos(conexion);
            
            if (DB.Comprobar(textCadenaConexion.Text.Trim()))
            {
                MessageBox.Show("Se conectó con la base de datos: ", "Coneccion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelConexion.Text = "CONECTADO";
                labelConexion.ForeColor = Color.Green;
                butSql.BackgroundImage = Properties.Resources.Verde;

                textCadenaConexion.Enabled = false;
                textCadenaConexion.Visible = false;
                butConectar.Enabled = false;
                butConectar.Visible = false;
                mostrar = false;
                labeLink.Visible= false;
               

            }
            else
            {

                butSql.BackgroundImage = Properties.Resources.Rojo;
                labelConexion.Text = "DESCONECTADO";
                labelConexion.ForeColor = Color.Red;
            }

        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaProdFrm frmV = new VistaProdFrm(textCadenaConexion.Text.Trim(), 5);
            frmV.ShowDialog();
            this.Show();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaProdFrm frmV = new VistaProdFrm(textCadenaConexion.Text.Trim(), 6);
            frmV.ShowDialog();
            this.Show();
        }

        private void consulta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaProdFrm frmV = new VistaProdFrm(textCadenaConexion.Text.Trim(), 7);
            frmV.ShowDialog();
            this.Show();
        }

        private void consulta8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaProdFrm frmV = new VistaProdFrm(textCadenaConexion.Text.Trim(), 8);
            frmV.ShowDialog();
            this.Show();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcercaDeNosotros frmA = new frmAcercaDeNosotros(DB);
            frmA.ShowDialog();
            this.Show();
        }

        private void fashionWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcercaDeFashionWord frmA = new frmAcercaDeFashionWord();
            frmA.ShowDialog();
            this.Show();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultas = new Consultas(textCadenaConexion.Text.Trim());
            this.Hide();
            consultas.ShowDialog();
            this.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //en mi form la clase constructora te pide la coneccion, todos los form tendrian que tener esto
            VistaProdFrm vp = new VistaProdFrm(textCadenaConexion.Text.Trim(), 0);
            //oculto el menu, en el evento del VistaProdform de cuando se cierra, pongo que el menu se habilite de nuevo
            this.Hide();
            vp.ShowDialog();
            this.Show();
        }

        private void lblFashionWord_Click(object sender, EventArgs e)
        {

        }
    }
}
