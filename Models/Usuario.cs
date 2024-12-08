namespace Proyecto_KanBan.Models
{
    public class Usuario
    {
        private int id;
        private int idRol;
        private string nombreUsuario;
        private string password;

        public int Id { get ; }
        public int IdRol { get; }
        public string NombreUsuario { get ; set ; }
        public string Password { get ; set ; }
    }
}
