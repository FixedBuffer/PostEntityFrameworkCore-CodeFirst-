using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PostCore.Data
{
  public class Alumnos
  {
    [Key]
    public int IdAlumno { get; set; }
    public string Nombre { get; set; }
    public DateTime Nacimiento { get; set; }
    public int IdCurso { get; set; }

    public Cursos Curso { get; set; }
  }
}
