using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStore.Domain.Entities.Abstract
{
  public interface IProductRepository
  {
    IQueryable<Product> Products { get; set; }
  }
}
