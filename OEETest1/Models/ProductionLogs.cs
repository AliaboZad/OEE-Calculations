using System.ComponentModel.DataAnnotations;

namespace OEETest1.Models
{
	public class ProductionLogs
	{
        [Key]
        public int Id { get; set; }
        public int Total_parts_produced { get; set; }
        public int Defective_parts { get; set; }

        public int ShiftsId { get; set; }

        public virtual Shifts shifts { get; set; }
    }
}
