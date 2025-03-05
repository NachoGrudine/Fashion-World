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

namespace MenuPrincipalTPI.Presentacion
{
    public partial class frmAcercaDeNosotros : Form
    {
        AccesoDatos DB;
        public frmAcercaDeNosotros(AccesoDatos DB1)
        {
            InitializeComponent();
            DB = DB1;
        }

        private void btnSalirAcercaDe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
