using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using System;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EliminarEnfermeroModel : PageModel
    {
        //Conexion a la BDs
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero( new HospiEnCasa.App.Persistencia.AppContext() );

        //[BindProperty]
        public Enfermero Enfermero{get; set;}

        public ActionResult OnGet(int id)
        {
            try{
                _repositorioEnfermero.DeleteEnfermero(id);
                return RedirectToPage("./ListadoEnfermeros");
            }catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                //return RedirectToPage("./ListadoEnfermeros");
            }
            return Page();
        }
    }
}
