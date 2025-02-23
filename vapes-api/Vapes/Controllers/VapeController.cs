using Microsoft.AspNetCore.Mvc;
using vapes_api.Vapes.Dtos;
using vapes_api.Vapes.Models;
using vapes_api.Vapes.Repository;

namespace vapes_api.Vapes.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VapeController : ControllerBase
    {
        private IVapeRepo _vapeRepo;

        public VapeController(IVapeRepo vapeRepo)
        {
            _vapeRepo = vapeRepo;
        }

        [HttpGet("allVapes")]

        public async Task<ActionResult<List<Vape>>> GetVapesAsync()
        {
            var vape = await _vapeRepo.GetVapesAsync();

            return Ok(vape);
        }

        [HttpPost("addVape")]


        public async Task<ActionResult<VapeResponse>> CreateAsync([FromBody]VapeRequest vapeReq)
        {
            VapeResponse vapeSaved = await _vapeRepo.CreateVapeAsync(vapeReq);

            return Ok(vapeSaved);
        }
    }
}
