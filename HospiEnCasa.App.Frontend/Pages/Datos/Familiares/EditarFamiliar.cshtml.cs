using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarFamiliarModel : PageModel
    {
        //Conexion a la BDs
        private static IRepositorioFamiliar
            _repositorioFamiliar =
                new RepositorioFamiliar(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Familiar Familiar { get; set; }

        public ActionResult OnGet(int id)
        {
            this.Familiar = _repositorioFamiliar.GetFamiliar(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Familiar FamiliarActualizado =
                    _repositorioFamiliar.UpdateFamiliar(Familiar);
                return RedirectToPage("./ListadoFamiliares");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
