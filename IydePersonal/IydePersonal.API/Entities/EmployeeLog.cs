using IydePersonal.Core.Entities;

namespace IydePersonal.API.Entities
{
    public class EmployeeLog
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
