using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace FSAAPI.Models
{
    public class FSAAPIcontext: Models.Dbcontext
    {
        public FSAAPIcontext(DbContextOptions<FSAAPIcontext> options) : base(options)
        { 

        
        }
        public DbSet<Aerodrome> Aerodromes { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Compagnie> Compagnies { get; set; }
        public DbSet<gestionnaireAerodrome> gestionnaireAerodromes { get; set; }
        public DbSet<Vol> Vols { get; set; }
    }
}
