using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFExample
{
    public partial class City : DbContext
    {
        public City()
            : base("name=Peoples")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Name> Names { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Name>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.Name)
                .HasForeignKey(e => e.NamesId)
                .WillCascadeOnDelete(false);
        }
    }
}
