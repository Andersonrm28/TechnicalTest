using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalTest.Common.Models
{
    public class UserInformationResponse
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string NombreUsuario { get; set; }
        public string FechaCreacion { get; set; }
    }
}
