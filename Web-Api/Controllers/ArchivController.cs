using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api.DataBase;
using Web_Api.Modules;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchiveController : ControllerBase
    {
        ClientDbContext clientDb;

        public ArchiveController(ClientDbContext clientDb)
        {
            this.clientDb = clientDb;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Archiv>>> Get()
        {
            return await clientDb.Archivs.ToListAsync();
        }
    }
}
