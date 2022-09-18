using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoEnfermerosModel : PageModel
    {
        // Conexion a la BDs
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero( new HospiEnCasa.App.Persistencia.AppContext() );
        
        public IEnumerable<Enfermero> Enfermeros{get; set; }
        
        //Constructor
        public ListadoEnfermerosModel()
        {}
        public void OnGet()
        {
            this.Enfermeros = _repositorioEnfermero.GetAllEnfermero();
        }
    }
}
