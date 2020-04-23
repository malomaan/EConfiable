using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EConfiableBD
{
    [MetadataType(typeof(TipoOrganizacion.Metadata))]
    public partial class TipoOrganizacion
    {
        sealed class Metadata
        {

            [DisplayName("Id")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public int tor_id { get; set; }

            [DisplayName("Descripcion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(255)]
            public string tor_descripcion { get; set; }

        }
    }
}
