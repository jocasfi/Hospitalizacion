using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoAuxiliaresHospitalModel : PageModel
    {
           // Conexion a la BDs
        private static IRepositorioAuxiliarHospital _repositorioAuxiliarHospital = new RepositorioAuxiliarHospital( new HospiEnCasa.App.Persistencia.AppContext() );
        
        public IEnumerable<AuxiliarHospital> AuxiliaresHospital{get; set; }
        
        //Constructor
        public ListadoAuxiliaresHospitalModel()
        {}
        public void OnGet()
        {
            this.AuxiliaresHospital = _repositorioAuxiliarHospital.GetAllAuxiliarHospital();
        }
    }
}
