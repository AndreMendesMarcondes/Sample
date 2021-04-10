using Microsoft.EntityFrameworkCore;
using Sample.Domain.Dices;

namespace Sample.Infra
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        private DbSet<Dice> Dice { get; set; }
    }
}
