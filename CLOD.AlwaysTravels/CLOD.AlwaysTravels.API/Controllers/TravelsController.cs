using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLOD.AlwaysTravels.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsController : ControllerBase
    {
        private readonly ITravelsService _travelsService;

        public TravelsController(ITravelsService travelsService)
        {
            _travelsService = travelsService;
        }

        // GET api/<TravelsController>
        [HttpGet]
        public async Task<IEnumerable<Travel>> GetAll()
        {
            var list = await _travelsService.GetAllTravelsAsync();
            return list;
        }

        // GET api/<TravelsController>/id
        [HttpGet("{id}")]
        public async Task<Travel> Get(int id)
        {
            var travel = await _travelsService.GetTravelByIdAsync(id);
            return travel;
        }

        // POST api/<TravelsController>
        [HttpPost]
        public async Task<ActionResult<Travel>> Create(Travel travel)
        {
            var id = await _travelsService.InsertTravelAsync(travel);
            travel.Id = id;
            return Ok(travel);
        }
    }
}
