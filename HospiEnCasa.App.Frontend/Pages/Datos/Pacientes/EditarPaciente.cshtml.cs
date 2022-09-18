using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia; 

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarPacienteModel : PageModel
    {
        // Conexion a la base de Datos
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        
        // Declaro una variable para capturar info-pacientes

        [BindProperty]
        public Paciente Paciente { get; set; }

        public ActionResult OnGet(int Id)
        {
            this.Paciente = _repositorioPaciente.GetPaciente(Id);
            return Page();
        }

        public ActionResult OnPost()
        {
            try{
                Paciente PacienteActualizado = _repositorioPaciente.UpdatePaciente(Paciente);
                return RedirectToPage("./ListadoPacientes");
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
