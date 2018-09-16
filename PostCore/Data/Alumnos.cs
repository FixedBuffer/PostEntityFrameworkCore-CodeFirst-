using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PostCore.Data
{
    public class Alumnos
    {
        [Key] //Requiere de añadir using System.ComponentModel.DataAnnotations;
        public int IdAlumno { get; set; } //Clave primaria
        public string Nombre { get; set; } 
        public DateTime Nacimiento { get; set; }
        public int IdCurso { get; set; } //Campo clave foranea

        //Entity Framewrok Core
        public Cursos Curso { get; set; } //Objeto de navegación virtual EFC
    }
}
