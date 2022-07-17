using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLOD.AlwaysTravels.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly IPackagesService _packagesService;

        public PackagesController(IPackagesService packagesService)
        {
            _packagesService = packagesService;
        }

        // GET: api/<PackagesController>
        [HttpGet]
        public async Task<IEnumerable<Package>> GetAll()
        {
            var list = await _packagesService.GetAllPackagesAsync();
            return list;
        }

        // GET api/<PackagesController>/5
        [HttpGet("{id}")]
        public async Task<Package> Get(int id)
        {
            var package = await _packagesService.GetPackageAsync(id);
            return package;
        }

        // POST api/<PackagesController>
        [HttpPost]
        public async Task<ActionResult<Package>> Create(Package package)
        {
            var id = await _packagesService.InsertPackageAsync(package);
            package.Id = id;
            return Ok(package);
        }

    }
}
