using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Domain.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Count { get; set; } //sayi
        public decimal? Price { get; set; }

        public int Supplier { get; set; } //Təchizatçı
        public DateTime AddedDate { get; set; } = DateTime.Now; // Əlavə edilmə tarixi
        public DateTime LastUpdated { get; set; } = DateTime.Now; // Son yenilənmə tarixi
        public string? Description { get; set; } // Təsvir
        public string Codebar { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
       
    }
}
