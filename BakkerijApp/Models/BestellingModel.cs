using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijApp.Models
{
    public class BestellingModel
    {
        public int Id { get; set; }
        public string klantVoormaam { get; set; }
        public string klantTussenvoegsel { get; set; }
        public string klantAchternaam { get; set; }
        public DateTime Bestellingsdatum { get; set; }
    }
}
