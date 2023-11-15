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
	public class MachineLogsController : ControllerBase
	{
		//private readonly OEEDbContext _dbContext;
		private readonly IMachineLogs _machineLogs;
	
        public MachineLogsController( IMachineLogs machineLogs)
        {
			//_dbContext = dbContext;
			_machineLogs = machineLogs;

        }

		[HttpGet]
		public async Task<IActionResult> GetAllMachines()
		{
			IEnumerable<MachineLogs> machines = await _machineLogs.GetAll();
			
			return Ok(machines);
		}

		[HttpGet("one/{id:int}")]
		//[Route("{one}")]
		public async Task<IActionResult> GetMachines(int id)
		{


			var machine =  _machineLogs.Get(id);
			if (machine == null)
				return NotFound();

			return Ok(machine);
		}

		[HttpPost]
		public async Task< IActionResult> PostMachine(MachinewithShiftDTO machineDto)
		{
			var machine = new MachineLogs
			{
				Name = machineDto.Name,
				Start_Time = machineDto.Start_Time,
				End_Time = machineDto.End_Time,
				Status = machineDto.Status,
				ShiftsId = machineDto.ShiftsId
			};
			if (machine == null)
				return BadRequest();

			await _machineLogs.Add(machine);
			return Ok(machine);
		}

    }
}
