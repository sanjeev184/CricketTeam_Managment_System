using CricketTeam_Managment_System.Model;
using CricketTeam_Managment_System.Service_layer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Non_database_Project.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CricketController : ControllerBase
    {
        public ICricketService _cricketerService;

        public CricketController(ICricketService cricketerService)
        {
            _cricketerService = cricketerService;
        }

        [HttpGet]
        [Route("Display")]

        public async Task<IActionResult> GetAll()
        {
           var display = await _cricketerService.GetAll();
            if (display == null)
            {
                return BadRequest();
            }
            return Ok(display);
        }

        [HttpGet]
        [Route("search/id")]
        public async Task<IActionResult> GetId(int id)
        {
            if (id == 0)
             
                return NotFound();

            var  display = await _cricketerService.Get(id);

            if (display == null)
            {
                return NotFound();
            }
            return Ok(display);
        }

        [HttpPost]
        [Route("Insert")]
        public async Task<IActionResult> Insert(CricketTeam cricketTeam)
        {
            var  Insert = await _cricketerService.Add(cricketTeam);
           if(Insert == null)
            {
                return BadRequest();
            }
            return Ok(Insert);

        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {

            var remove = await _cricketerService.Delete(id);

            return Ok(remove);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CricketTeam cricketTeam)
        {

            var cricketteam = await _cricketerService.Update(cricketTeam);

            return Ok(cricketteam);
        }
    }
}
