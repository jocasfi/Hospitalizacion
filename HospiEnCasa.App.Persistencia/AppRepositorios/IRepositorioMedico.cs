using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {

        Medico AddMedico(Medico medico);

        void DeleteMedico(int idMedico);

        Medico GetMedico(int idMedico);

        IEnumerable<Medico> GetAllMedico();

        Medico UpdateMedico(Medico medico);
    }
}