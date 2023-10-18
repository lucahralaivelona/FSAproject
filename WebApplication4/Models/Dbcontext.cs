using Microsoft.EntityFrameworkCore;

namespace FSAAPI.Models
{
    public class Dbcontext
    {
        private DbContextOptions<FSAAPIcontext> options;

        public Dbcontext(DbContextOptions<FSAAPIcontext> options)
        {
            this.options = options;
        }
    }
}