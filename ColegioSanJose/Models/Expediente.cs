using ColegioSanJose.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioSanJose.Models
{
    public class Expediente
    {
        [Key]
        public int ExpedienteId { get; set; }

        [Display(Name = "Alumno")]
        [ForeignKey("Alumno")]
        public int Alumnoid { get; set; }

        [Display(Name = "Materia")]
        [ForeignKey("Materia")]
        public int MateriaId { get; set; }

        [Required]
        [Range(0.0, 10.0)]
        public decimal NotaFinal { get; set; }

        public string? Observaciones { get; set; } 
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
    }
}