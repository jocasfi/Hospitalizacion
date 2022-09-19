using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class VerMedicoModel : PageModel
    {
        // Conexion a la BDs
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico( new HospiEnCasa.App.Persistencia.AppContext() );

        //Generamos variable para mapear el usuario
        public Medico Medico{get;set;}

        //Constructor
        public VerMedicoModel()
        {}

        public ActionResult OnGet(int id)
        {
            this.Medico = _repositorioMedico.GetMedico(id);
            return Page();
        }
    }
}
