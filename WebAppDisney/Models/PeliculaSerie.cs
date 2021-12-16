using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppDisney.Validations;
using System.ComponentModel;

namespace WebAppDisney.Models
{
    [Table("Pelicula/Serie")]
    public class PeliculaSerie
    {
        public int Id { get; set; }

        [DisplayName("Imagen")]
        public byte[] Imagen { get; set; }

        [Required(ErrorMessage = "Is Required")]
        [Column("varchar")]
        [StringLength(50)]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Is Required")]
        [DisplayName("Fecha Creacion")]
        public DateTime FechaCreacion { get; set; }

        [CheckCalificacion]
        [Required(ErrorMessage = "Is Required")]
        public int Calificacion { get; set; }

        [Required(ErrorMessage = "Is Required")]
        public int IdGenero { get; set; }

        [ForeignKey("IdGenero")]
        public Genero Genero { get; set; }

        public List<Personaje> Personajes { get; set; }
    }
}
