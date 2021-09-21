using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Medewerker
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Voornaam { get; set; }
        public string tussenvoegsel { get; set; }
        [MaxLength(255)]
        [Required]
        public string Achternaam { get; set; }
        [MaxLength(255)]
        [Required]
        public string Straat { get; set; }
        [Required]
        public int Huisnummer { get; set; }
        public string HuisnrToevoeging { get; set; }
        [Required]
        public string Postcode { get; set; }
        [MaxLength(255)]
        [Required]
        public string Plaats { get; set; }
        [Required]
        public string Telefoon { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public int BSN { get; set; }
        [Required]
        public string Functie { get; set; }
        [Required]
        public DateTime DatumInDienst { get; set; }
        public bool UitDienst { get; set; } 
    }
}
