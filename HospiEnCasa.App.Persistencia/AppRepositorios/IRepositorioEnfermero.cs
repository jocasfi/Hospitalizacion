using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioEnfermero
    {

        Enfermero AddEnfermero(Enfermero enfermero);

        void DeleteEnfermero(int idEnfermero);

        Enfermero GetEnfermero(int idEnfermero);

        IEnumerable<Enfermero> GetAllEnfermero();

        Enfermero UpdateEnfermero(Enfermero enfermero);
    }
}