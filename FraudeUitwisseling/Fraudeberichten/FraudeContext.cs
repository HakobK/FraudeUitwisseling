using System.Data.Entity;

namespace FraudeUitwisseling.Fraudeberichten
{
    public class FraudeContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FraudeContext>(null);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Fraudesignaal> Fraudesignalen { get; set; }
    }
}
