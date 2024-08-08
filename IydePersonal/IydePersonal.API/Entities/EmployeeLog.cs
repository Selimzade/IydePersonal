using IydePersonal.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace IydePersonal.API.Entities
{
    public class EmployeeLog
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CreateDate { get; set; }
        public Store store { get; set; }
        public Employee employee { get; set; }

    }
}
