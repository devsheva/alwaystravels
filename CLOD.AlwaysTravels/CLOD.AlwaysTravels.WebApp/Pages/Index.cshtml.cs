using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLOD.AlwaysTravels.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITravelsService _travelsService;

        public IEnumerable<Travel> Travels { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ITravelsService travelsService)
        {
            _logger = logger;
            _travelsService = travelsService;
        }

        public async Task OnGetAsync()
        {
            Travels = await _travelsService.GetAllTravelsAsync();
        }
    }
}