using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Proyecto_Jabami.Models
{
    [Table("peliculass")]

    public class Peliculas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id_Pelicula { get; set; }

        public string Nombre { get; set; }

        public int Año { get; set; }

        public string Genero { get; set; }

        public string Idioma { get; set; }

        public virtual Director director { get; set; }
}
}

