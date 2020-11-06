using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalTest.Web.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El usuario no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El usuario es requerido.")]
        public string Usuarioo { get; set; }
        [MaxLength(20, ErrorMessage = "La {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "El estado es requerido.")]
        public bool Estado { get; set; }
        [MaxLength(100, ErrorMessage = "El nombre del usuario no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        public string NombreUsuario { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; }
    }
}
