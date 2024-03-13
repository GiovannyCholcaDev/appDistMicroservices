using appDist.micro.History.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace appDist.micro.History.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HistoryController : Controller
    {

        private readonly IHistoryService _historyService;


        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await _historyService.ListAsync());
        }

    }
}
