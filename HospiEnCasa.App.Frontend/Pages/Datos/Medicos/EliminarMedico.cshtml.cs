using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EliminarMedicoModel : PageModel
    {
        //Conexion a la BDs
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico( new HospiEnCasa.App.Persistencia.AppContext() );

        //[BindProperty]
        public Medico Medico{get; set;}

        public ActionResult OnGet(int id)
        {
            try{
                _repositorioMedico.DeleteMedico(id);
                return RedirectToPage("./ListadoMedicos");
            }catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                //return RedirectToPage("./ListadoMedicos");
            }
            return Page();
        }
        
    }
}
