namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Auxiliar</c>
    /// Modela un Auxiliar Hospital en general en el sistema 
    /// </summary>
    public class AuxiliarHospital : Persona
    {
        public int Id { get; set; }
        public List<Paciente> ListaPacientes {get; }  = new List<Paciente>();
    }
}