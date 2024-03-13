using appDist.micro.History.Models;
using Microsoft.EntityFrameworkCore;

namespace appDist.micro.History.Persistences
{
    public class ContextDatabase : DbContext
    {

        public ContextDatabase(DbContextOptions options) : base(options)
        {

        }

        public DbSet<HistoryModel> Histories => Set<HistoryModel>();
    }
}
