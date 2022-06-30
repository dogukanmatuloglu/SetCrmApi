using HomeWork.Business.Abstract;
using HomeWork.Entity.Model;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers
{
    [ApiController]
    public class KampanyaController : Controller
    {
        private readonly IKampanyaService _kampanyaService;

        public KampanyaController(IKampanyaService kampanyaService)
        {
            _kampanyaService = kampanyaService;
        }

        [HttpPost]
        [Route("api/v1/kampanyaRecord")]
        public async Task<IActionResult> StartAsync([FromBody] KampanyaInputModel input)
        {
            await _kampanyaService.StartAsync(input);

            return Ok(true);
        }
    }
}
