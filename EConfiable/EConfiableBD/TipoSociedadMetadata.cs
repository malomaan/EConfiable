using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EConfiableBD
{
    [MetadataType(typeof(TipoSociedad.Metadata))]
     public partial class TipoSociedad
    {
        sealed class Metadata
        {
            [DisplayName("Id")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public int tso_id { get; set; }

            [DisplayName("Descripcion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(255)]
            public string tso_descripcion { get; set; }

        }
    }
}
