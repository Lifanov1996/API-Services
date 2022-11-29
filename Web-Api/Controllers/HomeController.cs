using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api.DataBase;
using Web_Api.Modules;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        ClientDbContext clientDb;

        public HomeController(ClientDbContext clientDb) 
        { 
            this.clientDb = clientDb;
        }

        /// <summary>
        /// Cписок всех клиентов
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> Get()
        {
            return await clientDb.Clients.ToListAsync();
        }

    }
}
