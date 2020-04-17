using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EConfiableBD
{
    [MetadataType(typeof(Departamento.Metadata))]
    public partial class Departamento
    {
        sealed class Metadata
        {
            [DisplayName("Codigo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(5)]
            public string dep_codigo { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string dep_nombre { get; set; }

            [DisplayName("Pais")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(2)]
            public string pai_codigo { get; set; }


        }
    }
}
