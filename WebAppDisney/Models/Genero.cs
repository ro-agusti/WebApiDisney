using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WebAppDisney.Models
{
    [Table("Genero")]
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Is Required")]
        [Column("varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [DisplayName("Imagen")]
        public byte[] Imagen { get; set; }

        public List<PeliculaSerie> PeliculasSeries { get; set; }

    }
}
