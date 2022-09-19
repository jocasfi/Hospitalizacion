using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
  public interface IRepositorioAuxiliarHospital
  {
    AuxiliarHospital AddAuxiliarHospital(AuxiliarHospital auxiliarHospital);

    void DeleteAuxiliarHospital(int idAuxiliar);

    AuxiliarHospital GetAuxiliarHospital(int idAuxiliar);

    IEnumerable<AuxiliarHospital> GetAllAuxiliarHospital();

    AuxiliarHospital UpdateAuxiliarHospital(AuxiliarHospital auxiliarHospital);
  }
}