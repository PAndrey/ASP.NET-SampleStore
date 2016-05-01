using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleStore.Domain.Entities.Abstract;
using SampleStore.Domain.Entities;

namespace SampleStore.Domain.Entities.Concrete
{
  public class UsersRepository : IUserRepository
  {
    EFDbContext context = new EFDbContext();
    public IQueryable<User> Users
    {
      get
      {
        return context.Users;
      }
      set
      {
        context.SaveChanges();
      }
    }
  }
}
