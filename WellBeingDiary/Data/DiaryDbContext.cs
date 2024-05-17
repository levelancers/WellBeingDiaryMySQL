using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WellBeingDiary.Entities;

namespace WellBeingDiary.Data
{
    public class DiaryDbContext : IdentityDbContext<AppUser>
    {
        public DiaryDbContext(DbContextOptions<DiaryDbContext> options) : base(options){ }

        //public DbSet<User> Users { get; set; }
        public DbSet<DiaryNote> DiaryNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }

    }
}
