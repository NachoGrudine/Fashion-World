using MenuPrincipalTPI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Trabajoparte3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MenuPrincipalTPI.Presentacion
{
    public partial class Consultas: Form
    {
        AccesoDatos oBD;
        string consulta;
        public Consultas(string cadena)
        {
            InitializeComponent();
            oBD = new AccesoDatos(cadena);
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            //COnsulta 1
            consulta = "select emp.nombre + ' ' + apellido 'Empleado', cargo 'Cargo', trabajo 'Trabajo', upper(tipo_doc) \r\n+':'+ str(documento) 'Documento', c.descripcion 'Correo', suc.id_sucursal 'Sucursal N°', format(fecha_alta, 'dd/MM/yyyy') 'Fecha \r\nalta'\r\nfrom empleados emp\r\njoin cargos car on emp.id_cargo = car.id_cargo\r\njoin trabajos_empleados tE on emp.id_empleado = tE.id_empleado\r\njoin trabajos t on tE.id_trabajo = t.id_trabajo\r\njoin tipo_docs tD on emp.id_tipo_doc = tD.id_tipo_doc\r\njoin contactos c on emp.id_empleado = c.id_empleado\r\njoin tipos_contacto tC on c.id_tipo_contacto = tC.id_tipo_contacto\r\njoin sucursales suc on emp.id_sucursal = suc.id_sucursal\r\nwhere (cargo like 'Empleado') and (trabajo like 'vend%') and (year(fecha_alta) >= \r\nyear('01/01/2016')) and (tipo_contacto like 'correo electronico') \r\norder by fecha_alta asc;\r\n";
            DataTable tabla1 = oBD.Consulta(consulta);
            dataGridconsulta1.Rows.Clear();
            foreach (DataRow fila in tabla1.Rows)
            {
                dataGridconsulta1.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6]);
            }
            //-----------------------------------------------------------------------


            //Consulta 2
            consulta = " select distinct emp.nombre + ' ' + apellido 'Empleado', upper(tipo_doc) + ': ' + str(documento)\r\n'Documento', upper(tC.tipo_contacto) + ': ' +\r\nc.descripcion 'Correo', upper(tC2.tipo_contacto) + ': ' + c2.descripcion 'Telefono', upper(banco) + ': \r\n'+ cast(nro_cuenta as varchar) 'Numero cuenta', cargo 'Cargo', suc.id_sucursal'Sucursal'\r\nfrom empleados emp\r\njoin sucursales suc on emp.id_sucursal = suc.id_sucursal\r\njoin datos_bancarios dB on emp.id_empleado = dB.id_empleado\r\njoin tipo_docs tD on emp.id_tipo_doc = tD.id_tipo_doc\r\njoin contactos c on emp.id_empleado = c.id_empleado\r\njoin contactos c2 on emp.id_empleado = c2.id_empleado\r\njoin tipos_contacto tC on c.id_tipo_contacto = tC.id_tipo_contacto\r\njoin tipos_contacto tC2 on c2.id_tipo_contacto = tC2.id_tipo_contacto\r\njoin cargos car on emp.id_cargo = car.id_cargo\r\nwhere (cargo like 'Gerente%') and(tC.tipo_contacto like 'correo%') and(tC2.tipo_contacto like\r\n'numer%') order by suc.id_sucursal, Empleado asc;";
            DataTable tabla2 = oBD.Consulta(consulta);

            dataGridView1.Rows.Clear();
            foreach (DataRow fila in tabla2.Rows)
            {
                dataGridView1.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6]);
            }

            //-----------------------------------------------------------------------


            //Consulta 3
            consulta = "SET DATEFORMAT dmy; select top 10 cli.id_cliente 'ID del cliente', nombre + ' ' + apellido 'Cliente', \r\nupper(tC.tipo_contacto) + ': ' +c.descripcion 'Red Social y Usuario',\r\nupper(tC2.tipo_contacto) +': '+ c2.descripcion 'Telefono'\r\nfrom clientes cli \r\njoin contactos c on cli.id_cliente = c.id_cliente\r\njoin contactos c2 on cli.id_cliente = c2.id_cliente\r\njoin tipos_contacto tC on c.id_tipo_contacto = tC.id_tipo_contacto\r\njoin tipos_contacto tC2 on c2.id_tipo_contacto = tC2.id_tipo_contacto\r\nwhere (tC.tipo_contacto like 'Instagram') and (tC2.tipo_contacto like 'numer%') and (cli.id_cliente \r\nnot in (70, 14, 54)) \r\norder by tc.tipo_contacto, c.descripcion asc;";
            DataTable tabla3 = oBD.Consulta(consulta);
            dataGridView2.Rows.Clear();
            foreach (DataRow fila in tabla3.Rows)
            {
                dataGridView2.Rows.Add(fila[0], fila[1], fila[2], fila[3]);
            }

            //-----------------------------------------------------------------------


            //Consulta 4
            consulta = "SET DATEFORMAT dmy; select top 30 nombre + ' ' + apellido 'Cliente', upper(tipo_doc) +':'+ str(documento) 'Documento', \r\nupper(tC.tipo_contacto) +': '+\r\nc.descripcion 'Correo', upper(tC2.tipo_contacto) +': '+ c2.descripcion 'Telefono', upper(calle) +':'+ \r\nstr(altura) 'Calle y Numero'\r\nfrom clientes cli \r\njoin tipo_docs tD on cli.id_tipo_doc = tD.id_tipo_doc\r\njoin calles ca on cli.id_calle = ca.id_calle\r\njoin contactos c on cli.id_cliente = c.id_cliente\r\njoin contactos c2 on cli.id_cliente = c2.id_cliente\r\njoin tipos_contacto tC on c.id_tipo_contacto = tC.id_tipo_contacto\r\njoin tipos_contacto tC2 on c2.id_tipo_contacto = tC2.id_tipo_contacto\r\nwhere (tC.tipo_contacto like 'correo%') and (tC2.tipo_contacto like 'numer%') and \r\n(documento between 20000000 and 40000000) and (tipo_doc like 'DNI') \r\norder by documento asc;";
            DataTable tabla4 = oBD.Consulta(consulta);

            dataGridView3.Rows.Clear();
            foreach (DataRow fila in tabla4.Rows)
            {
                dataGridView3.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4]);
            }

            //-----------------------------------------------------------------------


            //Consulta 5
            consulta = "SET DATEFORMAT dmy; select fac.id_factura 'ID Factura', cli.nombre + ' ' + apellido 'Cliente', format(fecha_hora_venta, \r\n'dd/MM/yyyy') 'Fecha y hora',\r\nsuc.id_sucursal 'Sucursal', dF.id_detalle_factura 'ID detalle', pr.nombre 'Producto',\r\nupper(forma_pago) 'Forma de pago'\r\nfrom facturas fac\r\nleft join detalle_facturas dF on fac.id_factura = dF.id_factura\r\njoin productos pr on dF.id_producto = pr.id_producto\r\njoin clientes cli on fac.id_cliente = cli.id_cliente\r\njoin sucursales suc on fac.id_sucursal = suc.id_sucursal\r\njoin formas_pago fP on fac.id_forma_pago = fP.id_forma_pago\r\nwhere (suc.id_sucursal = 1) and (fac.fecha_hora_venta between '01/03/2024' and '17/03/2024') \r\norder by fac.fecha_hora_venta asc;";
            DataTable tabla5 = oBD.Consulta(consulta);
            dataGridView4.Rows.Clear();
            foreach (DataRow fila in tabla5.Rows)
            {
                dataGridView4.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6]);
            }

            //-----------------------------------------------------------------------


            //Consulta 6
            consulta = "SET DATEFORMAT dmy; select distinct cli.id_cliente 'ID Cliente',nombre + ' ' + apellido 'Cliente', fac.id_factura 'ID \r\nFactura',\r\nformat(fecha_hora_venta, 'dd/MM/yyyy') 'Fecha y hora', upper(forma_pago) 'Formas de pago'\r\nfrom facturas fac \r\njoin detalle_facturas dF on fac.id_factura = dF.id_factura\r\njoin clientes cli on fac.id_cliente = cli.id_cliente\r\njoin formas_pago fP on fac.id_forma_pago = fP.Id_forma_pago\r\nwhere (cli.id_cliente not between 22 and 51) and month(fac.fecha_hora_venta) = \r\nmonth(getdate())- 2 \r\norder by fac.id_factura desc;";
            DataTable tabla6 = oBD.Consulta(consulta);

            dataGridView5.Rows.Clear();
            foreach (DataRow fila in tabla6.Rows)
            {
                dataGridView5.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4]);
            }

            //-----------------------------------------------------------------------


            //Consulta 7
            consulta = "SET DATEFORMAT dmy; select nombre 'Producto', descripcion 'Descripcion','$'+str(precio) 'Valor', upper(marca) 'Marca', \r\nupper(rubro) 'Rubro'\r\nfrom productos pr\r\njoin marcas marc on pr.id_marca = marc.id_marca\r\njoin tallas ta on pr.id_talla = ta.id_talla\r\njoin rubros rub on pr.id_rubro = rub.id_rubro\r\nwhere (talla = 'XL') and ((pr.precio > 200000) or (marc.marca like '%e' and pr.precio < 40000))\r\norder by marca, pr.precio asc;";
            DataTable tabla7 = oBD.Consulta(consulta);
            dataGridView6.Rows.Clear();
            foreach (DataRow fila in tabla7.Rows)
            {
                dataGridView6.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4]);
            }

            //-----------------------------------------------------------------------


            //Consulta 8
            consulta = "SET DATEFORMAT dmy; select nombre 'Producto', upper(descripcion) 'Descripcion', talla 'Tallas', '$'+str(precio) 'Valor',\r\nmarca 'Marca', rubro 'Rubro', cant_actual 'Stock actual', cant_minima 'Stock minimo',\r\ncant_maxima 'Stock maximo'\r\nfrom productos pr\r\njoin stocks sto on pr.id_producto=sto.id_producto\r\njoin tallas ta on pr.id_talla=ta.id_talla\r\njoin marcas marc on pr.id_marca=marc.id_marca\r\njoin rubros rub on pr.id_rubro=rub.id_rubro\r\nwhere (cant_actual < 4 and precio <=20000) or (marc.marca='Puma' and rubro='Ropa Casual' \r\nand precio between 150000 and 200000) \r\norder by cant_actual asc, ta.id_talla asc;";
            DataTable tabla8 = oBD.Consulta(consulta);

            dataGridView7.Rows.Clear();
            foreach (DataRow fila in tabla8.Rows)
            {
                dataGridView7.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8]);
            }





        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridconsulta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
