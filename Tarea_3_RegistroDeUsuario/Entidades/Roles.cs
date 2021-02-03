using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_RegistroDeUsuario.Entidades
{
    public class Roles
    {
        [Key]
        public int rolesId { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }


        public Roles()
        {
            rolesId = 0;
            fechaCreacion = DateTime.Now;
            descripcion = string.Empty;

        }

    }
}
