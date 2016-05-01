using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleStore.Domain.Entities;
using SampleStore.Domain.Entities.Concrete;

namespace SampleStore.WebUI.Models
{
  public class IndexPageModel
  {
    private ProductRepository productsRepo = new ProductRepository();
    private UsersRepository usersRepo = new UsersRepository();

    public IQueryable<Product> Products
    {
      get { return productsRepo.Products; }
      set { productsRepo.Products = Products; }
    }

    public IQueryable<User> Users
    {
      get { return usersRepo.Users; }
      set { usersRepo.Users = Users; }
    }
  }
}