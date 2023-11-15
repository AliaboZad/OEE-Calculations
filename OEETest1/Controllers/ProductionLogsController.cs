using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OEETest1.Data;
using OEETest1.DTO;
using OEETest1.Interface;
using OEETest1.Models;
using OEETest1.Repositry;

namespace OEETest1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductionLogsController : ControllerBase
	{
		//private readonly OEEDbContext _dbContext;
		private readonly IProductionLogs _productionLogs;
        public ProductionLogsController( IProductionLogs productionLogs)
        {
			//_dbContext = dbContext;
			_productionLogs = productionLogs;
        }

		[HttpGet]
		public async Task<IActionResult> GetAllMachines()
		{
			IEnumerable<ProductionLogs> product = await _productionLogs.GetAll();
			return Ok(product);
		}
		[HttpGet]
		[Route("one/{id:int}")]
		public async Task<IActionResult> GetProduct(int id)
		{
			var product = await _productionLogs.Get(id);
			if (product == null)
				return NotFound();

			return Ok(product);
		}

		[HttpPost]
		public async Task<IActionResult> PostProduct(ProducWtithShiftsDTO producWtithShiftsDTO)
		{
			var product = new ProductionLogs
			{
				Total_parts_produced = producWtithShiftsDTO.Total_parts_produced,
				Defective_parts = producWtithShiftsDTO.Defective_parts,
				ShiftsId = producWtithShiftsDTO.ShiftsId
			};

			if (product == null)
				return NotFound("Can not add this Product ");

			await _productionLogs.Add(product);
			return Ok(product);

		}

	}
}
