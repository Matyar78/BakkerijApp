using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Klant
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
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public string HuisnrToevoeging { get; set; }
        public string Postcode { get; set; }
        [MaxLength(255)]
        public string Plaats { get; set; }
        public string Telefoon { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
    }
}
