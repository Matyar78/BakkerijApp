using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Prijs { get; set; }
        public int Aantal { get; set; }
        public decimal SubTotaal { get; set; }
    }
}
