namespace OEETest1.DTO
{
	public class MachinewithShiftDTO
	{
		public string Name { get; set; }
		public DateTime Start_Time { get; set; }
		public DateTime End_Time { get; set; }
		public bool Status { get; set; }
		public int? ShiftsId { get; set; }
	}
}
