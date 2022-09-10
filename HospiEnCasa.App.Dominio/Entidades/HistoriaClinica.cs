namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>HistoriaClinica</c>
    /// Modela un Historia Clinica en general en el sistema 
    /// </summary>
    public class HistoriaClinica
    {
        public int Id { get; set; }

        public string Identificador { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public int PacienteId {get; set; }
        public Paciente Paciente {get; set; }
        public int MedicoId {get; set; }
        public Medico Medico {get; set; }
        public List<SignoVital> ListaSignosVitales {get; }  = new List<SignoVital>();
        public List<SugerenciaCuidado> ListaSugerencias {get; }  = new List<SugerenciaCuidado>();
    }
}