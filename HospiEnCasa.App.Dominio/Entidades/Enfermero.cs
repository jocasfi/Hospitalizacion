//System.ComponentModel.DataAnnotations;
//System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio

{
        /// <summary>Class <c>Enfermero</c>
    /// Modela un Enfermero en general en el sistema 
    /// </summary>
    public class Enfermero : Persona
    {
        public int Id { get; set; }
        //[Required(ErrorMessage="El Campo es obligatorio")]
        public string TarjetaProfesional { get; set; }
        //[Required(ErrorMessage="El Campo es obligatorio")]
        public string HorasLaborales { get; set; }
        public List<Paciente> ListaPacientes {get; }  = new List<Paciente>();
    }
}