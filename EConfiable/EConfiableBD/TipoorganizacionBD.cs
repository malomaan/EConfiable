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
    /// Create date: Apr 22 2020  8:47PM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TipoorganizacionBD
    {
        EConfiableEntities BD = new EConfiableEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tor_id;
        string tor_descripcion;

        // Deficinción de propiedades
        public int Tor_id { get; set; }
        public string Tor_descripcion { get; set; }

        public TipoorganizacionBD()
        {
            tor_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 22 2020  8:47PM
        /// Método que permite insertar en la tabla Tipoorganizacion capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tipoorganizacion_Insert(string tor_descripcion)
        {
            try
            {
                BD.Tipoorganizacion_Insert(tor_descripcion);
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
        /// Create date: Apr 22 2020  8:47PM
        /// Método que permite actualizar en la tabla Tipoorganizacion capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tipoorganizacion_Update(int tor_id, string tor_descripcion)
        {
            try
            {
                BD.Tipoorganizacion_Update(tor_id, tor_descripcion);
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
        /// Create date: Apr 22 2020  8:47PM
        /// Método que permite eliminar en la tabla Tipoorganizacion capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tipoorganizacion_Delete(int tor_id)
        {
            try
            {
                BD.Tipoorganizacion_Delete(tor_id);
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
        /// Create date: Apr 22 2020  8:47PM
        /// Método que permite listar de la tabla Tipoorganizacion capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tipoorganizacion_List_Result> Tipoorganizacion_List(int? tor_id)
        {
            try
            {
                var Tipoorganizacion = (from TTipoorganizacion in BD.Tipoorganizacion_List(tor_id) select TTipoorganizacion).ToList();
                return Tipoorganizacion;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
