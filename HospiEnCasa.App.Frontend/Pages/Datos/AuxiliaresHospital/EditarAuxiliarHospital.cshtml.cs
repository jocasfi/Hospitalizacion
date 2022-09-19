using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarAuxiliarHospitalModel : PageModel
    {
        //Conexion a la BDs
        private static IRepositorioAuxiliarHospital
            _repositorioAuxiliarHospital =
                new RepositorioAuxiliarHospital(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public AuxiliarHospital AuxiliarHospital { get; set; }

        public ActionResult OnGet(int id)
        {
            this.AuxiliarHospital = _repositorioAuxiliarHospital.GetAuxiliarHospital(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                AuxiliarHospital AuxiliarHospitalActualizado =
                    _repositorioAuxiliarHospital.UpdateAuxiliarHospital(AuxiliarHospital);
                return RedirectToPage("./ListadoAuxiliaresHospital");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
