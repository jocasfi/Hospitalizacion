using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioEnfermero : IRepositorioEnfermero
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioEnfermero(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Enfermero AddEnfermero(Enfermero enfermero)
        {
            //Configuramos el ambiente para adiccion de enfermero
            var enfermeroAdicionado = this._appContext.Enfermeros.Add(enfermero);
            //Guardar info enfermero en BDs
            this._appContext.SaveChanges();

            return enfermeroAdicionado.Entity;
        }

        public void DeleteEnfermero(int idEnfermero)
        {
            //Configuramos el ambiente para adiccion de enfermero
            var enfermeroEliminar =
                this._appContext.Enfermeros
                    .FirstOrDefault(e => e.Id == idEnfermero);

            if( enfermeroEliminar != null )      
            {
                this._appContext.Enfermeros.Remove(enfermeroEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Enfermero GetEnfermero(int idEnfermero)
        {
            return
                this._appContext.Enfermeros
                    .Where( e => e.Id == idEnfermero)
                        .SingleOrDefault<Enfermero>();
        }

        public IEnumerable<Enfermero> GetAllEnfermero()
        {
            return this._appContext.Enfermeros;
        }

        public Enfermero UpdateEnfermero(Enfermero enfermero)
        {
            var enfermeroEncontrado =
                this._appContext.Enfermeros
                    .FirstOrDefault(e=> e.Id == enfermero.Id);
            if (enfermeroEncontrado != null)
            {
                enfermeroEncontrado.TarjetaProfesional = enfermero.TarjetaProfesional;
                enfermeroEncontrado.HorasLaborales = enfermero.HorasLaborales;
                enfermeroEncontrado.Nombre = enfermero.Nombre;
                enfermeroEncontrado.Apellidos = enfermero.Apellidos;
                enfermeroEncontrado.NumeroTelefono = enfermero.NumeroTelefono;
                enfermeroEncontrado.Genero = enfermero.Genero;
                
                this._appContext.SaveChanges();
            }
            return enfermeroEncontrado;
        }
    }
}