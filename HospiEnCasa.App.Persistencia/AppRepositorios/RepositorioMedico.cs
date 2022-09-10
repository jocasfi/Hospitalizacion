using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioMedico(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Medico AddMedico(Medico medico)
        {
            //Configuramos el ambiente para adiccion de medico
            var medicoAdicionado = this._appContext.Medicos.Add(medico);
            //Guardar info medico en BDs
            this._appContext.SaveChanges();

            return medicoAdicionado.Entity;
        }

        public void DeleteMedico(int idMedico)
        {
            //Configuramos el ambiente para adiccion de medico
            var medicoEliminar =
                this._appContext.Medicos
                    .FirstOrDefault(m => m.Id == idMedico);

            if( medicoEliminar != null )      
            {
                this._appContext.Medicos.Remove(medicoEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Medico GetMedico(int idMedico)
        {
            return
                this._appContext.Medicos
                    .Where( m => m.Id == idMedico)
                        .SingleOrDefault<Medico>();
        }

        public IEnumerable<Medico> GetAllMedico()
        {
            return this._appContext.Medicos;
        }

        public Medico UpdateMedico(Medico medico)
        {
            var medicoEncontrado =
                this._appContext.Medicos
                    .FirstOrDefault(m=> m.Id == medico.Id);
            if (medicoEncontrado != null)
            {
                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.RegRethus = medico.RegRethus;
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellidos = medico.Apellidos;
                medicoEncontrado.NumeroTelefono = medico.NumeroTelefono;
                medicoEncontrado.Genero = medico.Genero;
                
                this._appContext.SaveChanges();
            }
            return medicoEncontrado;
        }
    }
}