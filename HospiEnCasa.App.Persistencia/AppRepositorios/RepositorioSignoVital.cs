using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSignoVital : IRepositorioSignoVital
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioSignoVital(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public SignoVital AddSignoVital(SignoVital signoVital)
        {
            //Configuramos el ambiente para adiccion del Signo Vital
            var signoVitalAdicionado = this._appContext.SignosVitales.Add(signoVital);
            //Guardar info signo vital en BDs
            this._appContext.SaveChanges();

            return signoVitalAdicionado.Entity;
        }

        public void DeleteSignoVital(int idSignoVital)
        {
            //Configuramos el ambiente para adiccion del signo vital
            var signoVitalEliminar =
                this._appContext.SignosVitales
                    .FirstOrDefault(s => s.Id == idSignoVital);

            if( signoVitalEliminar != null )      
            {
                this._appContext.SignosVitales.Remove(signoVitalEliminar);
                this._appContext.SaveChanges();
            }
        }

        public SignoVital GetSignoVital(int idSignoVital)
        {
            return
                this._appContext.SignosVitales
                    .Where( s => s.Id == idSignoVital)
                        .SingleOrDefault<SignoVital>();
        }

        public IEnumerable<SignoVital> GetAllSignoVital()
        {
            return this._appContext.SignosVitales;
        }

        public SignoVital UpdateSignoVital(SignoVital signoVital)
        {
            var signoVitalEncontrado =
                this._appContext.SignosVitales
                    .FirstOrDefault(s=> s.Id == signoVital.Id);
            if (signoVitalEncontrado != null)
            {
                signoVitalEncontrado.FechaRegistro = signoVital.FechaRegistro;
                signoVitalEncontrado.Oximetria = signoVital.Oximetria;
                signoVitalEncontrado.FrecuenciaRespiratoria = signoVital.FrecuenciaRespiratoria;
                signoVitalEncontrado.FrecuenciaCardiaca = signoVital.FrecuenciaCardiaca;
                signoVitalEncontrado.Temperatura = signoVital.Temperatura;
                signoVitalEncontrado.PresionArterial = signoVital.PresionArterial;
                signoVitalEncontrado.Glicemia = signoVital.Glicemia;
                //signoVitalEncontrado.HistoriaClinicaId = signoVital.HistoriaClinicaId;
                
                this._appContext.SaveChanges();
            }
            return signoVitalEncontrado;
        }
    }
}