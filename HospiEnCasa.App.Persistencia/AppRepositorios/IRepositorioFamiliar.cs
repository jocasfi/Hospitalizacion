using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioFamiliar
    {

        Familiar AddFamiliar(Familiar familiar);

        void DeleteFamiliar(int idFamiliar);

        Familiar GetFamiliar(int idFamiliar);

        IEnumerable<Familiar> GetAllFamiliar();

        Familiar UpdateFamiliar(Familiar familiar);
    }
}