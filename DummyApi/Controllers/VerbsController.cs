using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DummyApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class VerbsController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] string obj)
		{
			if (obj == null) return BadRequest("Empty Obj");
			return Ok(obj);
		}

		[HttpPost]
		
		public async Task<IActionResult> Post(string obj)
		{		
			if (obj == null) return BadRequest("Empty Obj");
			return Ok(obj);
		}


		[HttpPut]
		public async Task<IActionResult> Put(string obj)
		{
			if (obj == null) return BadRequest("Empty Obj");
			return Ok(obj);
		}


		[HttpDelete]
		public async Task<IActionResult> Delete(string obj)
		{
			if (obj == null) return BadRequest("Empty Obj");
			return Ok(obj);
		}
	}
}
