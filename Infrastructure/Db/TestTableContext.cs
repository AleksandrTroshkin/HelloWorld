using Domain.Models;
using System.Data.Entity;

namespace Infrastructure
{
    public class TestTableContext : DbContext
    {
        public TestTableContext()
            : base()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
            Database.CommandTimeout = 180;
        }

        public DbSet<TestTable> TestTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TestTable>()
                .HasKey(x => x.TestTableId); //назначаем кастомный ключ
        }
    }
}
