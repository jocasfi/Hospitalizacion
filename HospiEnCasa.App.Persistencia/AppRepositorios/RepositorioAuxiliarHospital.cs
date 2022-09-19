using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioAuxiliarHospital : IRepositorioAuxiliarHospital
    {
        // Conectar
        private readonly AppContext _appContext;

        // Constructor
        public RepositorioAuxiliarHospital(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public AuxiliarHospital
        AddAuxiliarHospital(AuxiliarHospital auxiliarHospital)
        {
            //Configuramos ambiente para adicion del auxiliar
            var auxiliarHospitalAdicionado =
                this._appContext.AuxiliarHospital.Add(auxiliarHospital);

            //Guardamos info auxiliar en la BDs
            this._appContext.SaveChanges();

            return auxiliarHospitalAdicionado.Entity;
        }

        public void DeleteAuxiliarHospital(int idAuxiliar)
        {
            //Configuramos el ambiente para adiccion de auxiliar
            var auxiliarEliminar =
                this
                    ._appContext
                    .AuxiliarHospital
                    .FirstOrDefault(a => a.Id == idAuxiliar);

            if (auxiliarEliminar != null)
            {
                this._appContext.AuxiliarHospital.Remove(auxiliarEliminar);
                this._appContext.SaveChanges();
            }
        }
        public AuxiliarHospital GetAuxiliarHospital(int idAuxiliar)
        {
            return
                this._appContext.AuxiliarHospital
                    .Where( a => a.Id == idAuxiliar)
                        .SingleOrDefault<AuxiliarHospital>();
        }

        public IEnumerable<AuxiliarHospital> GetAllAuxiliarHospital()
        {
            return this._appContext.AuxiliarHospital;
        }

        public AuxiliarHospital UpdateAuxiliarHospital(AuxiliarHospital auxiliarHospital)
        {
            var auxiliarEncontrado =
                this._appContext.AuxiliarHospital
                    .FirstOrDefault(a=> a.Id == auxiliarHospital.Id);
            if (auxiliarEncontrado != null)
            {
                auxiliarEncontrado.Nombre = auxiliarHospital.Nombre;
                auxiliarEncontrado.Apellidos = auxiliarHospital.Apellidos;
                auxiliarEncontrado.NumeroTelefono = auxiliarHospital.NumeroTelefono;
                auxiliarEncontrado.Genero = auxiliarHospital.Genero;
                
                this._appContext.SaveChanges();
            }
            return auxiliarEncontrado;
        }
    }
}
