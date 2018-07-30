namespace WeddingAPI.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WeddingDB : DbContext
    {
        public WeddingDB()
            : base("name=WeddingDB")
        {
        }

        public virtual DbSet<GuestEntry> Guest { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestEntry>()
                .Property(e => e.CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GuestEntry>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);
        }
    }
}
