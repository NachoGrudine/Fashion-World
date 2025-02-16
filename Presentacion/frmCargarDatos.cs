using MenuPrincipalTPI.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipalTPI.Presentacion
{
    public partial class frmCargarDatos : Form
    {
        CargarDatosServicio oServicio;
        public frmCargarDatos(string cadena)
        {
            InitializeComponent();
            oServicio = new CargarDatosServicio(cadena);
            deshabilitar();
        }

        private void frmCargarDatos_Load(object sender, EventArgs e)
        {
            chequearBotones();
        }

        // Metodo para deshabilitar controles del formulario
        private void deshabilitar()
        {
            txtNuevoValor.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnCargar.Enabled = false;
        }

        // Metodo para habilitar controles del formulario
        private void habilitar()
        {
            BtnCargar.Enabled = true;
            BtnCancelar.Enabled = true;
            ChkTiposPrenda.Enabled = true;
            ChkRubro.Enabled = true;
            ChkMarcas.Enabled = true;
        }

        // Metodo para habilitar checkboxes del formulario
        private void habilitarChk()
        {
            ChkMarcas.Enabled = true;
            ChkTiposPrenda.Enabled = true;
            ChkRubro.Enabled = true;
        }

        // Metodo para limpiar los controles del formulario
        private void LimpiarFormulario()
        {
            txtNuevoValor.Text = "";
            ChkMarcas.Checked = false;
            ChkRubro.Checked = false;
            ChkTiposPrenda.Checked = false;
            LstCambios.ClearSelected();
        }

        // Metodo para actualizar el ListBox con datos de la base de datos
        private void ActualizarListBox()
        {
            LstCambios.Items.Clear();

            if (ChkMarcas.Checked)
            {
                List<Marcas> lista = oServicio.TraerMarcas();
                foreach (var marca in lista)
                {
                    LstCambios.Items.Add(marca.Marca);
                }
            }
            else if (ChkRubro.Checked)
            {
                List<Rubros> lista = oServicio.TraerRubros();
                foreach (var rubro in lista)
                {
                    LstCambios.Items.Add(rubro.Rubro);
                }
            }
            else if (ChkTiposPrenda.Checked)
            {
                List<TiposPrendas> lista = oServicio.TraerPrendas();
                foreach (var tipoPrenda in lista)
                {
                    LstCambios.Items.Add(tipoPrenda.TipoPrenda);
                }
            }
        }

        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(txtNuevoValor.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoValor.Focus();
                return false;
            }
            if (char.IsLower(txtNuevoValor.Text[0]))
            {
                MessageBox.Show("La primera letra del valor debe estar en mayúscula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevoValor.Focus();
                return false;
            }
            if (txtNuevoValor.TextLength < 5 && !ChkMarcas.Checked)
            {
                MessageBox.Show("El valor debe tener al menos 5 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoValor.Focus();
                return false;
            }
            if (txtNuevoValor.TextLength > 50)
            {
                MessageBox.Show("El máximo de caracteres es 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoValor.Clear();
                txtNuevoValor.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNuevoValor.Text, @"^[a-zA-Z\s]+$") && !ChkMarcas.Checked)
            {
                MessageBox.Show("El valor solo debe contener letras y espacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tabla = string.Empty;
            string columna = string.Empty;

            if (ChkMarcas.Checked)
            {
                tabla = "marcas";
                columna = "marca";
            }
            else if (ChkRubro.Checked)
            {
                tabla = "rubros";
                columna = "rubro";
            }
            else if (ChkTiposPrenda.Checked)
            {
                tabla = "tipos_prenda";
                columna = "tipo_prenda";
            }

            if (oServicio.ExisteValorEnTablas(tabla, columna, txtNuevoValor.Text))
            {
                MessageBox.Show("El valor ya existe en la base de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoValor.Focus();
                return false;
            }

            if (ChkMarcas.Checked)
            {
                if (txtNuevoValor.TextLength < 2)
                {
                    MessageBox.Show("El valor debe tener al menos 2 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNuevoValor.Focus();
                    return false;
                }
            }

            return true;
        }

        private void chequearBotones()
        {
            if (ChkMarcas.Checked)
            {
                ChkRubro.Enabled = false;
                ChkTiposPrenda.Enabled = false;
                txtNuevoValor.Enabled = true;
                ActualizarListBox();
            }
            else if (ChkRubro.Checked)
            {
                ChkMarcas.Enabled = false;
                ChkTiposPrenda.Enabled = false;
                txtNuevoValor.Enabled = true;
                ActualizarListBox();
            }
            else if (ChkTiposPrenda.Checked)
            {
                ChkMarcas.Enabled = false;
                ChkRubro.Enabled = false;
                txtNuevoValor.Enabled = true;
                ActualizarListBox();
            }
            else
            {
                // Habilitar todos los checkboxes si ninguno está marcado
                ChkMarcas.Enabled = true;
                ChkRubro.Enabled = true;
                ChkTiposPrenda.Enabled = true;
                txtNuevoValor.Enabled = false;
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                string tabla = string.Empty;

                if (ChkMarcas.Checked)
                {
                    tabla = "Marca";
                }
                else if (ChkRubro.Checked)
                {
                    tabla = "Rubro";
                }
                else if (ChkTiposPrenda.Checked)
                {
                    tabla = "Tipo de Prenda";
                }

                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas registrar '{txtNuevoValor.Text}' en la tabla {tabla}?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (ChkMarcas.Checked)
                    {
                        Marcas marca = new Marcas
                        {
                            Marca = txtNuevoValor.Text
                        };
                        oServicio.AgregarMarca(marca);
                    }
                    else if (ChkRubro.Checked)
                    {
                        Rubros rubro = new Rubros
                        {
                            Rubro = txtNuevoValor.Text
                        };
                        oServicio.AgregarRubro(rubro);
                    }
                    else if (ChkTiposPrenda.Checked)
                    {
                        TiposPrendas tipoPrenda = new TiposPrendas
                        {
                            TipoPrenda = txtNuevoValor.Text
                        };
                        oServicio.AgregarTipoPrenda(tipoPrenda);
                    }
                    MessageBox.Show("Registro agregado correctamente.");
                    LimpiarFormulario();
                    ActualizarListBox();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LstCambios.Items.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkMarcas_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkMarcas.Checked)
            {
                LstCambios.Items.Clear();
                deshabilitar();
                habilitarChk();
            }
            if (ChkMarcas.Checked)
            {
                chequearBotones();
                ActualizarListBox();
                habilitar();
                txtNuevoValor.Focus();
                ChkTiposPrenda.Enabled = false;
                ChkRubro.Enabled = false;
            }
        }

        private void ChkTiposPrenda_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkTiposPrenda.Checked)
            {
                deshabilitar();
                LstCambios.Items.Clear();
                habilitarChk();
            }
            if (ChkTiposPrenda.Checked)
            {
                chequearBotones();
                ActualizarListBox();
                habilitar();
                txtNuevoValor.Focus();
                ChkMarcas.Enabled = false;
                ChkRubro.Enabled = false;
            }
        }

        private void ChkRubro_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkRubro.Checked)
            {
                deshabilitar();
                LstCambios.Items.Clear();
                habilitarChk();
            }
            if (ChkRubro.Checked)
            {
                chequearBotones();
                ActualizarListBox();
                habilitar();
                txtNuevoValor.Focus();
                ChkTiposPrenda.Enabled = false;
                ChkMarcas.Enabled = false;
            }
        }

    }
}
