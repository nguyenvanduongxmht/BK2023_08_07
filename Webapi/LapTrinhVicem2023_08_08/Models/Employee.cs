using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LapTrinhVicem2023_08_08.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [DataType(DataType.Password)]
        public string Description { get; set; }
        public int Status { get; set; }
    }

}
