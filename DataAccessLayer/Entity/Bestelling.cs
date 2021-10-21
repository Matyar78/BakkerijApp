using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Bestelling
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Klant")]
        public int KlantId { get; set; }
        [Required]
        public DateTime BestelDatum { get; set; }
        [ForeignKey("KlantId")]
        public Klant Klant { get; set; }
        public ICollection<BestelRegel> Producten { get; set; }
    }
}
