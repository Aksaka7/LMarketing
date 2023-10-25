using AlistirmaDers3API.Context.Domain;
using Microsoft.EntityFrameworkCore;

namespace AlistirmaDers3API.Context
{
    public class MarketingDBContext: DbContext
    {
        public MarketingDBContext(DbContextOptions<MarketingDBContext> options): base(options) 
        {
        
        }
 
        public DbSet<Register> Registers { get; set; }
    }
}
