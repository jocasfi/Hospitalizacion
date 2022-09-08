using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente AddPaciente(Paciente paciente);

        void DeletePaciente(int idPaciente);

        Paciente GetPaciente(int idPaciente);

        IEnumerable<Paciente> GetAllPaciente();

        Paciente UpdatePaciente(Paciente paciente);
    }
}