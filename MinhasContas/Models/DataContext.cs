using Microsoft.EntityFrameworkCore;
using minhas_contas.Models;

namespace minhas_contas.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
            :base(options){}

        public DbSet<Account> Accounts {get; set; }
    }
}