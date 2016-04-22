using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleStore.Model.Entities;
using SampleStore.Model.Entities.Abstract;

namespace SampleStore.Model.Entities.Concrete
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
