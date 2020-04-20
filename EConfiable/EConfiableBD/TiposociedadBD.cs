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
    /// Create date: Apr 19 2020  9:33PM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TiposociedadBD
    {

        EConfiableEntities BD = new EConfiableEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tso_id;
        string tso_descripcion;

        // Deficinción de propiedades
        public int Tso_id { get; set; }
        public string Tso_descripcion { get; set; }

        public TiposociedadBD()
        {
            tso_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 19 2020  9:33PM
        /// Método que permite insertar en la tabla Tiposociedad capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tiposociedad_Insert(string tso_descripcion)
        {
            try
            {
                BD.Tiposociedad_Insert(tso_descripcion);
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
        /// Create date: Apr 19 2020  9:33PM
        /// Método que permite actualizar en la tabla Tiposociedad capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tiposociedad_Update(int tso_id, string tso_descripcion)
        {
            try
            {
                BD.Tiposociedad_Update(tso_id, tso_descripcion);
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
        /// Create date: Apr 19 2020  9:33PM
        /// Método que permite eliminar en la tabla Tiposociedad capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tiposociedad_Delete(int tso_id)
        {
            try
            {
                BD.Tiposociedad_Delete(tso_id);
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
        /// Create date: Apr 19 2020  9:33PM
        /// Método que permite listar de la tabla Tiposociedad capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tiposociedad_List_Result> Tiposociedad_List(int? tso_id)
        {
            try
            {
                var Tiposociedad = (from TTiposociedad in BD.Tiposociedad_List(tso_id) select TTiposociedad).ToList();
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
