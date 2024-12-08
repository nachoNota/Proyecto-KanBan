﻿namespace Proyecto_KanBan.Models
{
    public class Tablero
    {
        private int id;
        private int idUsuario;
        private string nombre;
        private string? descripcion;

        public int Id { get; }
        public int IdUsuario { get ; }
        public string Nombre { get ; set ; }
        public string? Descripcion { get; set; }
    }
}
