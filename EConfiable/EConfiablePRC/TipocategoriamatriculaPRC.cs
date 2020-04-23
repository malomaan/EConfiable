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
    /// Create date: Apr 23 2020  8:57AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TipocategoriamatriculaPRC
    {

        TipocategoriamatriculaBD BDTipocategoriamatricula = new TipocategoriamatriculaBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tcm_id;
        string tcm_descripcion;

        // Deficinción de propiedades
        public int Tcm_id { get; set; }
        public string Tcm_descripcion { get; set; }

        public TipocategoriamatriculaPRC()
        {
            tcm_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  8:57AM
        /// Método que permite insertar en la tabla Tipocategoriamatricula capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tipocategoriamatricula_Insert(string tcm_descripcion)
        {
            try
            {
                BDTipocategoriamatricula.Tipocategoriamatricula_Insert(tcm_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  8:57AM
        /// Método que permite actualizar en la tabla Tipocategoriamatricula capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tipocategoriamatricula_Update(int tcm_id, string tcm_descripcion)
        {
            try
            {
                BDTipocategoriamatricula.Tipocategoriamatricula_Update(tcm_id, tcm_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  8:57AM
        /// Método que permite eliminar en la tabla Tipocategoriamatricula capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tipocategoriamatricula_Delete(int tcm_id)
        {
            try
            {
                BDTipocategoriamatricula.Tipocategoriamatricula_Delete(tcm_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 23 2020  8:57AM
        /// Método que permite listar de la tabla Tipocategoriamatricula capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tipocategoriamatricula_List_Result> Tipocategoriamatricula_List(int? tcm_id)
        {
            try
            {
                var Tipocategoriamatricula = (from TTipocategoriamatricula in BDTipocategoriamatricula.Tipocategoriamatricula_List(tcm_id) select TTipocategoriamatricula).ToList();
                return Tipocategoriamatricula;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
