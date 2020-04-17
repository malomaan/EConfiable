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
    /// Create date: Apr 17 2020 12:25PM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class DepartamentoPRC
    {

        DepartamentoBD BDDepartamento = new DepartamentoBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        string dep_codigo;
        string dep_nombre;
        string pai_codigo;

        // Deficinción de propiedades
        public string Dep_codigo { get; set; }
        public string Dep_nombre { get; set; }
        public string Pai_codigo { get; set; }

        public DepartamentoPRC()
        {
            dep_codigo = "";
            dep_nombre = "";
            pai_codigo = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 17 2020 12:25PM
        /// Método que permite insertar en la tabla Departamento capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Departamento_Insert(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            try
            {
                BDDepartamento.Departamento_Insert(dep_codigo, dep_nombre, pai_codigo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 17 2020 12:25PM
        /// Método que permite actualizar en la tabla Departamento capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Departamento_Update(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            try
            {
                BDDepartamento.Departamento_Update(dep_codigo, dep_nombre, pai_codigo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 17 2020 12:25PM
        /// Método que permite eliminar en la tabla Departamento capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Departamento_Delete(string dep_codigo)
        {
            try
            {
                BDDepartamento.Departamento_Delete(dep_codigo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Apr 17 2020 12:25PM
        /// Método que permite listar de la tabla Departamento capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Departamento_List_Result> Departamento_List(string dep_codigo)
        {
            try
            {
                var Departamento = (from TDepartamento in BDDepartamento.Departamento_List(dep_codigo) select TDepartamento).ToList();
                return Departamento;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
