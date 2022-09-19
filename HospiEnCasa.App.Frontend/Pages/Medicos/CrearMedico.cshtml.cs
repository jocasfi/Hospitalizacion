using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    
    public class CrearMedicoModel : PageModel
    {
        //Conexion a Base de Datos
        private static IRepositorioMedico
            _repositorioMedico =
                new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());

          [BindProperty]
        public Medico Medico { get; set; }

         public CrearMedicoModel()
        {
        }
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            try
            {
                Medico medicoAdicionado =
                    _repositorioMedico.AddMedico(this.Medico);
                return RedirectToPage("./ListadoMedicos");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }

    }
}
