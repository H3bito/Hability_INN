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
    public class pedido
    {
        public int Id { get; set; }

        [Display(Name = "id_pedido")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string id_pedido { get; set; }

        [Display(Name = "requerimiento")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string requerimiento { get; set; }

        [Display(Name = "fecha_creacion")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string fecha_creacion { get; set; }

        [Display(Name = "fecha_terminacion")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string fecha_terminacion { get; set; }

    }
}