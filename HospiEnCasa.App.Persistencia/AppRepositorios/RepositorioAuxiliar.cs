using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioAuxiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public AuxiliarHospital AddAuxiliar(AuxiliarHospital auxiliarHospital)
        {
            //Configuramos el ambiente para adiccion de auxiliar
            var auxiliarAdicionado = this._appContext.AuxiliarHospital.Add(auxiliarHospital);
            //Guardar info auxiliar en BDs
            this._appContext.SaveChanges();

            return auxiliarAdicionado.Entity;
        }

        public void DeleteAuxiliar(int idAuxiliar)
        {
            //Configuramos el ambiente para adiccion de auxiliar
            var auxiliarEliminar =
                this._appContext.AuxiliarHospital
                    .FirstOrDefault(a => a.Id == idAuxiliar);

            if( auxiliarEliminar != null )      
            {
                this._appContext.AuxiliarHospital.Remove(auxiliarEliminar);
                this._appContext.SaveChanges();
            }
        }

        public AuxiliarHospital GetAuxiliar(int idAuxiliar)
        {
            return
                this._appContext.AuxiliarHospital
                    .Where( a => a.Id == idAuxiliar)
                        .SingleOrDefault<AuxiliarHospital>();
        }

        public IEnumerable<AuxiliarHospital> GetAllAuxiliar()
        {
            return this._appContext.AuxiliarHospital;
        }

        public AuxiliarHospital UpdateAuxiliar(AuxiliarHospital auxiliarHospital)
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