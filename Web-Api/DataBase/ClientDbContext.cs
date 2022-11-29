using Microsoft.EntityFrameworkCore;
using Web_Api.Modules;

namespace Web_Api.DataBase
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Archiv> Archivs { get; set; }

        public ClientDbContext(DbContextOptions<ClientDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData
                (
                new Client { id = 1, Name = "Nix", idWallet = 1, idArchive = 1},
                new Client { id = 2, Name = "Tim", idWallet = 2, idArchive = 2}
                );
            modelBuilder.Entity<Wallet>().HasData
                (
                new Wallet { id = 1, BTC = 2m, ETH = 0.03m , DOGE = 0m},
                new Wallet { id = 2, BTC = 1m, ETH = 1.12m, DOGE = 1m }
                );
            modelBuilder.Entity<Archiv>().HasData
                (
                new Archiv { id = 1, idClientOut = 1, idClientIn = 2, TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 2, idClientOut = 2, idClientIn = 1, TypeCurrency = "ETH", TypeTransfer = "online", DateTime = new DateTime() }
                );
        }
    }
}
