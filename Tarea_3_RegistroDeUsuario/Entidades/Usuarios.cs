using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Tarea_3_RegistroDeUsuario.Entidades
{
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Clave { get; set; }
        public string Alias { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            FechaIngreso = DateTime.Now;
            Alias = String.Empty;
            Nombre = String.Empty;
            Email = String.Empty;
            Clave = String.Empty;
            RolId = 0;
            Activo = false;
        }
    }

}

