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
                new Client { id = 1, Ls = "1111-1111", Name = "Nix"},
                new Client { id = 2, Ls = "3333-3333", Name = "Son" },
                new Client { id = 3, Ls = "4444-4444", Name = "Max" },
                new Client { id = 4, Ls = "5555-5555", Name = "Bob" },
                new Client { id = 5, Ls = "6666-6666", Name = "Ana" },
                new Client { id = 6, Ls = "2222-2222", Name = "Tim"}
                );
            modelBuilder.Entity<Wallet>().HasData
                (
                new Wallet { id = 1, Ls = "1111-1111", BTC = 2m, ETH = 0.03m , DOGE = 5m},
                new Wallet { id = 2, Ls = "2222-2222", BTC = 5m, ETH = 0.3m, DOGE = 2m },
                new Wallet { id = 3, Ls = "4444-4444", BTC = 0.12m, ETH = 2m, DOGE = 0.12m },
                new Wallet { id = 4, Ls = "3333-3333", BTC = 12m, ETH = 1m, DOGE = 22m },
                new Wallet { id = 5, Ls = "5555-5555", BTC = 0.33m, ETH = 5m, DOGE = 5m },
                new Wallet { id = 6, Ls = "6666-6666", BTC = 0.002m, ETH = 12m, DOGE = 12m }
                );
            modelBuilder.Entity<Archiv>().HasData
                (
                new Archiv { id = 1, LsClientOut = "1111-1111", LsClientIn = "2222 - 2222",  TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 2, LsClientOut = "1111-1111", LsClientIn = "6666-6666", TypeCurrency = "ETH", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 3, LsClientOut = "3333-3333", LsClientIn = "5555-5555", TypeCurrency = "DOGE", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 4, LsClientOut = "6666-6666", LsClientIn = "2222-2222", TypeCurrency = "ETH", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 5, LsClientOut = "2222-2222", LsClientIn = "4444-4444", TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 6, LsClientOut = "3333-3333", LsClientIn = "6666-6666", TypeCurrency = "DOGE", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 7, LsClientOut = "5555-5555", LsClientIn = "2222-2222", TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 8, LsClientOut = "6666-6666", LsClientIn = "4444-4444", TypeCurrency = "ETH", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 9, LsClientOut = "2222-2222", LsClientIn = "6666-6666", TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 10, LsClientOut = "6666-6666", LsClientIn = "2222-2222", TypeCurrency = "ETH", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 11, LsClientOut = "2222-2222", LsClientIn = "4444-4444", TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 12, LsClientOut = "3333-3333", LsClientIn = "6666-6666", TypeCurrency = "DOGE", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 13, LsClientOut = "5555-5555", LsClientIn = "2222-2222", TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 14, LsClientOut = "6666-6666", LsClientIn = "4444-4444", TypeCurrency = "ETH", TypeTransfer = "online", DateTime = new DateTime() },
                new Archiv { id = 15, LsClientOut = "2222-2222", LsClientIn = "6666-6666", TypeCurrency = "BTC", TypeTransfer = "online", DateTime = new DateTime() }
                );
        }
    }
}
