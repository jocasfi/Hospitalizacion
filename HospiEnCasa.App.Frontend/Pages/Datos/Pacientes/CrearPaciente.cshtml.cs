using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia; 

namespace HospiEnCasa.App.Frontend.Pages
{
    public class CrearPacienteModel : PageModel
    {
        // Conexion a la base de Datos
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        
        // Declaro una variable para capturar info-pacientes

        [BindProperty]
        public Paciente Paciente { get; set; }

        // Constructor de la clase
        public CrearPacienteModel()
        {}

        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            try
            {
                Paciente.MedicoId = 1;
                Paciente.EnfermeroId = 1;
                Paciente.AuxiliarHospitalId = 7;

                Paciente PacienteAdicionado = _repositorioPaciente.AddPaciente(Paciente);
                return RedirectToPage("./ListadoPacientes");
            }
            catch (Exception e)
            {
                ViewData["Error"] = e.Message;
                return Page();
            }
        }
    }
}
