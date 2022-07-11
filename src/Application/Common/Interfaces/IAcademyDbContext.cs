using System.Threading.Tasks;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IAcademyDbContext
    {
        public DbSet<Test> Tests { get; set; }

    }
}
