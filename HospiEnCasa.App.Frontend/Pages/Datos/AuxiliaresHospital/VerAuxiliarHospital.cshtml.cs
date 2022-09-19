using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class VerAuxiliarHospitalModel : PageModel
    {
        // Conexion a la BDs
        private static IRepositorioAuxiliarHospital _repositorioAuxiliarHospital = new RepositorioAuxiliarHospital( new HospiEnCasa.App.Persistencia.AppContext() );

        //Generamos variable para mapear el usuario
        public AuxiliarHospital AuxiliarHospital{get;set;}

        //Constructor
        public VerAuxiliarHospitalModel()
        {}

        public ActionResult OnGet(int id)
        {
            this.AuxiliarHospital = _repositorioAuxiliarHospital.GetAuxiliarHospital(id);
            return Page();
        }
    }
}
