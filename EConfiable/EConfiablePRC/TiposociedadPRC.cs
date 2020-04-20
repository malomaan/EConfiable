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
    /// Create date: Apr 19 2020  9:34PM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TiposociedadPRC
    {

        TiposociedadBD BDTiposociedad = new TiposociedadBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tso_id;
        string tso_descripcion;

        // Deficinción de propiedades
        public int Tso_id { get; set; }
        public string Tso_descripcion { get; set; }

        public TiposociedadPRC()
        {
            tso_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 19 2020  9:34PM
        /// Método que permite insertar en la tabla Tiposociedad capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tiposociedad_Insert(string tso_descripcion)
        {
            try
            {
                BDTiposociedad.Tiposociedad_Insert(tso_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 19 2020  9:34PM
        /// Método que permite actualizar en la tabla Tiposociedad capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tiposociedad_Update(int tso_id, string tso_descripcion)
        {
            try
            {
                BDTiposociedad.Tiposociedad_Update(tso_id, tso_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 19 2020  9:34PM
        /// Método que permite eliminar en la tabla Tiposociedad capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tiposociedad_Delete(int tso_id)
        {
            try
            {
                BDTiposociedad.Tiposociedad_Delete(tso_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 19 2020  9:34PM
        /// Método que permite listar de la tabla Tiposociedad capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tiposociedad_List_Result> Tiposociedad_List(int? tso_id)
        {
            try
            {
                var Tiposociedad = (from TTiposociedad in BDTiposociedad.Tiposociedad_List(tso_id) select TTiposociedad).ToList();
                return Tiposociedad;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
