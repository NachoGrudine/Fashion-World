using MenuPrincipalTPI.Datos;
using MenuPrincipalTPI.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajoparte3;

namespace MenuPrincipalTPI.Presentacion
{
    public partial class frmCargarProductos : Form
    {
        private readonly ProductosServicio productoServicio;

        AccesoDatos objetoBaseDatos;
        ServicioVerProductos Svp;

        List<ParametrosProductos> listaDeParametros = new List<ParametrosProductos>();
        Productos p = null;

        List<Productos> listaProductos = new List<Productos>();                     //aca se van a guardar los valores del boton guardar para luego enviarlos con aceptar todos juntos
        Producto prod;
        string cadena;
        public frmCargarProductos(AccesoDatos DB1)
        {
            InitializeComponent();
            objetoBaseDatos = DB1;
            CargarCombo(cboMarcas, "Marcas");
            CargarCombo(cboRubros, "Rubros");
            CargarCombo(cboGeneros, "Generos");
            CargarCombo(cboTipoPrenda, "Tipos_prenda");
            productoServicio = new ProductosServicio(new ProductosDAO(objetoBaseDatos));
            butGuardarCamb.Enabled = false;
            butGuardarCamb.Visible = false;
        }

        public frmCargarProductos(AccesoDatos DB1, Producto prod, string cadena)
        {
            InitializeComponent();
            objetoBaseDatos = DB1;
            CargarCombo(cboMarcas, "Marcas");
            CargarCombo(cboRubros, "Rubros");
            CargarCombo(cboGeneros, "Generos");
            CargarCombo(cboTipoPrenda, "Tipos_prenda");
            butGuardarCamb.Enabled = true;
            butGuardarCamb.Visible = true;
            btnAceptar.Enabled = false;
            btnAceptar.Visible = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnGuardar.Enabled = false;
            btnGuardar.Visible = false;
            gbxTalles.Enabled = false;
            lstProductos.Enabled = false;
            this.prod = prod;
            this.cadena = cadena;
            productoServicio = new ProductosServicio(new ProductosDAO(objetoBaseDatos));
            if (prod.IdTalla == 1)
            {
                chkS.Checked = true;
                
            }
            if (prod.IdTalla == 2)
            {
                chkXS.Checked = true;

            }
            if (prod.IdTalla == 3)
            {
                chkM.Checked = true;

            }
            if (prod.IdTalla == 4)
            {
                chkL.Checked = true;

            }
            if (prod.IdTalla == 5)
            {
                chkXL.Checked = true;

            }
            if (prod.IdTalla == 6)
            {
                chkXXL.Checked = true;

            }
            txtProducto.Text = prod.Nombre;
            txtDescripcion.Text = prod.Descripcion;
            txtPrecio.Text = prod.Precio.ToString();
            cboMarcas.SelectedValue = prod.IdMarca;
            cboGeneros.SelectedValue = prod.IdGenero ;
            cboRubros.SelectedValue= prod.Idrubro ;
            cboTipoPrenda.SelectedValue = prod.IdTipoPrenda;






        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count > 0)
            {
                if (MessageBox.Show("Estas seguro que deseas volver?   Se perderan los productos no guardados", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                 == DialogResult.Yes)
                {
                    Close();
                }

            }
            else { Close(); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                CargarProducto();

                MessageBox.Show("¡Productos agregados a la cola de guardado, recuerde precionar 'guardar' para que los productos sean guardados", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiar();
            }
        }

        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = objetoBaseDatos.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void limpiar()
        {
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cboGeneros.SelectedIndex = -1;
            cboMarcas.SelectedIndex = -1;
            cboRubros.SelectedIndex = -1;
            cboTipoPrenda.SelectedIndex = -1;
            chkXS.Checked = false;
            chkS.Checked = false;
            chkM.Checked = false;
            chkL.Checked = false;
            chkXL.Checked = false;
            chkXXL.Checked = false;
            checkTodas.Checked = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count > 0)
            {
                foreach (Productos producto in listaProductos)
                {
                    if (!productoServicio.AgregarProducto(producto))
                    {
                        MessageBox.Show("¡Error en la carga de productos a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.limpiar();
                        return;

                    }
                }

                MessageBox.Show("¡productos cargados correctamente!", "soñao",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaProductos.Clear();
                lstProductos.Items.Clear();                                         //vacio ambas listas
                this.limpiar();
            }
            else
            {
                MessageBox.Show("¡¡No hay productos en la cola de guardado!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CargarProducto()
        {
            // Asegúrate de que "NombreColumnaDeMarca" sea el nombre correcto de la columna que contiene el nombre de la marca

            // Compilar las tallas seleccionadas en una cadena separada por comas
            if (checkTodas.Checked)                                                                         //List<int> talla = new List<int>();
            {
            
                int id = 1;
                while (id < 7)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;

                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);
                    p.Talla = id;
                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                    id = id + 1;
                }
            
            }
            else { 
                if (chkXS.Checked)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;

                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);
                    p.Talla = 1;
                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                }
                if (chkS.Checked)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;
                    p.Talla = 2;
                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);

                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                }
                if (chkM.Checked)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;
                    p.Talla = 3;
                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);

                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                }
                if (chkL.Checked)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;
                    p.Talla = 4;
                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);

                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                }
                if (chkXL.Checked)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;
                    p.Talla = 5;
                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);

                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                }
                if (chkXXL.Checked)
                {
                    p = new Productos();

                    p.NombreProducto = txtProducto.Text;
                    p.Marca = (int)cboMarcas.SelectedValue;
                    p.Precio = Convert.ToDouble(txtPrecio.Text);
                    p.Rubro = (int)cboRubros.SelectedValue;
                    p.TipoPrenda = (int)cboTipoPrenda.SelectedValue;
                    p.Descripcion = txtDescripcion.Text;
                    p.Genero = (int)cboGeneros.SelectedValue;
                    p.Talla = 6;
                    p.NombreGenero = objetoBaseDatos.ObtenerNombreGenero(p.Genero);
                    p.NombreMarca = objetoBaseDatos.ObtenerNombreMarca(p.Marca);

                    listaProductos.Add(p);
                    lstProductos.Items.Add(p);
                }
            }
           
        }

        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return false;
            }

            if (txtProducto.TextLength < 3)
            {
                MessageBox.Show("El nombre del producto debe tener al menos 3 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return false;
            }
            if (txtProducto.TextLength > 50)
            {
                MessageBox.Show("El máximo de caracteres es para el nombre del producto es de 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Clear();
                txtProducto.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtProducto.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras, números y espacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //------------------------------------------------------------------------DESCRIPCION----------------------------------------------------------------------

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingresa una descripcion del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (txtDescripcion.TextLength < 3)
            {
                MessageBox.Show("la descripcion debe tener al menos 3 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtDescripcion.TextLength > 70)
            {
                MessageBox.Show("El máximo de caracteres es 70", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Clear();
                txtDescripcion.Focus();
                return false;
            }


            //---------------------------------------------COMBOS-----------------------------------------------------------------------------


            if (cboMarcas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboGeneros.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboRubros.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Rubro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboTipoPrenda.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Prenda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!chkXS.Checked && !chkS.Checked && !chkM.Checked && !chkL.Checked && !chkXL.Checked && !chkXXL.Checked && !checkTodas.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos una talla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //--------------------------------------------------PRECIO-----------------------------------------------------------------

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtPrecio.Text, @"^\d+([,]\d{1,2})?$"))
            {
                MessageBox.Show("El precio debe ser un número positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrecio.TextLength > 50)
            {
                MessageBox.Show("EL limite de caracteres del precio es de 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Clear();
                txtProducto.Focus();
                return false;
            }

            if (!double.TryParse(txtPrecio.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;                                                            // Todas las validaciones fueron exitosas
        }

        private void cargarCampos(int posicion)
        {

            if (posicion >= 0 && posicion < listaProductos.Count)
            {
                Productos p = listaProductos[posicion];
                txtProducto.Text = p.NombreProducto;
                txtDescripcion.Text = p.Descripcion;
                txtPrecio.Text = p.Precio.ToString();
                cboGeneros.SelectedValue = p.Genero;
                cboMarcas.SelectedValue = p.Marca;
                cboRubros.SelectedValue = p.Rubro;
                cboTipoPrenda.SelectedValue = p.TipoPrenda;

                chkXS.Checked = (p.Talla == 1);
                chkS.Checked = (p.Talla == 2);
                chkM.Checked = (p.Talla == 3);
                chkL.Checked = (p.Talla == 4);
                chkXL.Checked = (p.Talla == 5);
                chkXXL.Checked = (p.Talla == 6);


            }

        }

        private void frmCargarProductos_Load(object sender, EventArgs e)
        {

        }

 

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (lstProductos.SelectedIndex != -1)
                {
                    cargarCampos(lstProductos.SelectedIndex);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }





        private void checkTodas_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkTodas.Checked)
            {
                chkXS.Enabled = true;
                chkS.Enabled = true;
                chkM.Enabled = true;
                chkL.Enabled = true;
                chkXL.Enabled = true;
                chkXXL.Enabled = true;
            }
            else
            {
                chkXS.Checked = false;
                chkS.Checked = false;
                chkM.Checked = false;
                chkL.Checked = false;
                chkXL.Checked = false;
                chkXXL.Checked = false;
                chkXS.Enabled = false;
                chkS.Enabled = false;
                chkM.Enabled = false;
                chkL.Enabled = false;
                chkXL.Enabled = false;
                chkXXL.Enabled = false;
            }
        }

        private void butGuardarCamb_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Svp = new ServicioVerProductos(cadena);
                prod.Nombre = txtProducto.Text ;
                prod.Descripcion = txtDescripcion.Text ;
                prod.Precio = Convert.ToDouble(txtPrecio.Text) ;
                prod.IdMarca = (int)cboMarcas.SelectedValue;
                prod.IdGenero = (int)cboGeneros.SelectedValue;
                prod.Idrubro = (int)cboRubros.SelectedValue;
                prod.IdTipoPrenda = (int)cboTipoPrenda.SelectedValue;
                Svp.Editar(prod);
                MessageBox.Show("Producto Actualizado correctamente", "Producto Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);






            }
        }
    }
}
