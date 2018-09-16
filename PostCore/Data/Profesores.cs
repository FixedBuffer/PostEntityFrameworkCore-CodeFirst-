using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PostCore.Data
{
    public class Profesores
    {
        //Inicializamos el objeto de navegacion virtual de Entity Framework Core
        public Profesores()
        {
            Cursos = new HashSet<Cursos>();
        }
        [Key] //Requiere de añadir using System.ComponentModel.DataAnnotations;
        public int IdProfesor { get; set; } //Clave primaria
        public string Nombre { get; set; }

        //Entity Framewrok Core
        public ICollection<Cursos> Cursos { get; set; } //Objeto de navegación virtual EFC
    }
}
