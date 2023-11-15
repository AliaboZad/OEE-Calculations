using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OEETest1.Models
{
	public class MachineLogs
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set;}
        public bool Status { get; set; }
        //[ForeignKey("Shifts")]
        public int? ShiftsId { get; set; }
        public virtual Shifts Shifts { get; set; }
    }
}
