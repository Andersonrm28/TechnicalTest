namespace TechnicalTest.Common.Models.Request
{
    public class AddUserRequest
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool Estado { get; set; }
        public string NombreUsuario { get; set; }
    }
}
