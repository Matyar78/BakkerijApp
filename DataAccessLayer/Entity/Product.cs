using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        [Required]
        public string ProductNaam { get; set; }
        [MaxLength(1000)]
        [Required]
        public string Omschrijving { get; set; }
        [Required]
        public decimal Prijs { get; set; }
        [Required]
        public int Voorraad { get; set; }
    }
}
