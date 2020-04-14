using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EConfiableBD
{
    [MetadataType(typeof(Pais.Metadata))]
    public partial class Pais
    {
        sealed class Metadata
        {
            [DisplayName("Codigo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(2)]
            public string pai_codigo { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(255)]
            public string pai_nombre { get; set; }

            [DisplayName("CodigoInternacional")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(2)]
            public string pai_codigointernacional { get; set; }

            [DisplayName("Predeterminado")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<bool> pai_predeterminado { get; set; }
        }


    }
}
