using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemoryGameMvc.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MemoryGameMvc.Models
{
    public class MemoryGameMvcContext : IdentityDbContext<User>
    {
        public DbSet<List> List { get; set; }
        public DbSet<Record> Record { get; set; }

        public MemoryGameMvcContext(DbContextOptions<MemoryGameMvcContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<List>(entity =>
            {
                entity.HasIndex(e => e.UserId);
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.Caption).HasMaxLength(25);
                entity.Property(e => e.UserId).IsRequired();
                entity.HasOne(d => d.User)
                    .WithMany(p => p.List)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
