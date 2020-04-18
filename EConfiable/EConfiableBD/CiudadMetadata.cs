using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EConfiableBD
{
    [MetadataType(typeof(Ciudad.Metadata))]
    public partial class Ciudad
    {
        sealed class Metadata
        {
            [DisplayName("Codigo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(5)]
            public string ciu_codigo { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string ciu_nombre { get; set; }

            [DisplayName("Predeterminado")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<bool> ciu_predeterminado { get; set; }

            [DataType(DataType.Text)]
            [DisplayName("Longitud")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<double> ciu_longitud { get; set; }

            [DataType(DataType.Text)]
            [DisplayName("Latitud")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<double> ciu_latitud { get; set; }

            [DisplayName("Departamento")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(5)]
            public string dep_codigo { get; set; }

        }
    }
}
