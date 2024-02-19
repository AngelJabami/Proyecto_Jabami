using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Proyecto_Jabami.Models

    
{
    [Table("directores")]

    public class Director
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id_Director { get; set; }

        public string Nombre { get; set; }

        public string  ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string Genero { get; set; }

        public int Edad { get; set; }
    }
}
