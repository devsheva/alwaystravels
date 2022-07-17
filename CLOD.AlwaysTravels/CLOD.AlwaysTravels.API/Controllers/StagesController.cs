using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CLOD.AlwaysTravels.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StagesController : ControllerBase
    {
        private readonly IStagesService _stagesService;

        public StagesController(IStagesService stagesService)
        {
            _stagesService = stagesService;
        }

        // GET: api/<StagesController>
        [HttpGet]
        public async Task<IEnumerable<Stage>> GetAll()
        {
            var list = await _stagesService.GetAllStagesAsync();
            return list;
        }

        // GET api/<StagesController>/5
        [HttpGet("{id}")]
        public async Task<Stage> Get(int id)
        {
            var stage = await _stagesService.GetStageAsync(id);
            return stage;
        }

        // GET api/<StagesController>/travel/1
        [HttpGet("travel/{travelId}")]
        public async Task<IEnumerable<Stage>> GetAllByTravel(int travelId)
        {
            var list = await _stagesService.GetStagesByTravelIdAsync(travelId);
            return list;
        }

        // POST: api/<StagesController>
        [HttpPost]
        public async Task<ActionResult<Stage>> Create(Stage stage)
        {
            var id = await _stagesService.InsertStageAsync(stage);
            stage.Id = id;
            return Ok(stage);
        }

    }
}
