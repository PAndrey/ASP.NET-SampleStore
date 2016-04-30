using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStore.Domain.Entities.Abstract
{
    public interface IUserRepository
    {
      IQueryable<User> Users { get; set; }
    }
}
