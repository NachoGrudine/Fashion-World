using MenuPrincipalTPI.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipalTPI.Negocio
{
    public class CargarDatosServicio
    {
        CargarDatosDAO oDao;
        public CargarDatosServicio(string cadena)
        {
            oDao = new CargarDatosDAO(cadena);
        }
        public List<Marcas> TraerMarcas()
        {
            return oDao.RecuperarMarcas();
        }
        public List<TiposPrendas> TraerPrendas()
        {
            return oDao.RecuperarTiposPrenda();
        }
        public List<Rubros> TraerRubros()
        {
            return oDao.RecuperarRubros();
        }

        public void AgregarMarca(Marcas marca)
        {
            oDao.AgregarMarca(marca.Marca);
        }

        public void AgregarRubro(Rubros rubro)
        {
            oDao.AgregarRubro(rubro.Rubro);
        }

        public void AgregarTipoPrenda(TiposPrendas tipoPrenda)
        {
            oDao.AgregarTipoPrenda(tipoPrenda.TipoPrenda);
        }
        public bool ExisteValorEnTablas(string nombreTabla, string columna, string valor)
        {
            return oDao.ExisteValorEnTabla(nombreTabla, columna, valor);
        }
    }
}
