//System.ComponentModel.DataAnnotations;
//System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Persona</c>
    /// Modela una Persona en general en el sistema 
    /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }

        //[Required(ErrorMessage="El Campo es obligatorio")]
        public string Nombre { get; set; }
        //[Required(ErrorMessage="El Campo es obligatorio")]
        public string Apellidos { get; set; }
        //[Required(ErrorMessage="El Campo es obligatorio")]
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        //[Required(ErrorMessage="El Campo es obligatorio")]
        public string Genero { set; get; }
    }
}