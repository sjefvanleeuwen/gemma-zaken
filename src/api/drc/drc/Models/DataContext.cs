using Microsoft.EntityFrameworkCore;
using drc.Controllers;

namespace drc.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<EnkelvoudigInformatieObject> EnkelvoudiginformatieObjecten {get;set;}
        public DbSet<ZaakInformatieObject> ZaakInformatieObjecten {get;set;}
    }
}