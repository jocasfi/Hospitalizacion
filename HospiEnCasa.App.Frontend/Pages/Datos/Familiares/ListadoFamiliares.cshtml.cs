using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoFamiliaresModel : PageModel
    {
        // Conexion a la BDs
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar( new HospiEnCasa.App.Persistencia.AppContext() );
        
        public IEnumerable<Familiar> Familiares{get; set; }
        
        //Constructor
        public ListadoFamiliaresModel()
        {}
        public void OnGet()
        {
            this.Familiares = _repositorioFamiliar.GetAllFamiliar();
        }
    }
}
