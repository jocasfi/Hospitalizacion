using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarEnfermeroModel : PageModel
    {
        //Conexion a la BDs
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero( new HospiEnCasa.App.Persistencia.AppContext() );

        [BindProperty]
        public Enfermero Enfermero{get; set;}

        public ActionResult OnGet(int id)
        {
            this.Enfermero = _repositorioEnfermero.GetEnfermero(id);
            return Page();
        }
        
        public ActionResult OnPost()
        {
            try{
                Enfermero enfermeroActualizado = _repositorioEnfermero.UpdateEnfermero(Enfermero);
                return RedirectToPage("./ListadoEnfermeros");
            }catch(System.Exception e)
            {
                    ViewData["Error"] = "Error: " + e.Message;
                    return Page();
            }
        }
    }
}
