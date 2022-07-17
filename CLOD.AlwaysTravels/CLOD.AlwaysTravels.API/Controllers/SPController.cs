using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLOD.AlwaysTravels.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPController : ControllerBase
    {
        private readonly ISPService _spService;

        public SPController(ISPService spService)
        {
            _spService = spService;
        }

        // GET api/<SPController>/stage/5
        [HttpGet("stage/{stageId}")]
        public async Task<IEnumerable<SP>> GetByStage(int stageId)
        {
            var list = await _spService.GetSPsByStageAsync(stageId);
            return list;
        }

        // GET api/<SPController>/package/5
        [HttpGet("package/{packageId}")]
        public async Task<IEnumerable<SP>> GetByPackage(int packageId)
        {
            var list = await _spService.GetSPsByPackageAsync(packageId);
            return list;
        }

        // POST api/<SPController>
        [HttpPost]
        public async Task<ActionResult<SP>> Create(SP sp)
        {
            var id = await _spService.InsertSPAsync(sp);
            sp.Id = id;
            return Ok(sp);
        }

    }
}
