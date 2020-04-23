using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EConfiableBD;

namespace EConfiablePRC
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Apr 22 2020  8:52PM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TipoorganizacionPRC
    {

        TipoorganizacionBD BDTipoorganizacion = new TipoorganizacionBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tor_id;
        string tor_descripcion;

        // Deficinción de propiedades
        public int Tor_id { get; set; }
        public string Tor_descripcion { get; set; }

        public TipoorganizacionPRC()
        {
            tor_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 22 2020  8:52PM
        /// Método que permite insertar en la tabla Tipoorganizacion capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tipoorganizacion_Insert(string tor_descripcion)
        {
            try
            {
                BDTipoorganizacion.Tipoorganizacion_Insert(tor_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 22 2020  8:52PM
        /// Método que permite actualizar en la tabla Tipoorganizacion capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tipoorganizacion_Update(int tor_id, string tor_descripcion)
        {
            try
            {
                BDTipoorganizacion.Tipoorganizacion_Update(tor_id, tor_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 22 2020  8:52PM
        /// Método que permite eliminar en la tabla Tipoorganizacion capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tipoorganizacion_Delete(int tor_id)
        {
            try
            {
                BDTipoorganizacion.Tipoorganizacion_Delete(tor_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 22 2020  8:52PM
        /// Método que permite listar de la tabla Tipoorganizacion capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tipoorganizacion_List_Result> Tipoorganizacion_List(int tor_id)
        {
            try
            {
                var Tipoorganizacion = (from TTipoorganizacion in BDTipoorganizacion.Tipoorganizacion_List(tor_id) select TTipoorganizacion).ToList();
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
