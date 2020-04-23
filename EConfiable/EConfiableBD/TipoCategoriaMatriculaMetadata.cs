using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EConfiableBD
{
    [MetadataType(typeof(TipoCategoriaMatricula.Metadata))]
    public partial class TipoCategoriaMatricula
    {
        sealed class Metadata
        {
            [DisplayName("Id")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public int tcm_id { get; set; }

            [DisplayName("Descripcion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(255)]
            public string tcm_descripcion { get; set; }

        }
    }
}
