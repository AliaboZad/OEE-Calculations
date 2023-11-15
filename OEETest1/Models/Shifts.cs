using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OEETest1.Models
{
	public class Shifts
	{
        [Key]
        public int Id { get; set; }
        public DateTime Start_Time { get; set; } = DateTime.Now;
        public DateTime End_Time { get; set;}
        public string Planed_dowentime { get; set; }

        [JsonIgnore]
        public  ICollection<MachineLogs> MachineLogs { get; set; } = new HashSet<MachineLogs>();
        [JsonIgnore]
        public ICollection<ProductionLogs> productionLogs { get; set; } = new HashSet<ProductionLogs>();

    }
}
