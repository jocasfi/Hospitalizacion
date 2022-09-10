using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class listadoFamiliaresModel : PageModel
    {

        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new HospiEnCasa.App.Persistencia.AppContext() );

        public IEnumerable<Familiar> ListaFamiliares{get; set; }

        public listadoFamiliaresModel(){

        }
        public void OnGet()
        {
            this.ListaFamiliares = _repositorioFamiliar.GetAllFamiliar();
        }
    }
}
