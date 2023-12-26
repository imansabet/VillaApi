using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VillaApi.Models;
using VillaApi.Models.DTO;

namespace VillaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas() 
        {
            return new List<VillaDTO> 
            {
                new VillaDTO { Id = 1,Name = "Pool View"},
                new VillaDTO { Id = 2,Name = "Beach View"},
            };
        }
    }
}
