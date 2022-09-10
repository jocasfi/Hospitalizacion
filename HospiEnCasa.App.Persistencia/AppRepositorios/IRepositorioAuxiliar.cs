using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {

        AuxiliarHospital AddAuxiliar(AuxiliarHospital auxiliarHospital);

        void DeleteAuxiliar(int idAuxiliar);

        AuxiliarHospital GetAuxiliar(int idAuxiliar);

        IEnumerable<AuxiliarHospital> GetAllAuxiliar();

        AuxiliarHospital UpdateAuxiliar(AuxiliarHospital auxiliarHospital);
    }
}