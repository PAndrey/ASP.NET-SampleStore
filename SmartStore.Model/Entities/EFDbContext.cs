using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SampleStore.Model.Entities;

namespace SampleStore.Model.Entities
{
  public class EFDbContext : DbContext
  {
    // Доступ к продуктам
    public DbSet<Product> Products { get; set; }
    // Доступ к пользователям
    public DbSet<User>    Users { get; set; }
  }
}
