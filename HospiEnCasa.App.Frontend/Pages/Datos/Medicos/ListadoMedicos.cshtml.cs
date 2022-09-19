using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoMedicosModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        public IEnumerable<Medico> Medicos {get; set;}

        public ListadoMedicosModel()
        {}
        public void OnGet()
        {
            this.Medicos = _repositorioMedico.GetAllMedico();
        }
    }
}
