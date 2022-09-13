using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoPacientesModel : PageModel
    {
        // Conexion a la base de Datos
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        
        // Declaro una variable para la lista de Pacientes
        public IEnumerable<Paciente> Pacientes {get; set;}

        // Constructor de la clase
        public ListadoPacientesModel()
        {}

        public void OnGet()
        {
            this.Pacientes = _repositorioPaciente.GetAllPaciente();
        }
    }
}
