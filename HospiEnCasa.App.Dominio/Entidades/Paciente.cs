namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente en general en el sistema 
    /// </summary>
    public class Paciente : Persona
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Coordenadas { get; set; }
        public string Ciudad { get; set; }
        public string FechaNacimiento { get; set; }
        public int AuxiliarHospitalId {get; set; }
        public  AuxiliarHospital AuxiliarHospital {get; set; }
        public int MedicoId {get; set; }
        public Medico Medico {get; set; }
        public int EnfermeroId {get; set; }
        public Enfermero Enfermero {get; set; }
        public List<HistoriaClinica> ListaHistorias {get; }  = new List<HistoriaClinica>();
        public List<Familiar> ListaFamiliares {get; }  = new List<Familiar>();
    }
}