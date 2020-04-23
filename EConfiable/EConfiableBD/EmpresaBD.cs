using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EConfiableBD
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Apr 23 2020  9:54AM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class EmpresaBD
    {

        EConfiableEntities BD = new EConfiableEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int emp_id;
        string emp_nit;
        int emp_digverificacion;
        string emp_nombre;
        string emp_direccion;
        string ciu_codigo;
        string emp_telefonos;
        string emp_email;
        string emp_url;
        string emp_logotipo;
        double emp_longitud;
        double emp_latitud;
        string emp_nummatricula;
        DateTime emp_fechamatricula;
        DateTime emp_fecharenovacion;
        DateTime emp_fechacancelacion;
        DateTime emp_fechavigencia;
        int emp_ultanorenovado;
        string emp_rup;
        string emp_runeol;
        string emp_rut;
        int tso_id;
        int tor_id;
        int tcm_id;
        int emp_numeroempleados;
        bool emp_afiliadocamcomercio;
        bool emp_activa;
        string emp_sigla;
        string emp_camaracomercio;

        // Deficinción de propiedades
        public int Emp_id { get; set; }
        public string Emp_nit { get; set; }
        public int Emp_digverificacion { get; set; }
        public string Emp_nombre { get; set; }
        public string Emp_direccion { get; set; }
        public string Ciu_codigo { get; set; }
        public string Emp_telefonos { get; set; }
        public string Emp_email { get; set; }
        public string Emp_url { get; set; }
        public string Emp_logotipo { get; set; }
        public double Emp_longitud { get; set; }
        public double Emp_latitud { get; set; }
        public string Emp_nummatricula { get; set; }
        public DateTime Emp_fechamatricula { get; set; }
        public DateTime Emp_fecharenovacion { get; set; }
        public DateTime Emp_fechacancelacion { get; set; }
        public DateTime Emp_fechavigencia { get; set; }
        public int Emp_ultanorenovado { get; set; }
        public string Emp_rup { get; set; }
        public string Emp_runeol { get; set; }
        public string Emp_rut { get; set; }
        public int Tso_id { get; set; }
        public int Tor_id { get; set; }
        public int Tcm_id { get; set; }
        public int Emp_numeroempleados { get; set; }
        public bool Emp_afiliadocamcomercio { get; set; }
        public bool Emp_activa { get; set; }
        public string Emp_sigla { get; set; }
        public string Emp_camaracomercio { get; set; }

        public EmpresaBD()
        {
            emp_nit = "";
            emp_digverificacion = 0;
            emp_nombre = "";
            emp_direccion = "";
            ciu_codigo = "";
            emp_telefonos = "";
            emp_email = "";
            emp_url = "";
            emp_logotipo = "";
            emp_longitud = 0;
            emp_latitud = 0;
            emp_nummatricula = "";
            emp_fechamatricula = DateTime.Now;
            emp_fecharenovacion = DateTime.Now;
            emp_fechacancelacion = DateTime.Now;
            emp_fechavigencia = DateTime.Now;
            emp_ultanorenovado = 0;
            emp_rup = "";
            emp_runeol = "";
            emp_rut = "";
            tso_id = 0;
            tor_id = 0;
            tcm_id = 0;
            emp_numeroempleados = 0;
            emp_afiliadocamcomercio = true;
            emp_activa = true;
            emp_sigla = "";
            emp_camaracomercio = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  9:54AM
        /// Método que permite insertar en la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Empresa_Insert(string emp_nit, int emp_digverificacion, string emp_nombre, string emp_direccion, string ciu_codigo, string emp_telefonos, string emp_email, string emp_url, string emp_logotipo, double emp_longitud, double emp_latitud, string emp_nummatricula, DateTime emp_fechamatricula, DateTime emp_fecharenovacion, DateTime emp_fechacancelacion, DateTime emp_fechavigencia, int emp_ultanorenovado, string emp_rup, string emp_runeol, string emp_rut, int tso_id, int tor_id, int tcm_id, int emp_numeroempleados, bool emp_afiliadocamcomercio, bool emp_activa, string emp_sigla, string emp_camaracomercio)
        {
            try
            {
                BD.Empresa_Insert(emp_nit, emp_digverificacion, emp_nombre, emp_direccion, ciu_codigo, emp_telefonos, emp_email, emp_url, emp_logotipo, emp_longitud, emp_latitud, emp_nummatricula, emp_fechamatricula, emp_fecharenovacion, emp_fechacancelacion, emp_fechavigencia, emp_ultanorenovado, emp_rup, emp_runeol, emp_rut, tso_id, tor_id, tcm_id, emp_numeroempleados, emp_afiliadocamcomercio, emp_activa, emp_sigla, emp_camaracomercio);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  9:54AM
        /// Método que permite actualizar en la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Empresa_Update(int emp_id, string emp_nit, int emp_digverificacion, string emp_nombre, string emp_direccion, string ciu_codigo, string emp_telefonos, string emp_email, string emp_url, string emp_logotipo, double emp_longitud, double emp_latitud, string emp_nummatricula, DateTime emp_fechamatricula, DateTime emp_fecharenovacion, DateTime emp_fechacancelacion, DateTime emp_fechavigencia, int emp_ultanorenovado, string emp_rup, string emp_runeol, string emp_rut, int tso_id, int tor_id, int tcm_id, int emp_numeroempleados, bool emp_afiliadocamcomercio, bool emp_activa, string emp_sigla, string emp_camaracomercio)
        {
            try
            {
                BD.Empresa_Update(emp_id, emp_nit, emp_digverificacion, emp_nombre, emp_direccion, ciu_codigo, emp_telefonos, emp_email, emp_url, emp_logotipo, emp_longitud, emp_latitud, emp_nummatricula, emp_fechamatricula, emp_fecharenovacion, emp_fechacancelacion, emp_fechavigencia, emp_ultanorenovado, emp_rup, emp_runeol, emp_rut, tso_id, tor_id, tcm_id, emp_numeroempleados, emp_afiliadocamcomercio, emp_activa, emp_sigla, emp_camaracomercio);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  9:54AM
        /// Método que permite eliminar en la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Empresa_Delete(int emp_id)
        {
            try
            {
                BD.Empresa_Delete(emp_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  9:54AM
        /// Método que permite listar de la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Empresa_List_Result> Empresa_List(int emp_id)
        {
            try
            {
                var Empresa = (from TEmpresa in BD.Empresa_List(emp_id) select TEmpresa).ToList();
                return Empresa;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE

}
