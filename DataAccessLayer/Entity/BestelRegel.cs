using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class BestelRegel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Bestelling")]
        public int BestellingId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public int Aantal { get; set; }
        [Required]
        public decimal Prijs { get; set; }
        [ForeignKey("BestellingId")]
        public Bestelling Bestelling { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
