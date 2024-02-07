using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext: DbContext
{
    public DbSet<Auction> Auctions { get; set; } = default!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\pfave\\Documents\\Estudos\\RocketSeat\\nlw-Expert\\leilaoDbNLW.db");
    }
}
