using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioFamiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Familiar AddFamiliar(Familiar familiar)
        {
            //Configuramos el ambiente para adiccion de familiar
            var familiarAdicionado = this._appContext.Familiares.Add(familiar);
            //Guardar info auxiliar en BDs
            this._appContext.SaveChanges();

            return familiarAdicionado.Entity;
        }

        public void DeleteFamiliar(int idFamiliar)
        {
            //Configuramos el ambiente para adiccion de familiar
            var familiarEliminar =
                this._appContext.Familiares
                    .FirstOrDefault(f => f.Id == idFamiliar);

            if( familiarEliminar != null )      
            {
                this._appContext.Familiares.Remove(familiarEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Familiar GetFamiliar(int idFamiliar)
        {
            return
                this._appContext.Familiares
                    .Where( f => f.Id == idFamiliar)
                        .SingleOrDefault<Familiar>();
        }

        public IEnumerable<Familiar> GetAllFamiliar()
        {
            return this._appContext.Familiares;
        }

        public Familiar UpdateFamiliar(Familiar familiar)
        {
            var familiarEncontrado =
                this._appContext.Familiares
                    .FirstOrDefault(f=> f.Id == familiar.Id);
            if (familiarEncontrado != null)
            {
                familiarEncontrado.Parentesco = familiar.Parentesco;
                familiarEncontrado.Email = familiar.Email;
                //familiarEncontrado.PacienteId = familiar.PacienteId;
                familiarEncontrado.Nombre = familiar.Nombre;
                familiarEncontrado.Apellidos = familiar.Apellidos;
                familiarEncontrado.NumeroTelefono = familiar.NumeroTelefono;
                familiarEncontrado.Genero = familiar.Genero;
                
                this._appContext.SaveChanges();
            }
            return familiarEncontrado;
        }
    }
}