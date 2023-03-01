using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBCOnnect
{
    public class EmployDB
    {
        [Key]
        public int ID { get; set; }
        [Column("EmployeeName", TypeName = "Varchar(200)")]
        public string EName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
