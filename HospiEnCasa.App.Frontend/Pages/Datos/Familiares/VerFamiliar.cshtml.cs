using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class VerFamiliarModel : PageModel
    {
        // Conexion a la BDs
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar( new HospiEnCasa.App.Persistencia.AppContext() );

        //Generamos variable para mapear el usuario
        public Familiar Familiar{get;set;}

        //Constructor
        public VerFamiliarModel()
        {}

        public ActionResult OnGet(int id)
        {
            this.Familiar = _repositorioFamiliar.GetFamiliar(id);
            return Page();
        }
    }
}
