using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace habilidades.shared.Entidades
{
    public class Habilidades
    {
        public int Nro_Habilidad { get; set; }

        [Display(Name = "Nombre_Habilidad")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Nombre_Habilidad { get; set; }

        [Display(Name = "Campo_Desarrollo")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Campo_Desarrollo { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Descripcion { get; set; }
    }
}