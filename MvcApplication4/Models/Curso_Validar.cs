using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication4.Models
{
    public class Curso_Validar
    {
        [DisplayName("Código del curso")]
        public int codigo { get; set; }

        [DisplayName("Nombre del Curso")]
        [Required(ErrorMessage="Nombre del curso es reuerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "No más de 30 caracteres")]
        public string nombre { get; set; }

        [DisplayName("Email del Curso")]
        [Required(ErrorMessage =  "Email del curso requerido")]
        [StringLength(50, ErrorMessage = "No más de 50 caracteres")]
        [EmailAddress(ErrorMessage="Email invalido")]
        public string correo { get; set; }

        [DisplayName("Crédito del curso")]
        [Required(ErrorMessage="Número de crédito de curso es requrido")]
        [Range(1,6)]
        public int credito { get; set; }
    }
}