namespace HospiEnCasa.App.Dominio
{
        /// <summary>Class <c>Familiar</c>
    /// Modela un Familiar en general en el sistema 
    /// </summary>
    public class Familiar : Persona
    {
        public int Id { get; set; }
        public string Parentesco { get; set; }
        public string Email { get; set; }
        public int PacienteId {get; set; }
        public Paciente Paciente {get; set; }
    }
}