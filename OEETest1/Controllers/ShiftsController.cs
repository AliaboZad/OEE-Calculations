using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OEETest1.Interface;
using OEETest1.Models;

namespace OEETest1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ShiftsController : ControllerBase
	{
		private readonly IShifts _shifts;
        public ShiftsController(IShifts shifts)
        {
			_shifts = shifts;
        }
		[HttpGet]
		public async Task< IActionResult > GetAll()
		{
			IEnumerable<Shifts> shifts = await _shifts.GetAll();
			return Ok(shifts);
		}

		[HttpGet("one/{id:int}")]
		public async Task<IActionResult> Getshift(int id )
		{
			var shift = await _shifts.Get(id);

			if(shift == null)
			{
				return BadRequest();
			}
			return Ok(shift);
		}

		[HttpPost]
		public async Task<IActionResult> AddShift(Shifts shiftsmodl)
		{
			var shift = new Shifts
			{
				Start_Time = DateTime.Now,
				End_Time = shiftsmodl.Start_Time,
				Planed_dowentime = shiftsmodl.Planed_dowentime
			};

			if (shift == null)
			{
				BadRequest();
			}

			await _shifts.Add(shift);
			return Ok(shift);
		}
    }
}
