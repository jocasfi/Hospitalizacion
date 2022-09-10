using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class VerEnfermeroModel : PageModel
    {
        // Conexion a la BDs
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero( new HospiEnCasa.App.Persistencia.AppContext() );

        //Generamos variable para mapear el usuario
        public Enfermero Enfermero{get;set;}

        //Constructor
        public VerEnfermeroModel()
        {}

        public ActionResult OnGet(int id)
        {
            this.Enfermero = _repositorioEnfermero.GetEnfermero(id);
            return Page();
        }
    }
}
