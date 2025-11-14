using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BudgetTracker.Models
{
    public partial class BudgetTrackerContext : DbContext
    {
       

        public BudgetTrackerContext(DbContextOptions<BudgetTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC0730323FB8");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
