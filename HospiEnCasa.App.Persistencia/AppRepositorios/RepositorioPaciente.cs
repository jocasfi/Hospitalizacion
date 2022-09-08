using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        // Conectar a BDs
        private readonly AppContext _appContext;
        //Contructor
        public RepositorioPaciente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Paciente AddPaciente(Paciente paciente)
        {
            //Configuramos el ambiente para adiccion de paciente
            var pacienteAdicionado = this._appContext.Pacientes.Add(paciente);
            //Guardar info paciente en BDs
            this._appContext.SaveChanges();

            return pacienteAdicionado.Entity;
        }

        public void DeletePaciente(int idPaciente)
        {
            //Configuramos el ambiente para adiccion de paciente
            var pacienteEliminar =
                this._appContext.Pacientes
                    .FirstOrDefault(p => p.Id == idPaciente);

            if( pacienteEliminar != null )      
            {
                this._appContext.Pacientes.Remove(pacienteEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Paciente GetPaciente(int idPaciente)
        {
            return
                this._appContext.Pacientes
                    .Where( p => p.Id == idPaciente)
                        .SingleOrDefault<Paciente>();
        }

        public IEnumerable<Paciente> GetAllPaciente()
        {
            return this._appContext.Pacientes;
        }

        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado =
                this._appContext.Pacientes
                    .FirstOrDefault(p=> p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Coordenadas = paciente.Coordenadas;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                
                this._appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}