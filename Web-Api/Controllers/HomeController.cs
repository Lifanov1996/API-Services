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

        /// <summary>
        /// Просмотр баланса клиента
        /// </summary>
        /// <param name="Ls"></param>
        /// <returns></returns>
        [HttpGet("{Ls}")]
        public async Task<ActionResult<IEnumerable<Wallet>>> Get(string Ls)
        {
            Wallet wallet = await clientDb.Wallets.FirstOrDefaultAsync(x => x.Ls == Ls);
            if (wallet == null)
                return NotFound();
            return new ObjectResult(wallet);
        }

        /// <summary>
        /// Добавление нового клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Client>> Post(Client client)
        {
            if (clientDb.Clients.Any(x => x.Ls == client.Ls))
            {
                return NotFound();
            }
            if (client == null)
            {
                return BadRequest();
            }
            clientDb.Clients.Add(client);
            clientDb.Wallets.Add(           
                new Wallet {Ls = client.Ls, BTC = 0, ETH = 0, DOGE = 0 });
            await clientDb.SaveChangesAsync();
            return Ok(client);
        }

        /// <summary>
        /// Изменение данных клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<Client>> Put(Client client)
        {
            if (client == null)
            {
                return NotFound();
            }
            if (!clientDb.Clients.Any(x => x.id == client.id || x.Ls == client.Ls))
            {
                return NotFound();
            }

            clientDb.Update(client);
            await clientDb.SaveChangesAsync();
            return Ok(client);
        }

        /// <summary>
        /// Удаление клиента
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> Delete(string Ls)
        {
            Client user = clientDb.Clients.FirstOrDefault(x => x.Ls == Ls);
            Wallet wallet = clientDb.Wallets.FirstOrDefault(x => x.Ls == Ls);
            if (user == null)
            {
                return NotFound();
            }
            clientDb.Clients.Remove(user);
            clientDb.Wallets.Remove(wallet);
            await clientDb.SaveChangesAsync();
            return Ok(user);
        }
    }
}
