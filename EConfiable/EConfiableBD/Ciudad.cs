//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EConfiableBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ciudad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudad()
        {
            this.Empresa = new HashSet<Empresa>();
        }
    
        public string ciu_codigo { get; set; }
        public string ciu_nombre { get; set; }
        public Nullable<bool> ciu_predeterminado { get; set; }
        public Nullable<double> ciu_longitud { get; set; }
        public Nullable<double> ciu_latitud { get; set; }
        public string dep_codigo { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> Empresa { get; set; }
    }
}
