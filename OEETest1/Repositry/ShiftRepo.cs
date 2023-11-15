using OEETest1.Data;
using OEETest1.Interface;
using OEETest1.Models;

namespace OEETest1.Repositry
{
	public class ShiftRepo :GenericRepo<Shifts> , IShifts
	{
        public ShiftRepo(OEEDbContext dbContext) : base (dbContext)
        {
            
        }
    }
}
