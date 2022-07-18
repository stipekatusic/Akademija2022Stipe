using System.Threading;
using System.Threading.Tasks;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IAcademyDbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<Test> Tests{ get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
