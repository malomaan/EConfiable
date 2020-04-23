using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EConfiableBD
{
    [MetadataType(typeof(Empresa.Metadata))]
    public partial  class Empresa
    {
        sealed class Metadata
        {
            [DisplayName("Id")]
            [DataType(DataType.Text)]
            public int emp_id { get; set; }

            [DisplayName("NIT")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(20)]
            public string emp_nit { get; set; }

            [DisplayName("DV")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(1)]
            public Nullable<int> emp_digverificacion { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_nombre { get; set; }

            [DisplayName("Direccion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_direccion { get; set; }

            [DisplayName("Ciudad")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(5)]
            public string ciu_codigo { get; set; }

            [DisplayName("Telefonos")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(150)]
            public string emp_telefonos { get; set; }

            [DisplayName("Email")]
            [DataType(DataType.EmailAddress)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_email { get; set; }

            [DisplayName("URL")]
            [DataType(DataType.Url)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_url { get; set; }

            [DisplayName("Logo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(255)]
            public string emp_logotipo { get; set; }

            [DisplayName("Longitud")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<double> emp_longitud { get; set; }

            [DisplayName("Latitud")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<double> emp_latitud { get; set; }

            [DisplayName("NumeroMatricula")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(20)]
            public string emp_nummatricula { get; set; }

            [DisplayName("FechaMatricula")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<System.DateTime> emp_fechamatricula { get; set; }

            [DisplayName("FechaRenovacion")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<System.DateTime> emp_fecharenovacion { get; set; }

            [DisplayName("FechaCancelacion")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<System.DateTime> emp_fechacancelacion { get; set; }

            [DisplayName("FechaVigencia")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<System.DateTime> emp_fechavigencia { get; set; }

            [DisplayName("AñoRenovacion")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> emp_ultanorenovado { get; set; }

            [DisplayName("RUP")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(20)]
            public string emp_rup { get; set; }

            [DisplayName("RUNEOL")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(20)]
            public string emp_runeol { get; set; }

            [DisplayName("RUT")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(20)]
            public string emp_rut { get; set; }

            [DisplayName("Tipo Tres")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> tso_id { get; set; }

            [DisplayName("Tipo Dos")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> tor_id { get; set; }

            [DisplayName("Tipo Uno")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> tcm_id { get; set; }

            [DisplayName("NumeroEmpleados")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> emp_numeroempleados { get; set; }

            [DisplayName("AfiliadoCamaradeComercio")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<bool> emp_afiliadocamcomercio { get; set; }

            [DisplayName("Activa")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<bool> emp_activa { get; set; }

            [DisplayName("Sigla")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_sigla { get; set; }

            [DisplayName("CamaradeComercio")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(255)]
            public string emp_camaracomercio { get; set; }

        }
    }
}
