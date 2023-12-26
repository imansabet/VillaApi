using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VillaApi.Data;
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
            return VillaStore.villaList;
        }
    }
}
