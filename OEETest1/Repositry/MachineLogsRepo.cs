using OEETest1.Data;
using OEETest1.Interface;
using OEETest1.Models;

namespace OEETest1.Repositry
{
	public class MachineLogsRepo : GenericRepo<MachineLogs>, IMachineLogs
	{
		
		public MachineLogsRepo(OEEDbContext dbContext) : base(dbContext)
		{
			
		}
	}
}
