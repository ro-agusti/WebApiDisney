using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WebAppDisney.Models
{
    [Table("Personaje")]
    public class Personaje
    {
        public int Id { get; set; }

        [DisplayName("Imagen")]
        public byte[] Imagen { get; set; }

        [Required(ErrorMessage = "Is Required")]
        [Column("varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        [Required(ErrorMessage = "Is Required")]
        public string Historia { get; set; }

        public int IdPeliculaSerie { get; set; }

        [ForeignKey("IdPeliculaSerie")]
        public PeliculaSerie PeliculaSerie { get; set; }
    }
}
