namespace HospiEnCasa.App.Dominio
{
        /// <summary>Class <c>Medico</c>
    /// Modela un Medico en general en el sistema 
    /// </summary>
    public class Medico : Persona
    {
        public int Id { get; set; }
        public string Especialidad { get; set; }
        public string RegRethus { get; set; }
        public List<Paciente> ListaPacientes {get; }  = new List<Paciente>();
        public List<HistoriaClinica> ListaHistorias { get; } = new List<HistoriaClinica>();
    }
}