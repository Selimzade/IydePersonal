using System.ComponentModel.DataAnnotations;

namespace IydePersonal.API.Entities
{
    public class Store
    {
        [Key]
        [Required]
        public int StoreId { get; set; }
        [Required]
        [StringLength(20)]
        public string StoreName { get; set; } 
        public List<EmployeeLog> employeeLogs { get; set; }
    }
}
