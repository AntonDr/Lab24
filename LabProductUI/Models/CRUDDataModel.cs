using System.Data.Entity;

namespace LabProductUI.Models
{
    public partial class CRUDDataModel : DbContext
    {
        public CRUDDataModel()
            : base("name=CRUDDataModel")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
