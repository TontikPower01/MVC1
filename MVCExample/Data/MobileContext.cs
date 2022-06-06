using Microsoft.EntityFrameworkCore;
using MVCExample.Models;

namespace MVCExample.Data
{

  public class MobileContext : DbContext
  {
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Phone> Orders { get; set; }

    public MobileContext(DbContextOptions<MobileContext> options) : base(options)
    {

    }
  }
}
