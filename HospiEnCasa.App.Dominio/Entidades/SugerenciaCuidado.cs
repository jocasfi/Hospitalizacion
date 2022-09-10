namespace HospiEnCasa.App.Dominio
{

    public class SugerenciaCuidado //: HistoriaClinica
    {
        public int Id { get; set; }
        public string FechaHoraCreacion { get; set; }
        public string Descripcion { get; set; }
        public int? HistoriaClinicaId {get; set; }
        public HistoriaClinica HistoriaClinica {get; set; }
    }
}