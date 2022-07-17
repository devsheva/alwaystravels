using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLOD.AlwaysTravels.WebApp.Pages.Travels
{
    public class IndexModel : PageModel
    {
        private readonly ITravelsService _travelsService;
        private readonly IStagesService _stagesService;
        private readonly ISPService _spService;
        private readonly IPackagesService _packagesService;
        public Travel Travel { get; set; }
        public IEnumerable<Stage> Stages { get; set; }
        public IEnumerable<Package> Packages { get; set; }
        public IEnumerable<SP> SP { get; set; }
        public IndexModel(ITravelsService travelsService, IStagesService stagesService, ISPService spService, IPackagesService packagesService)
        {
            _travelsService = travelsService;
            _stagesService = stagesService;
            _spService = spService;
            _packagesService = packagesService;
        }

        public async Task OnGetAsync(int id)
        {
            Travel = await _travelsService.GetTravelByIdAsync(id);
            Stages = (await _stagesService.GetStagesByTravelIdAsync(Travel.Id)).OrderBy(s => s.Date);

            SP = await _spService.GetAllSPsAsync();

            // Get packages
            Packages = await _packagesService.GetAllPackagesAsync();
        }
    }
}
