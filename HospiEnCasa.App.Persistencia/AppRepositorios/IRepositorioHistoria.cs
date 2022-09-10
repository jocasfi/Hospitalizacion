using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria
    {

        HistoriaClinica AddHistoria(HistoriaClinica historiaClinica);

        void DeleteHistoria(int idHistoria);

        HistoriaClinica GetHistoria(int idHistoria);

        IEnumerable<HistoriaClinica> GetAllHistoria();

        HistoriaClinica UpdateHistoria(HistoriaClinica historiaClinica);
    }
}