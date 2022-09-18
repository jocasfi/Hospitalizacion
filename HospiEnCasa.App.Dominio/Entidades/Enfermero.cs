using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HospiEnCasa.App.Dominio
{
        /// <summary>Class <c>Enfermero</c>
    /// Modela un Enfermero en general en el sistema 
    /// </summary>
    public class Enfermero : Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage="La Tarjeta Profesional es obligatoria")]
        public string TarjetaProfesional { get; set; }
        public string HorasLaborales { get; set; }
        public List<Paciente> ListaPacientes {get; }  = new List<Paciente>();
    }
}