using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioHistoria(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public HistoriaClinica AddHistoria(HistoriaClinica historiaClinica)
        {
            //Configuramos el ambiente para adiccion de Historia Clinica
            var historiaAdicionada = this._appContext.HistoriasClinicas.Add(historiaClinica);
            //Guardar info historia en BDs
            this._appContext.SaveChanges();

            return historiaAdicionada.Entity;
        }

        public void DeleteHistoria(int idHistoria)
        {
            //Configuramos el ambiente para adiccion de historia clinica
            var historiaEliminar =
                this._appContext.HistoriasClinicas
                    .FirstOrDefault(h => h.Id == idHistoria);

            if( historiaEliminar != null )      
            {
                this._appContext.HistoriasClinicas.Remove(historiaEliminar);
                this._appContext.SaveChanges();
            }
        }

        public HistoriaClinica GetHistoria(int idHistoria)
        {
            return
                this._appContext.HistoriasClinicas
                    .Where( h => h.Id == idHistoria)
                        .SingleOrDefault<HistoriaClinica>();
        }

        public IEnumerable<HistoriaClinica> GetAllHistoria()
        {
            return this._appContext.HistoriasClinicas;
        }

        public HistoriaClinica UpdateHistoria(HistoriaClinica historiaClinica)
        {
            var historiaEncontrado =
                this._appContext.HistoriasClinicas
                    .FirstOrDefault(f=> f.Id == historiaClinica.Id);
            if (historiaEncontrado != null)
            {
                historiaEncontrado.Identificador = historiaClinica.Identificador;
                historiaEncontrado.Diagnostico = historiaClinica.Diagnostico;
                historiaEncontrado.Entorno = historiaClinica.Entorno;
                //historiaEncontrado.PacienteId = historiaClinica.PacienteId;
                //historiaEncontrado.MedicoId = historiaClinica.MedicoId;
                
                this._appContext.SaveChanges();
            }
            return historiaEncontrado;
        }
    }
}