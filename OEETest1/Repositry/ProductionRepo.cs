using OEETest1.Data;
using OEETest1.Interface;
using OEETest1.Models;

namespace OEETest1.Repositry
{
	public class ProductionRepo : GenericRepo<ProductionLogs>  , IProductionLogs
	{
        public ProductionRepo(OEEDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
