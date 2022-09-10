using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSignoVital
    {

        SignoVital AddSignoVital(SignoVital signoVital);

        void DeleteSignoVital(int idSignoVital);

        SignoVital GetSignoVital(int idSignoVital);

        IEnumerable<SignoVital> GetAllSignoVital();

        SignoVital UpdateSignoVital(SignoVital signoVital);
    }
}