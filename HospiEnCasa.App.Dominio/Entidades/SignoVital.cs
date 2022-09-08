namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela un Signos Vitales en general en el sistema 
    /// </summary>
    public class SignoVital //: HistoriaClinica
    {
        public int Id { get; set; }
        public string FechaRegistro { get; set; }
        public string Oximetria { get; set; }
        public string FrecuenciaRespiratoria { get; set; }
        public string FrecuenciaCardiaca { get; set; }
        public string Temperatura { get; set; }
        public string PresionArterial { get; set; }
        public string Glicemia { get; set; }
        public int? HistoriaClinicaId {get; set; }
        public HistoriaClinica HistoriaClinica {get; set; }
    }
}