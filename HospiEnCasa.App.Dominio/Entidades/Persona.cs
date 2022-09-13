using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Persona</c>
    /// Modela una Persona en general en el sistema 
    /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        [Required(ErrorMessage="El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="El campo Apellidos es obligatorio")]
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public string Genero { set; get; }
    }
}