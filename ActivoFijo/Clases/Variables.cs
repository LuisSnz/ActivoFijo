using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace ActivoFijo.Clases
{
    class Variables
    {
        
        //String de conexion a la base de datos
        //public static string scon = ("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
        public static string scon;
        //Variable de busqueda de grid
        public static string ConsultaBuscar;
        //familias
        public static string IDFamilia;
        public static string DescripcionFamilia;
        //marcas
        public static string IDMarcas;
        public static string DescripcionMarcas;
        //areas
        public static string IdAreas;
        public static string DescripcionAreas;
        //Departamentos
        public static string IdDeptos;
        public static string DescripcionDeptos;
        public static string DireccionDeptos;
        public static string SubDeptos;
        //Empleados
        public static string IdEmpleados;
        public static string EmpleadosBaja;
        public static string EmpleadosPliegos;
        public static string EmpleadosNoPliegos;
        public static string EmpleadosJefe;
        public static string EmpleadosNombre;
        public static string EmpleadosDepto;
        public static string EmpleadosLicencia;
        public static string EmpleadosFecha;
        public static string EmpleadosNombreP;
        public static string EmpleadosNumJefe;
        //proveedores
        public static string IdProveedores;
        //SubDireccion
        public static string IdSubD;
        public static string DescripcionSubD;
        //Bienes Dados de Baja
        public static string IdBienesB;
        public static string BienesBMotivoBaja;
        public static string BienesBObservacion;
        public static string BienesBValor;
        public static string MotivoBaja;
        //CatArticulos
        public static string IdArticulo;
        public static string ArticuloDescripcion;
        public static string ArticuloContrato;
        public static string ArticuloInventariable;
        public static string ArticuloFamilia;
        public static string ArticuloMedida;
        public static string ArticuloTipo;
        //Bienes
        public static string IdBienes;
        public static string BienesEtiqueta;
        public static string BienesSerie;
        public static string BienesOrdenCompra;
        public static string BienesFactura;
        public static string BienesTotal;
        public static string BienesFamilia;
        public static string BienesDescripcionArticulo;
        public static string BienesEmpleado;
        public static string BienesDepartamento;
        public static string BienesConsumible;
        public static string BienesObservacion;
        //BienesSF
        public static string IdBienesSF;
        public static string BienesSFEtiqueta;
        public static string BienesSFSerie;
        public static string BienesSFOrdenCompra;
        public static string BienesSFTotal;
        public static string BienesSFFamilia;
        public static string BienesSFDescripcionArticulo;
        public static string BienesSFEmpleado;
        public static string BienesSFDepartamento;
        public static string BienesSFConsumible;
        public static string BienesSFObservacion;
        //Imrimir Etiquetas
        public static string IEtiqueta;
        public static string IArticulo;
        //Login
        public static string Usuario;
        public static string Contraseña;
        public static string VUsuario;
        public static string VContraseña;
        //Configurar impresora
        public static string ConfImpresora;
        //Escala de grids
        public static int GridWidth;
        public static int GridHeight;
        //Reportes
        public static string Total;
        //Cambio Por Bien
        public static string IdCambio;
        public static string EtiquetaCambio;
        public static string OrdenCambio;
        public static string ArticuloCambio;
        public static string ObservacionesCambio;
        public static string ResguardoCambio;
        public static string DeptoCambio;
        //Metodos de insercion
        public static string Error;
        public static bool ErrorB;
    }
}
