using ColegioSanJose.Models;
using System.ComponentModel.DataAnnotations;

namespace ColegioSanJose.Models
{
    public class Materia
    {
        [Key]
        public int MateriaId { get; set; } 

        [Required]
        [Display(Name = "Nombre Materia")]
        public string NombreMateria { get; set; }

        [Required]
        public string Docente { get; set; }

        public ICollection<Expediente> Expedientes { get; set; }
    }
}