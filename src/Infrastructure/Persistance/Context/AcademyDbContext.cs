using Application.Common.Interfaces;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Context
{
    public class AcademyDbContext : DbContext, IAcademyDbContext
    {
        public AcademyDbContext(DbContextOptions<AcademyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }
    }
}
