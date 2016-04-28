using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleStore.Domain.Entities;
using SampleStore.Domain.Entities.Abstract;

namespace SampleStore.Domain.Entities.Concrete
{
  public class ProductRepository : IProductRepository
  {
    EFDbContext context = new EFDbContext();
    public IQueryable<Product> Products
    {
  	  get 
      {
        return context.Products;
      }

      set 
      {
//        context.Products = Products;
        context.SaveChanges();
      }
    }
  }
}
